using _10453370_POE_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _10453370_POE_WebApp.Controllers
{
    public class VenueController : Controller
    {
        private readonly EventEaseDBContext _context;

        public VenueController(EventEaseDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var venues = await _context.Venues.ToListAsync();
            return View(venues);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Venue venue)
        {
            if (ModelState.IsValid)
            {
                _context.Add(venue);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(venue);
        }

        public async Task<IActionResult> Details(int? id)
        {
            var venues = await _context.Events.FirstOrDefaultAsync(m => m.venueID == id);
            if (venues == null)
            {
                return NotFound();
            }
            return View(venues);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            var venues = await _context.Events.FirstOrDefaultAsync(m => m.eventID == id);

            if (venues == null)
            {
                return NotFound();
            }
            return View(venues);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var venues = await _context.Venues.FindAsync(id);
            _context.Venues.Remove(venues);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool EventExists(int id)
        {
            return _context.Venues.Any(e => e.venueID == id);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var venues = await _context.Venues.FindAsync(id);
            if (id == null)
            {
                return NotFound();
            }
            return View(venues);


        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Venue venues)
        {
            if (id != venues.venueID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(venues);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventExists(venues.venueID))
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
            return View(venues);
        }
        }
}
