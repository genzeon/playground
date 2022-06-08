#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ContactManagerProject.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace ContactManagerProject.Controllers
{
    public class LoginsController : Controller
    {
        private readonly Data _db;

        public LoginsController(Data db)
        {
            _db = db;
        }

        // GET: Logins
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Index(Models.Login loginusers,string? returnUrl)
        {
            if (ModelState.IsValid)
            {
                string a = loginusers.UserName;
                string b = loginusers.Password;
                TempData["UserName"]=a;


                var q = _db.UserDetails.Where(p => p.UserName == a).FirstOrDefault();
                if (q == null)
                {
                    //ViewData["b"] = "Username ";
                    ViewBag.Title = "Invalid Information-Please try again ";
                    return View();
                }
                else if (q.Password != b)
                {
                    //ViewData["b"] = "Password ";
                    ViewBag.Title = "Invalid Information-Please try again ";
                    return View();
                }
                else
                {
                    List<Claim> claims;
                    if ((q.UserName == "Anusha") && (q.Password == "1806"))
                    {

                        claims = new List<Claim>
                        {
                        new Claim(ClaimTypes.Name,q.UserName),
                       // new Claim(ClaimTypes.Email,"admin@gmail.com"),
                        new Claim("Adimn","true")
                        };
                    }
                    else
                    {
                        claims = new List<Claim>
                        {
                        new Claim(ClaimTypes.Name,q.UserName),
                       // new Claim(ClaimTypes.Email,"admin@gmail.com"),
                        new Claim("User","true")
                        };

                    }
                    var identity = new ClaimsIdentity(claims, "MyCookieAuth");
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);
                    await HttpContext.SignInAsync("MyCookieAuth", claimsPrincipal);
                    if (!string.IsNullOrEmpty(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    //return RedirectToAction("Index", "Home");
                    //ViewData["a"] = q.UserName;
                    //var listofitems = _db.AddressBooks.Include(a => a.Fkstate).ThenInclude(a => a.Fkcountry).Include(a => a.Fkuser).
                    //Where(b => b.Fkuser.UserName == a);
                    //return View("Views/Shared/_AddressBook.cshtml", listofitems);
                }
            }
            return View();
        }

        public IActionResult GetByUser()
        {
            TempData.Keep();
            string a = TempData["UserName"].ToString();
            TempData["UserName"] = a;
            ViewData["a"] = a;
            var listofitems = _db.AddressBooks.Include(a => a.Fkstate).ThenInclude(a => a.Fkcountry).Include(a => a.Fkuser).
            Where(b => b.Fkuser.UserName == a);
            return View("Views/Shared/_AddressBook.cshtml", listofitems);
        }


        [HttpPost]

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync("MyCookieAuth");
            return RedirectToAction("Index","Home");
        }
    }
}
