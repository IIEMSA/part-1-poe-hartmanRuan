using Microsoft.EntityFrameworkCore;

namespace _10453370_POE_WebApp.Models
{
    public class EventEaseDBContext : DbContext
    {
        public EventEaseDBContext(DbContextOptions<EventEaseDBContext> options) : base(options)
        {

        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Venue> Venues { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }
}
