using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TS;

namespace TS.Controllers
{
    public class GiaTienController : Controller
    {
        private readonly Demo3Context _context;

        public GiaTienController(Demo3Context context)
        {
            _context = context;
        }

        // GET: GiaTien
        public async Task<IActionResult> Index()
        {
            return View(await _context.GiaTien.ToListAsync());
        }

        // GET: GiaTien/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var giaTien = await _context.GiaTien
                .FirstOrDefaultAsync(m => m.GiaTienId == id);
            if (giaTien == null)
            {
                return NotFound();
            }

            return View(giaTien);
        }

        // GET: GiaTien/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GiaTien/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GiaTienId,GiaTiens")] GiaTien giaTien)
        {
            if (ModelState.IsValid)
            {
                _context.Add(giaTien);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(giaTien);
        }

        // GET: GiaTien/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var giaTien = await _context.GiaTien.FindAsync(id);
            if (giaTien == null)
            {
                return NotFound();
            }
            return View(giaTien);
        }

        // POST: GiaTien/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("GiaTienId,GiaTiens")] GiaTien giaTien)
        {
            if (id != giaTien.GiaTienId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(giaTien);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GiaTienExists(giaTien.GiaTienId))
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
            return View(giaTien);
        }

        // GET: GiaTien/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var giaTien = await _context.GiaTien
                .FirstOrDefaultAsync(m => m.GiaTienId == id);
            if (giaTien == null)
            {
                return NotFound();
            }

            return View(giaTien);
        }

        // POST: GiaTien/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var giaTien = await _context.GiaTien.FindAsync(id);
            _context.GiaTien.Remove(giaTien);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GiaTienExists(string id)
        {
            return _context.GiaTien.Any(e => e.GiaTienId == id);
        }
    }
}
