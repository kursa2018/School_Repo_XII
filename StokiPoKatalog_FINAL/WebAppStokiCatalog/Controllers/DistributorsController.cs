using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppStokiCatalog.Models;

namespace WebAppStokiCatalog.Controllers
{
    public class DistributorsController : Controller
    {
        private readonly catalogDbContext _context;

        public DistributorsController(catalogDbContext context)
        {
            _context = context;
        }

        // GET: Distributors
        public async Task<IActionResult> Index()
        {
            return View(await _context.Distributors.ToListAsync());
        }

        // GET: Distributors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var distributors = await _context.Distributors
                .FirstOrDefaultAsync(m => m.DistrId == id);
            if (distributors == null)
            {
                return NotFound();
            }

            return View(distributors);
        }

        // GET: Distributors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Distributors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DistrId,Name,TelContact")] Distributors distributors)
        {
            if (ModelState.IsValid)
            {
                _context.Add(distributors);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(distributors);
        }

        // GET: Distributors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var distributors = await _context.Distributors.FindAsync(id);
            if (distributors == null)
            {
                return NotFound();
            }
            return View(distributors);
        }

        // POST: Distributors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DistrId,Name,TelContact")] Distributors distributors)
        {
            if (id != distributors.DistrId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(distributors);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DistributorsExists(distributors.DistrId))
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
            return View(distributors);
        }

        // GET: Distributors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var distributors = await _context.Distributors
                .FirstOrDefaultAsync(m => m.DistrId == id);
            if (distributors == null)
            {
                return NotFound();
            }

            return View(distributors);
        }

        // POST: Distributors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var distributors = await _context.Distributors.FindAsync(id);
            _context.Distributors.Remove(distributors);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DistributorsExists(int id)
        {
            return _context.Distributors.Any(e => e.DistrId == id);
        }
    }
}
