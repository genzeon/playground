#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ContactManagerProject.Models;
using ContactManagerProject.BusinessObject;
using Microsoft.AspNetCore.Authorization;

namespace ContactManagerProject.Controllers
{
   
    public class UserDetailsController : Controller
    {
        //private readonly Data _context;
 
        UserDetailsBO objuseretailsBO;
        public UserDetailsController(Data context)
        {
            objuseretailsBO = new UserDetailsBO(context);
        }
        //public UserDetailsController(Data context)
        //{
        //    _context = context;
        //}

        // GET: UserDetails
        [Authorize]
        public async Task<IActionResult> Index()
        {
            return View(objuseretailsBO.GetAll());
            //return View(await _context.UserDetails.ToListAsync());
        }

        // GET: UserDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userDetail = objuseretailsBO.GetById(id.Value);
            //var userDetail = await _context.UserDetails
            //    .FirstOrDefaultAsync(m => m.PkuserId == id);
            if (userDetail == null)
            {
                return NotFound();
            }

            return View(userDetail);
        }

        // GET: UserDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PkuserId,UserName,Password,FirstName,LastName,EmailId,PhoneNo,IsActive")] UserDetail userDetail)
        {
            if (ModelState.IsValid)
            {
                objuseretailsBO.Add(userDetail);
                //_context.Add(userDetail);
                //await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userDetail);
        }

        // GET: UserDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userDetail = objuseretailsBO.GetById(id.Value);
           // var userDetail = await _context.UserDetails.FindAsync(id);
            if (userDetail == null)
            {
                return NotFound();
            }
            return View(userDetail);
        }

        // POST: UserDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PkuserId,UserName,Password,FirstName,LastName,EmailId,PhoneNo,IsActive")] UserDetail userDetail)
        {
            if (id != userDetail.PkuserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
               
                    objuseretailsBO.Update(userDetail);
                
                //try
                //{
                //    _context.Update(userDetail);
                //    await _context.SaveChangesAsync();
                //}
                //catch (DbUpdateConcurrencyException)
                //{
                //    if (!UserDetailExists(userDetail.PkuserId))
                //    {
                //        return NotFound();
                //    }
                //    else
                //    {
                //        throw;
                //    }
                //}
                return RedirectToAction(nameof(Index));
            }
            return View(userDetail);
        }

        // GET: UserDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userDetail=objuseretailsBO.GetById(id.Value);
            //var userDetail = await _context.UserDetails
            //    .FirstOrDefaultAsync(m => m.PkuserId == id);
            if (userDetail == null)
            {
                return NotFound();
            }

            return View(userDetail);
        }

        // POST: UserDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            objuseretailsBO.Delete(id);
            //var userDetail = await _context.UserDetails.FindAsync(id);
            //_context.UserDetails.Remove(userDetail);
            //await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //private bool UserDetailExists(int id)
        //{
        //  return objuseretailsBO.UserExits(id);
        //}
    }
}
