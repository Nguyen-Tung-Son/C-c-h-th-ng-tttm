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
    public class LKPCController : Controller
    {
        private readonly Demo3Context _context;

        public LKPCController(Demo3Context context)
        {
            _context = context;
        }

        // GET: LKPC
        public async Task<IActionResult> Index()
        {
            return View(await _context.LKPC.ToListAsync());
        }

        // GET: LKPC/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lKPC = await _context.LKPC
                .FirstOrDefaultAsync(m => m.LKPCId == id);
            if (lKPC == null)
            {
                return NotFound();
            }

            return View(lKPC);
        }

        // GET: LKPC/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LKPC/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LKPCId,LKPCName")] LKPC lKPC)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lKPC);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lKPC);
        }

        // GET: LKPC/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lKPC = await _context.LKPC.FindAsync(id);
            if (lKPC == null)
            {
                return NotFound();
            }
            return View(lKPC);
        }

        // POST: LKPC/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("LKPCId,LKPCName")] LKPC lKPC)
        {
            if (id != lKPC.LKPCId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lKPC);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LKPCExists(lKPC.LKPCId))
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
            return View(lKPC);
        }

        // GET: LKPC/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lKPC = await _context.LKPC
                .FirstOrDefaultAsync(m => m.LKPCId == id);
            if (lKPC == null)
            {
                return NotFound();
            }

            return View(lKPC);
        }

        // POST: LKPC/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var lKPC = await _context.LKPC.FindAsync(id);
            _context.LKPC.Remove(lKPC);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LKPCExists(string id)
        {
            return _context.LKPC.Any(e => e.LKPCId == id);
        }
    }
}
