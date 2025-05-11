using _10453370_POE_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _10453370_POE_WebApp.Controllers
{
    public class EventController : Controller
    {
        private readonly EventEaseDBContext _context;

        public EventController(EventEaseDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var events = await _context.Event.ToListAsync();

            return View(events);
        }

        [HttpGet]
        public IActionResult  Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Event events)
        {
            if (ModelState.IsValid)
            {
                _context.Add(events);
                await _context.SaveChangesAsync();
                TempData["SuccessC Message"] = "Event created successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(events);
        }

        public async Task<IActionResult> Details(int? id)
        {
            var events = await _context.Event.FirstOrDefaultAsync(m => m.Event_ID == id);
            if (events == null)
            {
                return NotFound();
            }
            return View(events);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            var events = await _context.Event.FirstOrDefaultAsync(m => m.Event_ID == id);

            if (events == null)
            {
                return NotFound();
            }
            return View(events);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var events = await _context.Event.FindAsync(id);
            if (events == null) return NotFound();

            var isBooked = await _context.Booking.AnyAsync(b => b.Event_ID == id);
            if (isBooked)
            {
                TempData["Error Message"] = "Cannot delete event because it already exists in bookings.";
                return RedirectToAction(nameof(Index));
            }

            _context.Event.Remove(events);
            await _context.SaveChangesAsync();
            TempData["Success Message"] = "Event deleted successfully";
            return RedirectToAction(nameof(Index));
        }


        private bool EventExists(int id)
        {
            return _context.Event.Any(e => e.Event_ID == id);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var events = await _context.Event.FindAsync(id);
            if (id == null)
            {
                return NotFound();
            }
            return View(events);
            

        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Event events)
        {
            if (id != events.Event_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(events);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventExists(events.Event_ID))
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
            return View(events);
        }
    }
}
