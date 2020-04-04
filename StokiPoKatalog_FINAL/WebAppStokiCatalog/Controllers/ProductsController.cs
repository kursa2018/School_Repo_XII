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
    public class ProductsController : Controller
    {
        private readonly catalogDbContext _context;

        public ProductsController(catalogDbContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            var catalogDbContext = _context.Products.Include(p => p.ClientsNavigation).Include(p => p.DistributorsNavigation);
            return View(await catalogDbContext.ToListAsync());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.Products
                .Include(p => p.ClientsNavigation)
                .Include(p => p.DistributorsNavigation)
                .FirstOrDefaultAsync(m => m.Clients == id);
            if (products == null)
            {
                return NotFound();
            }

            return View(products);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            ViewData["Clients"] = new SelectList(_context.Clients, "Egn", "Egn");
            ViewData["Distributors"] = new SelectList(_context.Distributors, "DistrId", "Name");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Clients,Distributors,Number,Naimenovanie,Quantity,Price,Data")] Products products)
        {
            if (ModelState.IsValid)
            {
                _context.Add(products);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Clients"] = new SelectList(_context.Clients, "Egn", "Egn", products.Clients);
            ViewData["Distributors"] = new SelectList(_context.Distributors, "DistrId", "Name", products.Distributors);
            return View(products);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.Products.FindAsync(id);
            if (products == null)
            {
                return NotFound();
            }
            ViewData["Clients"] = new SelectList(_context.Clients, "Egn", "Egn", products.Clients);
            ViewData["Distributors"] = new SelectList(_context.Distributors, "DistrId", "Name", products.Distributors);
            return View(products);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Clients,Distributors,Number,Naimenovanie,Quantity,Price,Data")] Products products)
        {
            if (id != products.Clients)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(products);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductsExists(products.Clients))
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
            ViewData["Clients"] = new SelectList(_context.Clients, "Egn", "Egn", products.Clients);
            ViewData["Distributors"] = new SelectList(_context.Distributors, "DistrId", "Name", products.Distributors);
            return View(products);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.Products
                .Include(p => p.ClientsNavigation)
                .Include(p => p.DistributorsNavigation)
                .FirstOrDefaultAsync(m => m.Clients == id);
            if (products == null)
            {
                return NotFound();
            }

            return View(products);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var products = await _context.Products.FindAsync(id);
            _context.Products.Remove(products);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductsExists(string id)
        {
            return _context.Products.Any(e => e.Clients == id);
        }
    }
}
