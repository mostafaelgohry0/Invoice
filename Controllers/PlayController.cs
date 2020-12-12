using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcPlay.Data;
using MvcPlay.Models;
using MvcPlay.ViewModel;
namespace MvcPlay.Controllers
{
    public class PlayController : Controller
    {
        private readonly MvcPlayContext _context;

        public PlayController(MvcPlayContext context)
        {
            _context = context;
        }

        // GET: Play
        public async Task<IActionResult> Index()
        {
            return View(await _context.Play.ToListAsync());
        }

        // GET: Play/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var play = await _context.Play
                .FirstOrDefaultAsync(m => m.Id == id);
            if (play == null)
            {
                return NotFound();
            }

            return View(play);
        }

        // GET: Play/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Play/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,ReleaseDate,Genre,Price")] Play play)
        {
            if (ModelState.IsValid)
            {
                _context.Add(play);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(play);
        }

        // GET: Play/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var play = await _context.Play.FindAsync(id);
            if (play == null)
            {
                return NotFound();
            }
            return View(play);
        }

        // POST: Play/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,ReleaseDate,Genre,Price")] Play play)
        {
            if (id != play.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(play);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlayExists(play.Id))
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
            return View(play);
        }

        // GET: Play/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var play = await _context.Play
                .FirstOrDefaultAsync(m => m.Id == id);
            if (play == null)
            {
                return NotFound();
            }

            return View(play);
        }

        // POST: Play/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var play = await _context.Play.FindAsync(id);
            _context.Play.Remove(play);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlayExists(int id)
        {
            return _context.Play.Any(e => e.Id == id);
        }
    }
}
