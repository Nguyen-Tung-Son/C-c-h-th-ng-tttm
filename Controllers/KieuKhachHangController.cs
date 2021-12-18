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
    public class KieuKhachHangController : Controller
    {
        private readonly Demo3Context _context;

        public KieuKhachHangController(Demo3Context context)
        {
            _context = context;
        }

        // GET: KieuKhachHang
        public async Task<IActionResult> Index()
        {
            return View(await _context.KieuKhachHang.ToListAsync());
        }

        // GET: KieuKhachHang/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kieuKhachHang = await _context.KieuKhachHang
                .FirstOrDefaultAsync(m => m.KKHId == id);
            if (kieuKhachHang == null)
            {
                return NotFound();
            }

            return View(kieuKhachHang);
        }

        // GET: KieuKhachHang/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: KieuKhachHang/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("KKHId,KKH")] KieuKhachHang kieuKhachHang)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kieuKhachHang);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kieuKhachHang);
        }

        // GET: KieuKhachHang/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kieuKhachHang = await _context.KieuKhachHang.FindAsync(id);
            if (kieuKhachHang == null)
            {
                return NotFound();
            }
            return View(kieuKhachHang);
        }

        // POST: KieuKhachHang/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("KKHId,KKH")] KieuKhachHang kieuKhachHang)
        {
            if (id != kieuKhachHang.KKHId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kieuKhachHang);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KieuKhachHangExists(kieuKhachHang.KKHId))
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
            return View(kieuKhachHang);
        }

        // GET: KieuKhachHang/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kieuKhachHang = await _context.KieuKhachHang
                .FirstOrDefaultAsync(m => m.KKHId == id);
            if (kieuKhachHang == null)
            {
                return NotFound();
            }

            return View(kieuKhachHang);
        }

        // POST: KieuKhachHang/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var kieuKhachHang = await _context.KieuKhachHang.FindAsync(id);
            _context.KieuKhachHang.Remove(kieuKhachHang);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KieuKhachHangExists(string id)
        {
            return _context.KieuKhachHang.Any(e => e.KKHId == id);
        }
    }
}
