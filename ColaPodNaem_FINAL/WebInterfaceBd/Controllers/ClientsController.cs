using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebInterfaceBd.Models;

namespace WebInterfaceBd.Controllers
{
    public class ClientsController : Controller
    {
        private readonly avtoBdContext _context;

        public ClientsController(avtoBdContext context)
        {
            _context = context;
        }

        // GET: Clients
        public async Task<IActionResult> Index()
        {
            var avtoBdContext = _context.Clients.Include(c => c.KolaNavigation);
            return View(await avtoBdContext.ToListAsync());
        }

        // GET: Clients/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clients = await _context.Clients
                .Include(c => c.KolaNavigation)
                .FirstOrDefaultAsync(m => m.Kola == id);
            if (clients == null)
            {
                return NotFound();
            }

            return View(clients);
        }

        // GET: Clients/Create
        public IActionResult Create()
        {
            ViewData["Kola"] = new SelectList(_context.Cars, "Id", "Id");
            return View();
        }

        // POST: Clients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Kola,Name,Family,LichnaKarta,Adress,CreditCard,Data")] Clients clients)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clients);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Kola"] = new SelectList(_context.Cars, "Id", "Id", clients.Kola);
            return View(clients);
        }

        // GET: Clients/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clients = await _context.Clients.FindAsync(id);
            if (clients == null)
            {
                return NotFound();
            }
            ViewData["Kola"] = new SelectList(_context.Cars, "Id", "Id", clients.Kola);
            return View(clients);
        }

        // POST: Clients/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Kola,Name,Family,LichnaKarta,Adress,CreditCard,Data")] Clients clients)
        {
            if (id != clients.Kola)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clients);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientsExists(clients.Kola))
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
            ViewData["Kola"] = new SelectList(_context.Cars, "Id", "Id", clients.Kola);
            return View(clients);
        }

        // GET: Clients/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clients = await _context.Clients
                .Include(c => c.KolaNavigation)
                .FirstOrDefaultAsync(m => m.Kola == id);
            if (clients == null)
            {
                return NotFound();
            }

            return View(clients);
        }

        // POST: Clients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var clients = await _context.Clients.FindAsync(id);
            _context.Clients.Remove(clients);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClientsExists(string id)
        {
            return _context.Clients.Any(e => e.Kola == id);
        }
    }
}
