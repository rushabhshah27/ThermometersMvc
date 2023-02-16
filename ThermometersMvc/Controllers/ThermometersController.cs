using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ThermometersMvc.Data;
using ThermometersMvc.Models;

namespace ThermometersMvc.Controllers
{
    public class ThermometersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ThermometersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Thermometers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Thermometers.ToListAsync());
        }

        // GET: Thermometers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thermometers = await _context.Thermometers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (thermometers == null)
            {
                return NotFound();
            }

            return View(thermometers);
        }

        // GET: Thermometers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Thermometers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TypeOfThermometer,TemperatureRange,ProbeType,Accuracy,Price,Display")] Thermometers thermometers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(thermometers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(thermometers);
        }

        // GET: Thermometers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thermometers = await _context.Thermometers.FindAsync(id);
            if (thermometers == null)
            {
                return NotFound();
            }
            return View(thermometers);
        }

        // POST: Thermometers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TypeOfThermometer,TemperatureRange,ProbeType,Accuracy,Price,Display")] Thermometers thermometers)
        {
            if (id != thermometers.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(thermometers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ThermometersExists(thermometers.Id))
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
            return View(thermometers);
        }

        // GET: Thermometers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thermometers = await _context.Thermometers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (thermometers == null)
            {
                return NotFound();
            }

            return View(thermometers);
        }

        // POST: Thermometers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var thermometers = await _context.Thermometers.FindAsync(id);
            _context.Thermometers.Remove(thermometers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ThermometersExists(int id)
        {
            return _context.Thermometers.Any(e => e.Id == id);
        }
    }
}
