using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcPracownik.Data;
using MvcStrona.Models;

namespace MvcPracownicy.Controllers
{
    public class GrupaController : Controller
    {
        private readonly MvcPracownikContext _context;

        public GrupaController(MvcPracownikContext context)
        {
            _context = context;
        }

        // GET: Grupa
        public async Task<IActionResult> Index()
        {
            return View(await _context.Grupa.ToListAsync());
        }

        // GET: Grupa/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grupa = await _context.Grupa
                .FirstOrDefaultAsync(m => m.IDgrupy == id);
            if (grupa == null)
            {
                return NotFound();
            }

            return View(grupa);
        }

        // GET: Grupa/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Grupa/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDgrupy,Nazwa,Jezyk,LiczbaUczestnikow,DataRozpoczecia")] Grupa grupa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(grupa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(grupa);
        }

        // GET: Grupa/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grupa = await _context.Grupa.FindAsync(id);
            if (grupa == null)
            {
                return NotFound();
            }
            return View(grupa);
        }

        // POST: Grupa/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDgrupy,Nazwa,Jezyk,LiczbaUczestnikow,DataRozpoczecia")] Grupa grupa)
        {
            if (id != grupa.IDgrupy)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(grupa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GrupaExists(grupa.IDgrupy))
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
            return View(grupa);
        }

        // GET: Grupa/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grupa = await _context.Grupa
                .FirstOrDefaultAsync(m => m.IDgrupy == id);
            if (grupa == null)
            {
                return NotFound();
            }

            return View(grupa);
        }

        // POST: Grupa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var grupa = await _context.Grupa.FindAsync(id);
            if (grupa != null)
            {
                _context.Grupa.Remove(grupa);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GrupaExists(int id)
        {
            return _context.Grupa.Any(e => e.IDgrupy == id);
        }
    }
}
