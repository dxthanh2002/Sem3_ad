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
    public class GendersModelsController : Controller
    {
        private readonly FashionContext _context;

        public GendersModelsController(FashionContext context)
        {
            _context = context;
        }

        // GET: GendersModels
        public async Task<IActionResult> Index()
        {
              return _context.GendersModel != null ? 
                          View(await _context.GendersModel.ToListAsync()) :
                          Problem("Entity set 'FashionContext.GendersModel'  is null.");
        }

        // GET: GendersModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.GendersModel == null)
            {
                return NotFound();
            }

            var gendersModel = await _context.GendersModel
                .FirstOrDefaultAsync(m => m.Genderid == id);
            if (gendersModel == null)
            {
                return NotFound();
            }

            return View(gendersModel);
        }

        // GET: GendersModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GendersModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Genderid,gender")] GendersModel gendersModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gendersModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gendersModel);
        }

        // GET: GendersModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.GendersModel == null)
            {
                return NotFound();
            }

            var gendersModel = await _context.GendersModel.FindAsync(id);
            if (gendersModel == null)
            {
                return NotFound();
            }
            return View(gendersModel);
        }

        // POST: GendersModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Genderid,gender")] GendersModel gendersModel)
        {
            if (id != gendersModel.Genderid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gendersModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GendersModelExists(gendersModel.Genderid))
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
            return View(gendersModel);
        }

        // GET: GendersModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.GendersModel == null)
            {
                return NotFound();
            }

            var gendersModel = await _context.GendersModel
                .FirstOrDefaultAsync(m => m.Genderid == id);
            if (gendersModel == null)
            {
                return NotFound();
            }

            return View(gendersModel);
        }

        // POST: GendersModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.GendersModel == null)
            {
                return Problem("Entity set 'FashionContext.GendersModel'  is null.");
            }
            var gendersModel = await _context.GendersModel.FindAsync(id);
            if (gendersModel != null)
            {
                _context.GendersModel.Remove(gendersModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GendersModelExists(int id)
        {
          return (_context.GendersModel?.Any(e => e.Genderid == id)).GetValueOrDefault();
        }
    }
}
