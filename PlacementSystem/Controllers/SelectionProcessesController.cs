using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PlacementSystem.Data;
using PlacementSystem.Models;

namespace PlacementSystem.Controllers
{
    public class SelectionProcessesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SelectionProcessesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SelectionProcesses
        public async Task<IActionResult> Index()
        {
            return View(await _context.SelectionProcess.ToListAsync());
        }

        // GET: SelectionProcesses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var selectionProcess = await _context.SelectionProcess
                .FirstOrDefaultAsync(m => m.Id == id);
            if (selectionProcess == null)
            {
                return NotFound();
            }

            return View(selectionProcess);
        }

        // GET: SelectionProcesses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SelectionProcesses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProcessName")] SelectionProcess selectionProcess)
        {
            if (ModelState.IsValid)
            {
                _context.Add(selectionProcess);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(selectionProcess);
        }

        // GET: SelectionProcesses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var selectionProcess = await _context.SelectionProcess.FindAsync(id);
            if (selectionProcess == null)
            {
                return NotFound();
            }
            return View(selectionProcess);
        }

        // POST: SelectionProcesses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProcessName")] SelectionProcess selectionProcess)
        {
            if (id != selectionProcess.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(selectionProcess);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SelectionProcessExists(selectionProcess.Id))
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
            return View(selectionProcess);
        }

        // GET: SelectionProcesses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var selectionProcess = await _context.SelectionProcess
                .FirstOrDefaultAsync(m => m.Id == id);
            if (selectionProcess == null)
            {
                return NotFound();
            }

            return View(selectionProcess);
        }

        // POST: SelectionProcesses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var selectionProcess = await _context.SelectionProcess.FindAsync(id);
            if (selectionProcess != null)
            {
                _context.SelectionProcess.Remove(selectionProcess);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SelectionProcessExists(int id)
        {
            return _context.SelectionProcess.Any(e => e.Id == id);
        }
    }
}
