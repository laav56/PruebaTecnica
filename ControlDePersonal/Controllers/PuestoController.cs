using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ControlDePersonal.Data;
using ControlDePersonal.Models;
using Microsoft.AspNetCore.Authorization;

namespace ControlDePersonal.Controllers
{
    public class PuestoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PuestoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Puesto
        [Authorize]
        public async Task<IActionResult> Index()
        {
              return _context.Puesto != null ? 
                          View(await _context.Puesto.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Puesto'  is null.");
        }

        // GET: Puesto/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Puesto == null)
            {
                return NotFound();
            }

            var puesto = await _context.Puesto
                .FirstOrDefaultAsync(m => m.intIdPuesto == id);
            if (puesto == null)
            {
                return NotFound();
            }

            return View(puesto);
        }

        // GET: Puesto/Create
        [Authorize(Roles = "admin")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Puesto/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("intIdPuesto,strPruesto,intIdDepto")] Puesto puesto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(puesto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(puesto);
        }

        // GET: Puesto/Edit/5
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Puesto == null)
            {
                return NotFound();
            }

            var puesto = await _context.Puesto.FindAsync(id);
            if (puesto == null)
            {
                return NotFound();
            }
            return View(puesto);
        }

        // POST: Puesto/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("intIdPuesto,strPruesto,intIdDepto")] Puesto puesto)
        {
            if (id != puesto.intIdPuesto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(puesto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PuestoExists(puesto.intIdPuesto))
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
            return View(puesto);
        }

        // GET: Puesto/Delete/5
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Puesto == null)
            {
                return NotFound();
            }

            var puesto = await _context.Puesto
                .FirstOrDefaultAsync(m => m.intIdPuesto == id);
            if (puesto == null)
            {
                return NotFound();
            }

            return View(puesto);
        }

        // POST: Puesto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Puesto == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Puesto'  is null.");
            }
            var puesto = await _context.Puesto.FindAsync(id);
            if (puesto != null)
            {
                _context.Puesto.Remove(puesto);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PuestoExists(int id)
        {
          return (_context.Puesto?.Any(e => e.intIdPuesto == id)).GetValueOrDefault();
        }
    }
}
