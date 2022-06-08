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
    public class CountriesController : Controller
    {
        //private readonly Data _context;

        // public CountriesController(Data context)
        //{
        //    _context = context;
        //}
        CountriesBO objcountriesBO;

        public CountriesController(Data context)
        {

            objcountriesBO = new CountriesBO(context);

        }

        // GET: Countries
        // public async Task<IActionResult> Index()
        public ActionResult Index()
        {
            //return View(await _context.Countries.ToListAsync());
            return View(objcountriesBO.GetAll());
        }

        // GET: Countries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var country = objcountriesBO.GetById(id.Value);
            //var country = await _context.Countries
            // .FirstOrDefaultAsync(m => m.PkcountryId == id);
            if (country == null)
            {
                return NotFound();
            }

            return View(country);
        }

        // GET: Countries/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Countries/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>
            Create([Bind("PkcountryId,CountryName,ZipCodeStart,ZipCodeEnd,IsActive")] Country country)
        {
            if (ModelState.IsValid)
            {
                objcountriesBO.Add(country);
                //_context.Add(country);
                //await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(country);
        }

        // GET: Countries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var country = objcountriesBO.GetById(id.Value);
            //var country = await _context.Countries.FindAsync(id);
            if (country == null)
            {
                return NotFound();
            }
            return View(country);
        }

        // POST: Countries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>
            Edit(int id, [Bind("PkcountryId,CountryName,ZipCodeStart,ZipCodeEnd,IsActive")] Country country)
        {
            if (id != country.PkcountryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                objcountriesBO.Update(country);
                return RedirectToAction(nameof(Index));
            }
            return View(country);
        }

        // GET: Countries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var country = objcountriesBO.GetById(id.Value);
            //var country = await _context.Countries
            // .FirstOrDefaultAsync(m => m.PkcountryId == id);
            if (country == null)
            {
                return NotFound();
            }

            return View(country);
        }

        // POST: Countries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            objcountriesBO.Delete(id);
            //var country = await _context.Countries.FindAsync(id);
            //_context.Countries.Remove(country);
            //await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //private bool CountryExists(int id)
        //{
        //    return _context.Countries.Any(e => e.PkcountryId == id);
        //}
    }
}
