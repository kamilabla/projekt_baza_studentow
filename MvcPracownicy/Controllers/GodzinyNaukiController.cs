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
    public class GodzinyNaukiController : Controller
    {
        private readonly MvcPracownikContext _context;

        public GodzinyNaukiController(MvcPracownikContext context)
        {
            _context = context;
        }

        // GET: GodzinyNauki
        public async Task<IActionResult> Index()
        {
            return View(await _context.GodzinyNauki.ToListAsync());
        }

        // GET: GodzinyNauki/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var godzinyNauki = await _context.GodzinyNauki
                .FirstOrDefaultAsync(m => m.ID == id);
            if (godzinyNauki == null)
            {
                return NotFound();
            }

            return View(godzinyNauki);
        }

        // GET: GodzinyNauki/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GodzinyNauki/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,IDucznia,Jezyk,Godziny")] GodzinyNauki godzinyNauki)
        {
            if (ModelState.IsValid)
            {
                _context.Add(godzinyNauki);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(godzinyNauki);
        }

        // GET: GodzinyNauki/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var godzinyNauki = await _context.GodzinyNauki.FindAsync(id);
            if (godzinyNauki == null)
            {
                return NotFound();
            }
            return View(godzinyNauki);
        }

        // POST: GodzinyNauki/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,IDucznia,Jezyk,Godziny")] GodzinyNauki godzinyNauki)
        {
            if (id != godzinyNauki.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(godzinyNauki);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GodzinyNaukiExists(godzinyNauki.ID))
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
            return View(godzinyNauki);
        }

        // GET: GodzinyNauki/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var godzinyNauki = await _context.GodzinyNauki
                .FirstOrDefaultAsync(m => m.ID == id);
            if (godzinyNauki == null)
            {
                return NotFound();
            }

            return View(godzinyNauki);
        }

        // POST: GodzinyNauki/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var godzinyNauki = await _context.GodzinyNauki.FindAsync(id);
            if (godzinyNauki != null)
            {
                _context.GodzinyNauki.Remove(godzinyNauki);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GodzinyNaukiExists(int id)
        {
            return _context.GodzinyNauki.Any(e => e.ID == id);
        }
    }
}
