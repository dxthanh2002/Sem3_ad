using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class seasonsModelsController : Controller
    {
        private readonly FashionContext _context;

        public seasonsModelsController(FashionContext context)
        {
            _context = context;
        }

        // GET: seasonsModels
        public async Task<IActionResult> Index()
        {
              return _context.seasonsModel != null ? 
                          View(await _context.seasonsModel.ToListAsync()) :
                          Problem("Entity set 'FashionContext.seasonsModel'  is null.");
        }

        // GET: seasonsModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.seasonsModel == null)
            {
                return NotFound();
            }

            var seasonsModel = await _context.seasonsModel
                .FirstOrDefaultAsync(m => m.seasonId == id);
            if (seasonsModel == null)
            {
                return NotFound();
            }

            return View(seasonsModel);
        }

        // GET: seasonsModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: seasonsModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("seasonId,Name")] seasonsModel seasonsModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(seasonsModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(seasonsModel);
        }

        // GET: seasonsModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.seasonsModel == null)
            {
                return NotFound();
            }

            var seasonsModel = await _context.seasonsModel.FindAsync(id);
            if (seasonsModel == null)
            {
                return NotFound();
            }
            return View(seasonsModel);
        }

        // POST: seasonsModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("seasonId,Name")] seasonsModel seasonsModel)
        {
            if (id != seasonsModel.seasonId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(seasonsModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!seasonsModelExists(seasonsModel.seasonId))
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
            return View(seasonsModel);
        }

        // GET: seasonsModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.seasonsModel == null)
            {
                return NotFound();
            }

            var seasonsModel = await _context.seasonsModel
                .FirstOrDefaultAsync(m => m.seasonId == id);
            if (seasonsModel == null)
            {
                return NotFound();
            }

            return View(seasonsModel);
        }

        // POST: seasonsModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.seasonsModel == null)
            {
                return Problem("Entity set 'FashionContext.seasonsModel'  is null.");
            }
            var seasonsModel = await _context.seasonsModel.FindAsync(id);
            if (seasonsModel != null)
            {
                _context.seasonsModel.Remove(seasonsModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool seasonsModelExists(int id)
        {
          return (_context.seasonsModel?.Any(e => e.seasonId == id)).GetValueOrDefault();
        }
    }
}
