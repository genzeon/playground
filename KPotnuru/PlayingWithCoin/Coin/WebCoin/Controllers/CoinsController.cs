using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebCoin.Models;

namespace WebCoin.Controllers
{
    public class CoinsController : Controller
    {
        private readonly DataContext _context;

        public CoinsController(DataContext context)
        {
            _context = context;
        }

        // GET: Coins
        public async Task<IActionResult> Index()
        {
              return _context.Coins != null ? 
                          View(await _context.Coins.ToListAsync()) :
                          Problem("Entity set 'DataContext.Coins'  is null.");
        }

        // GET: Coins/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null || _context.Coins == null)
        //    {
        //        return NotFound();
        //    }

        //    var coin = await _context.Coins
        //        .FirstOrDefaultAsync(m => m.No_Of_Toss == id);
        //    if (coin == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(coin);
        //}

        //// GET: Coins/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Coins/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("No_Of_Toss,Occurence")] Coin coin)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(coin);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(coin);
        //}

        //// GET: Coins/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null || _context.Coins == null)
        //    {
        //        return NotFound();
        //    }

        //    var coin = await _context.Coins.FindAsync(id);
        //    if (coin == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(coin);
        //}

        //// POST: Coins/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("No_Of_Toss,Occurence")] Coin coin)
        //{
        //    if (id != coin.No_Of_Toss)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(coin);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!CoinExists(coin.No_Of_Toss))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(coin);
        //}

        //// GET: Coins/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null || _context.Coins == null)
        //    {
        //        return NotFound();
        //    }

        //    var coin = await _context.Coins
        //        .FirstOrDefaultAsync(m => m.No_Of_Toss == id);
        //    if (coin == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(coin);
        //}

        //// POST: Coins/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    if (_context.Coins == null)
        //    {
        //        return Problem("Entity set 'DataContext.Coins'  is null.");
        //    }
        //    var coin = await _context.Coins.FindAsync(id);
        //    if (coin != null)
        //    {
        //        _context.Coins.Remove(coin);
        //    }
            
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool CoinExists(int id)
        //{
        //  return (_context.Coins?.Any(e => e.No_Of_Toss == id)).GetValueOrDefault();
        //}
    }
}
