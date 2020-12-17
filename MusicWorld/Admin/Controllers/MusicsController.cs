using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Admin.Models;

namespace Admin.Controllers
{
    public class MusicsController : Controller
    {
        private readonly StoreDBContext _context;

        public MusicsController(StoreDBContext context)
        {
            _context = context;
        }

        // GET: Musics
        public async Task<IActionResult> Index()
        {
            var storeDBContext = _context.Musics.Include(m => m.Albums).Include(m => m.Authors).Include(m => m.Singers);
            return View(await storeDBContext.ToListAsync());
        }

        // GET: Musics/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var musics = await _context.Musics
                .Include(m => m.Albums)
                .Include(m => m.Authors)
                .Include(m => m.Singers)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (musics == null)
            {
                return NotFound();
            }

            return View(musics);
        }

        // GET: Musics/Create
        public IActionResult Create()
        {
            ViewData["AlbumId"] = new SelectList(_context.Albums, "Id", "AlbumName");
            ViewData["AuthorId"] = new SelectList(_context.Authors, "Id", "AuthorName");
            ViewData["SingerId"] = new SelectList(_context.Singers, "Id", "DescriptionSinger");
            return View();
        }

        // POST: Musics/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Url,AuthorId,SingerId,AlbumId,ReleaseDate")] Musics musics)
        {
            if (ModelState.IsValid)
            {
                _context.Add(musics);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AlbumId"] = new SelectList(_context.Albums, "Id", "AlbumName", musics.AlbumId);
            ViewData["AuthorId"] = new SelectList(_context.Authors, "Id", "AuthorName", musics.AuthorId);
            ViewData["SingerId"] = new SelectList(_context.Singers, "Id", "DescriptionSinger", musics.SingerId);
            return View(musics);
        }

        // GET: Musics/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var musics = await _context.Musics.FindAsync(id);
            if (musics == null)
            {
                return NotFound();
            }
            ViewData["AlbumId"] = new SelectList(_context.Albums, "Id", "AlbumName", musics.AlbumId);
            ViewData["AuthorId"] = new SelectList(_context.Authors, "Id", "AuthorName", musics.AuthorId);
            ViewData["SingerId"] = new SelectList(_context.Singers, "Id", "DescriptionSinger", musics.SingerId);
            return View(musics);
        }

        // POST: Musics/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Url,AuthorId,SingerId,AlbumId,ReleaseDate")] Musics musics)
        {
            if (id != musics.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(musics);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MusicsExists(musics.Id))
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
            ViewData["AlbumId"] = new SelectList(_context.Albums, "Id", "AlbumName", musics.AlbumId);
            ViewData["AuthorId"] = new SelectList(_context.Authors, "Id", "AuthorName", musics.AuthorId);
            ViewData["SingerId"] = new SelectList(_context.Singers, "Id", "DescriptionSinger", musics.SingerId);
            return View(musics);
        }

        // GET: Musics/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var musics = await _context.Musics
                .Include(m => m.Albums)
                .Include(m => m.Authors)
                .Include(m => m.Singers)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (musics == null)
            {
                return NotFound();
            }

            return View(musics);
        }

        // POST: Musics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var musics = await _context.Musics.FindAsync(id);
            _context.Musics.Remove(musics);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MusicsExists(int id)
        {
            return _context.Musics.Any(e => e.Id == id);
        }
    }
}
