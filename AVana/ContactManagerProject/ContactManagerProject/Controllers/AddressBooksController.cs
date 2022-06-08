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
    [Authorize]
    public class AddressBooksController : Controller
    {
        private readonly Data _context;
        AddressBookBO objaddressbookBO;
        CountriesBO objcountriesBO;
        StateBO objstateBO;
        UserDetailsBO objuserdetailsBO;
        public AddressBooksController(Data context)
        {
            objaddressbookBO = new AddressBookBO(context);
            objcountriesBO = new CountriesBO(context);
            objstateBO = new StateBO(context);
            objuserdetailsBO = new UserDetailsBO(context);
        }
        //public AddressBooksController(Data context)
        //{
        //    _context = context;
        //}

        // GET: AddressBooks
        //public async Task<IActionResult> Index()
        //{
        //   return View(objaddressbookBO.GetAll());
        //   // var data = _context.AddressBooks.Include(a => a.Fkstate).Include(a => a.Fkuser);
        //    //return View data.ToListAsync();
        //}

        public async Task<IActionResult> Index(int? a, string? b, string? c, string? reset)
        {
            ViewData["FkcountryId"] = new SelectList(objcountriesBO.GetAll(), "PkcountryId", "CountryName");
            ViewData["FkstateId"] = new SelectList(objstateBO.GetAllonlyselectedstates(a.ToString()), "StateName", "StateName");
            // ViewData["isactive"] = new SelectList(objaddressbookbo.GetAllio(), "IsActive", "IsActive");
            if (a == null & b == null & c == null)
            {
                return View(objaddressbookBO.GetAll());
            }
            else if (a != null & b != null & c != null & reset == "reset")
            {
                return View(objaddressbookBO.GetAll());
            }
            return View(objaddressbookBO.sort(a, b, c));

            //var data = _context.AddressBooks.Include(a => a.Fkstate).Include(a => a.Fkuser);
            //return View(await data.ToListAsync());
        }
        // GET: AddressBooks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addressBook = objaddressbookBO.GetById(id.Value);
            //var addressBook = await _context.AddressBooks
            //    .Include(a => a.Fkstate)
            //    .Include(a => a.Fkuser)
            //    .FirstOrDefaultAsync(m => m.PkaddressId == id);
            if (addressBook == null)
            {
                return NotFound();
            }

            return View(addressBook);
        }

        // GET: AddressBooks/Create
        public IActionResult Create()
        {
            ViewData["FkstateId"] = new SelectList(objstateBO.GetAll(), "PkstateId", "StateName");
            //ViewData["FKcountryId"] = new SelectList(objcountriesBO.GetAll(), "PkcountryId", "CountryName");
            ViewData["FkuserId"] = new SelectList(objuserdetailsBO.GetAll(), "PkuserId", "UserName");
            ViewData["FkCountryId"] = new SelectList(objcountriesBO.GetAll(), "CountryName", "CountryName");
            return View();
        }

        // POST: AddressBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PkaddressId,FkstateId,FkuserId,FirstName,LastName,EmailId,PhoneNo,Address1,Address2,Street,City,ZipCode,IsActive")] AddressBook addressBook)
        {
            if (ModelState.IsValid)
            {
                objaddressbookBO.Add(addressBook);
                //_context.Add(addressBook);
                //await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            
            ViewData["FkstateId"] = new SelectList(objstateBO.GetAll(), "PkstateId", "StateName", addressBook.FkstateId);
            //ViewData["FKcountryId"] = new SelectList(objcountriesBO.GetAll(), "PkcountryId", "CountryName");
            ViewData["FkuserId"] = new SelectList(objuserdetailsBO.GetAll(), "PkuserId", "UserName", addressBook.FkuserId);
            return View(addressBook);
        }

        // GET: AddressBooks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addressBook = objaddressbookBO.GetById(id.Value);
            //var addressBook = await _context.AddressBooks.FindAsync(id);
            if (addressBook == null)
            {
                return NotFound();
            }
            ViewData["FkstateId"] = new SelectList(objstateBO.GetAll(), "PkstateId", "StateName", addressBook.FkstateId);
            //ViewData["FKcountryId"] = new SelectList(objcountriesBO.GetAll(), "PkcountryId", "CountryName");
            ViewData["FkuserId"] = new SelectList(objuserdetailsBO.GetAll(), "PkuserId", "UserName", addressBook.FkuserId);
            return View(addressBook);
        }

        // POST: AddressBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PkaddressId,FkstateId,FkuserId,FirstName,LastName,EmailId,PhoneNo,Address1,Address2,Street,City,ZipCode,IsActive")] AddressBook addressBook)
        {
            if (id != addressBook.PkaddressId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                objaddressbookBO.Update(addressBook);
                //try
                //{
                //    _context.Update(addressBook);
                //    await _context.SaveChangesAsync();
                //}
                //catch (DbUpdateConcurrencyException)
                //{
                //    if (!AddressBookExists(addressBook.PkaddressId))
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
            ViewData["FkstateId"] = new SelectList(objstateBO.GetAll(), "PkstateId", "StateName", addressBook.FkstateId);
            //ViewData["FKcountryId"] = new SelectList(objcountriesBO.GetAll(), "PkcountryId", "CountryName");
            ViewData["FkuserId"] = new SelectList(objuserdetailsBO.GetAll(), "PkuserId", "UserName", addressBook.FkuserId);
            return View(addressBook);
        }

        // GET: AddressBooks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var addressBook = objaddressbookBO.GetById(id.Value);
            //var addressBook = await _context.AddressBooks
            //    .Include(a => a.Fkstate)
            //    .Include(a => a.Fkuser)
            //    .FirstOrDefaultAsync(m => m.PkaddressId == id);
            if (addressBook == null)
            {
                return NotFound();
            }

            return View(addressBook);
        }

        // POST: AddressBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            objaddressbookBO.Delete(id);
            //var addressBook = await _context.AddressBooks.FindAsync(id);
            //_context.AddressBooks.Remove(addressBook);
            //await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AddressBookExists(int id)
        {
            return _context.AddressBooks.Any(e => e.PkaddressId == id);
        }
    }
}
