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
    public class TinhNangController : Controller
    {
        private readonly Demo3Context _context;

        public TinhNangController(Demo3Context context)
        {
            _context = context;
        }

        // GET: TinhNang
        public async Task<IActionResult> Index()
        {
            return View(await _context.TinhNang.ToListAsync());
        }

        // GET: TinhNang/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tinhNang = await _context.TinhNang
                .FirstOrDefaultAsync(m => m.TNId == id);
            if (tinhNang == null)
            {
                return NotFound();
            }

            return View(tinhNang);
        }

        // GET: TinhNang/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TinhNang/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TNId,TN")] TinhNang tinhNang)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tinhNang);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tinhNang);
        }

        // GET: TinhNang/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tinhNang = await _context.TinhNang.FindAsync(id);
            if (tinhNang == null)
            {
                return NotFound();
            }
            return View(tinhNang);
        }

        // POST: TinhNang/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("TNId,TN")] TinhNang tinhNang)
        {
            if (id != tinhNang.TNId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tinhNang);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TinhNangExists(tinhNang.TNId))
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
            return View(tinhNang);
        }

        // GET: TinhNang/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tinhNang = await _context.TinhNang
                .FirstOrDefaultAsync(m => m.TNId == id);
            if (tinhNang == null)
            {
                return NotFound();
            }

            return View(tinhNang);
        }

        // POST: TinhNang/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var tinhNang = await _context.TinhNang.FindAsync(id);
            _context.TinhNang.Remove(tinhNang);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TinhNangExists(string id)
        {
            return _context.TinhNang.Any(e => e.TNId == id);
        }
    }
}
