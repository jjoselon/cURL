using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCapplicacion.Models;

namespace MVCapplicacion.Controllers
{
    public class BinnaclesController : Controller
    {
        private readonly MVCapplicacionContext _context;

        public BinnaclesController(MVCapplicacionContext context)
        {
            _context = context;
        }

        // GET: Binnacles
        public async Task<IActionResult> Index()
        {
            return View(await _context.Binnacle.ToListAsync());
        }

        // GET: Binnacles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var binnacle = await _context.Binnacle
                .FirstOrDefaultAsync(m => m.Id == id);
            if (binnacle == null)
            {
                return NotFound();
            }

            return View(binnacle);
        }

        // GET: Binnacles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Binnacles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Body,PublishDate")] Binnacle binnacle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(binnacle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(binnacle);
        }

        // GET: Binnacles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var binnacle = await _context.Binnacle.FindAsync(id);
            if (binnacle == null)
            {
                return NotFound();
            }
            return View(binnacle);
        }

        // POST: Binnacles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Body,PublishDate")] Binnacle binnacle)
        {
            if (id != binnacle.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(binnacle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BinnacleExists(binnacle.Id))
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
            return View(binnacle);
        }

        // GET: Binnacles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var binnacle = await _context.Binnacle
                .FirstOrDefaultAsync(m => m.Id == id);
            if (binnacle == null)
            {
                return NotFound();
            }

            return View(binnacle);
        }

        // POST: Binnacles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var binnacle = await _context.Binnacle.FindAsync(id);
            _context.Binnacle.Remove(binnacle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BinnacleExists(int id)
        {
            return _context.Binnacle.Any(e => e.Id == id);
        }
    }
}
