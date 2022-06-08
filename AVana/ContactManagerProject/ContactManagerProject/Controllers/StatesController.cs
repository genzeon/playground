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
    public class StatesController : Controller
    {
        //private readonly Data _context;

        //public StatesController(Data context)
        //{
        //    _context = context;
        //}

        StateBO objstatesBO;
        CountriesBO objcountriesBO;

        public StatesController(Data context)
        {
            objstatesBO = new StateBO(context);
            objcountriesBO = new CountriesBO(context);

        }
        // GET: States
        //public async Task<IActionResult> Index()
        //{
        //    ViewData["FkcountryId"] = new SelectList(objcountriesBO.GetAll(), "CountryName", "CountryName");

        //    //var data = _context.States.Include(s => s.Fkcountry);
        //    //  return View(await data.ToListAsync());
        //    return View(objstatesBO.GetAll());
        //}

        public async Task<IActionResult> Index(string? ant, string? sech, string? resh)
        {

            ViewData["FkcountryId"] = new SelectList(objcountriesBO.GetAll(), "CountryName", "CountryName");
            if (sech == "search" && resh == null)
            {
                return View(objstatesBO.sort(ant));

            }
            else if (resh == "reset")
            {
                return View(objstatesBO.GetAll());

            }

            //var data = _context.States.Include(s => s.Fkcountry);
            //return View(await data.ToListAsync());
            return View(objstatesBO.GetAll());
        }
        // GET: States/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var state = objstatesBO.GetById(id.Value);
            //var state = await _context.States
            //.Include(s => s.Fkcountry)
            //.FirstOrDefaultAsync(m => m.PkstateId == id);
            if (state == null)
            {
                return NotFound();
            }

            return View(state);
        }

        // GET: States/Create
        public IActionResult Create()
        {
            ViewData["FkcountryId"] = new SelectList(objcountriesBO.GetAll(), "PkcountryId", "CountryName");
            return View();
        }

        // POST: States/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PkstateId,FkcountryId,StateName,IsActive")] State state)
        {
            if (ModelState.IsValid)
            {
                objstatesBO.Add(state);
                //_context.Add(state);
                //await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FkcountryId"] = new SelectList(objstatesBO.GetAll(), "PkcountryId", "CountryName", state.FkcountryId);
            return View(state);
        }

        // GET: States/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var state = objstatesBO.GetById(id.Value);
            //var state = await _context.States.FindAsync(id);
            if (state == null)
            {
                return NotFound();
            }
            ViewData["FkcountryId"] = new SelectList(objstatesBO.GetAll(), "PkcountryId", "CountryName", state.FkcountryId);
            return View(state);
        }

        // POST: States/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PkstateId,FkcountryId,StateName,IsActive")] State state)
        {
            if (id != state.PkstateId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                objstatesBO.Update(state);
                //try
                //{
                //    _context.Update(state);
                //    await _context.SaveChangesAsync();
                //}
                //catch (DbUpdateConcurrencyException)
                //{
                //    if (!StateExists(state.PkstateId))
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
            ViewData["FkcountryId"] = new SelectList(objcountriesBO.GetAll(), "PkcountryId", "CountryNmae", state.FkcountryId);
            return View(state);
        }

        // GET: States/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var state = objstatesBO.GetById(id.Value);
            //var state = await _context.States
            //    .Include(s => s.Fkcountry)
            //    .FirstOrDefaultAsync(m => m.PkstateId == id);
            if (state == null)
            {
                return NotFound();
            }

            return View(state);
        }

        // POST: States/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            objstatesBO.Delete(id);
            //var state = await _context.States.FindAsync(id);
            //_context.States.Remove(state);
            //await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //private bool StateExists(int id)
        //{
        //    return _context.States.Any(e => e.PkstateId == id);
        //}
    }
}
