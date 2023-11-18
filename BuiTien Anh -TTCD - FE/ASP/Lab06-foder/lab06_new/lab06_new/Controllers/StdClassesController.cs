using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using lab06_5.Models;
using lab06_5_new.Entities;

namespace lab06_new.Controllers
{
    public class StdClassesController : Controller
    {
        private readonly AppDbContext _context;

        public StdClassesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: StdClasses
        public async Task<IActionResult> Index()
        {
              return _context.stdClasses != null ? 
                          View(await _context.stdClasses.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.stdClasses'  is null.");
        }

        // GET: StdClasses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.stdClasses == null)
            {
                return NotFound();
            }

            var stdClass = await _context.stdClasses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stdClass == null)
            {
                return NotFound();
            }

            return View(stdClass);
        }

        // GET: StdClasses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StdClasses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ClassName")] StdClass stdClass)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stdClass);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stdClass);
        }

        // GET: StdClasses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.stdClasses == null)
            {
                return NotFound();
            }

            var stdClass = await _context.stdClasses.FindAsync(id);
            if (stdClass == null)
            {
                return NotFound();
            }
            return View(stdClass);
        }

        // POST: StdClasses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ClassName")] StdClass stdClass)
        {
            if (id != stdClass.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stdClass);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StdClassExists(stdClass.Id))
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
            return View(stdClass);
        }

        // GET: StdClasses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.stdClasses == null)
            {
                return NotFound();
            }

            var stdClass = await _context.stdClasses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stdClass == null)
            {
                return NotFound();
            }

            return View(stdClass);
        }

        // POST: StdClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.stdClasses == null)
            {
                return Problem("Entity set 'AppDbContext.stdClasses'  is null.");
            }
            var stdClass = await _context.stdClasses.FindAsync(id);
            if (stdClass != null)
            {
                _context.stdClasses.Remove(stdClass);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StdClassExists(int id)
        {
          return (_context.stdClasses?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
