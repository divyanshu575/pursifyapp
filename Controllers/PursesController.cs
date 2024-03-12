using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using pursifyapp.Data;
using pursifyapp.Models;

namespace pursifyapp.Controllers
{
    public class PursesController : Controller
    {
        private readonly pursifyappContext _context;

        public PursesController(pursifyappContext context)
        {
            _context = context;
        }

        // GET: Purses
        public async Task<IActionResult> Index(string purseType, string searchString)
        {
            if (_context.Purse == null)
            {
                return Problem("Entity set 'pursifyContext.Purse' is null.");
            }

            // Use LINQ to get list of genres.
            IQueryable<string> typeQuery = from m in _context.Purse
                                           orderby m.Type
                                           select m.Type;

            var purses = from m in _context.Purse
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                purses = purses.Where(s => s.Name!.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(purseType))
            {
                purses = purses.Where(x => x.Type == purseType);
            }

            var purseTypeVM = new PurseTypeViewModel
            {
                Types = new SelectList(await typeQuery.Distinct().ToListAsync()),
                Purses = await purses.ToListAsync()
            };

            return View(purseTypeVM);
        }
        // GET: Purses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purse = await _context.Purse
                .FirstOrDefaultAsync(m => m.Id == id);
            if (purse == null)
            {
                return NotFound();
            }

            return View(purse);
        }

        // GET: Purses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Purses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Type,Color,Material,Comp,Size,Price")] Purse purse)
        {
            if (ModelState.IsValid)
            {
                _context.Add(purse);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(purse);
        }

        // GET: Purses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purse = await _context.Purse.FindAsync(id);
            if (purse == null)
            {
                return NotFound();
            }
            return View(purse);
        }

        // POST: Purses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Type,Color,Material,Comp,Size,Price")] Purse purse)
        {
            if (id != purse.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(purse);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PurseExists(purse.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(purse);
        }

        // GET: Purses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purse = await _context.Purse
                .FirstOrDefaultAsync(m => m.Id == id);
            if (purse == null)
            {
                return NotFound();
            }

            return View(purse);
        }

        // POST: Purses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var purse = await _context.Purse.FindAsync(id);
            if (purse != null)
            {
                _context.Purse.Remove(purse);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PurseExists(int id)
        {
            return _context.Purse.Any(e => e.Id == id);
        }
    }
}
