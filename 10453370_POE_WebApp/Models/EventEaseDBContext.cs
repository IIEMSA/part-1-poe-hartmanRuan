using Microsoft.EntityFrameworkCore;

namespace _10453370_POE_WebApp.Models
{
    public class EventEaseDBContext : DbContext
    {
        public EventEaseDBContext(DbContextOptions<EventEaseDBContext> options) : base(options)
        {

        }

        public DbSet<Event> Event { get; set; }
        public DbSet<Venue> Venue { get; set; }
        public DbSet<Booking> Booking { get; set; }
    }
}
