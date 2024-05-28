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
    public class PracownikController : Controller
    {
        private readonly MvcPracownikContext _context;

        public PracownikController(MvcPracownikContext context)
        {
            _context = context;
        }

        // GET: Pracownik
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pracownik.ToListAsync());
        }

        // GET: Pracownik/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pracownik = await _context.Pracownik
                .FirstOrDefaultAsync(m => m.IDpracownika == id);
            if (pracownik == null)
            {
                return NotFound();
            }

            return View(pracownik);
        }

        // public void PopulatePracownicyDropDownList(object selectedPracownik = null)
        // {
        //     var wybraniPracownicy = from e in _context.Pracownik
        //                     orderby e.IDpracownika
        //                     select e;
        //     var res = wybraniPracownicy.AsNoTracking();
        //     ViewBag.EtatyID = new SelectList(res, "Id pracownika", "Nazwa", selectedPracownik); // nie działa jeszcze ???
        // }

        public void PopulatePracownicyDropDownList(object selectedPracownik = null)
        {
        var pracownikZNajwyzszymWynagrodzeniem = _context.Pracownik
        .OrderByDescending(e => e.Placa)
        .FirstOrDefault();

        var wybraniPracownicy = from e in _context.Pracownik
                            orderby e.IDpracownika
                            select e;

        var res = wybraniPracownicy.AsNoTracking().ToList();
        ViewBag.PracownikID = new SelectList(res, "IDpracownika", "Nazwa", selectedPracownik);

    // Optional: If you want to set the default selected value to the employee with the highest salary
        if (pracownikZNajwyzszymWynagrodzeniem != null)
        {
            ViewBag.PracownikZNajwyzszymWynagrodzeniem = pracownikZNajwyzszymWynagrodzeniem.IDpracownika;
        }
        }


        // GET: Pracownik/Create
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Result()
        {
            return View("PopulatePracownicyDropDownList");
        }

        // POST: Pracownik/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDpracownika,Imie,Nazwisko,Placa,DataZatrudnienia")] Pracownik pracownik)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pracownik);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            PopulatePracownicyDropDownList(pracownik.IDpracownika);  // nie wiem czy IDpracownika jest tu OK
            return View(pracownik);
        }

        // GET: Pracownik/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pracownik = await _context.Pracownik.FindAsync(id);
            if (pracownik == null)
            {
                return NotFound();
            }
            return View(pracownik);
        }

        // POST: Pracownik/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDpracownika,Imie,Nazwisko,Placa,DataZatrudnienia")] Pracownik pracownik)
        {
            if (id != pracownik.IDpracownika)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pracownik);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PracownikExists(pracownik.IDpracownika))
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
            return View(pracownik);
        }

        // GET: Pracownik/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pracownik = await _context.Pracownik
                .FirstOrDefaultAsync(m => m.IDpracownika == id);
            if (pracownik == null)
            {
                return NotFound();
            }

            return View(pracownik);
        }

        // POST: Pracownik/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pracownik = await _context.Pracownik.FindAsync(id);
            if (pracownik != null)
            {
                _context.Pracownik.Remove(pracownik);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PracownikExists(int id)
        {
            return _context.Pracownik.Any(e => e.IDpracownika == id);
        }
    }
}
