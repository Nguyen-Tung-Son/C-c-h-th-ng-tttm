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
    public class HSXController : Controller
    {
        private readonly Demo3Context _context;

        public HSXController(Demo3Context context)
        {
            _context = context;
        }

        // GET: HSX
        public async Task<IActionResult> Index()
        {
            return View(await _context.HSX.ToListAsync());
        }

        // GET: HSX/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hSX = await _context.HSX
                .FirstOrDefaultAsync(m => m.HSXId == id);
            if (hSX == null)
            {
                return NotFound();
            }

            return View(hSX);
        }

        // GET: HSX/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HSX/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HSXId,HSXs")] HSX hSX)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hSX);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hSX);
        }

        // GET: HSX/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hSX = await _context.HSX.FindAsync(id);
            if (hSX == null)
            {
                return NotFound();
            }
            return View(hSX);
        }

        // POST: HSX/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("HSXId,HSXs")] HSX hSX)
        {
            if (id != hSX.HSXId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hSX);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HSXExists(hSX.HSXId))
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
            return View(hSX);
        }

        // GET: HSX/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hSX = await _context.HSX
                .FirstOrDefaultAsync(m => m.HSXId == id);
            if (hSX == null)
            {
                return NotFound();
            }

            return View(hSX);
        }

        // POST: HSX/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var hSX = await _context.HSX.FindAsync(id);
            _context.HSX.Remove(hSX);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HSXExists(string id)
        {
            return _context.HSX.Any(e => e.HSXId == id);
        }
    }
}
