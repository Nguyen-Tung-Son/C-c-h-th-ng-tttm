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
    public class LinhKienPCController : Controller
    {
        private readonly Demo3Context _context;

        public LinhKienPCController(Demo3Context context)
        {
            _context = context;
        }

        // GET: LinhKienPC
        public async Task<IActionResult> Index()
        {
            return View(await _context.LinhKienPC.ToListAsync());
        }

        // GET: LinhKienPC/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var linhKienPC = await _context.LinhKienPC
                .FirstOrDefaultAsync(m => m.LinhKienPCId == id);
            if (linhKienPC == null)
            {
                return NotFound();
            }

            return View(linhKienPC);
        }

        // GET: LinhKienPC/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LinhKienPC/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LinhKienPCId,LinhKienPCName,Price,HSXs,type")] LinhKienPC linhKienPC)
        {
            if (ModelState.IsValid)
            {
                _context.Add(linhKienPC);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(linhKienPC);
        }

        // GET: LinhKienPC/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var linhKienPC = await _context.LinhKienPC.FindAsync(id);
            if (linhKienPC == null)
            {
                return NotFound();
            }
            return View(linhKienPC);
        }

        // POST: LinhKienPC/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("LinhKienPCId,LinhKienPCName,Price,HSXs,type")] LinhKienPC linhKienPC)
        {
            if (id != linhKienPC.LinhKienPCId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(linhKienPC);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LinhKienPCExists(linhKienPC.LinhKienPCId))
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
            return View(linhKienPC);
        }

        // GET: LinhKienPC/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var linhKienPC = await _context.LinhKienPC
                .FirstOrDefaultAsync(m => m.LinhKienPCId == id);
            if (linhKienPC == null)
            {
                return NotFound();
            }

            return View(linhKienPC);
        }

        // POST: LinhKienPC/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var linhKienPC = await _context.LinhKienPC.FindAsync(id);
            _context.LinhKienPC.Remove(linhKienPC);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LinhKienPCExists(string id)
        {
            return _context.LinhKienPC.Any(e => e.LinhKienPCId == id);
        }
    }
}
