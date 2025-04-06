using System.ComponentModel.DataAnnotations;

namespace _10453370_POE_WebApp.Models
{
    public class Venue
    {
        [Key]
        public int Venue_ID { get; set; }
        public string Venue_Name { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public string ImageURL { get; set; }

        public List<Booking> Booking { get; set; } = new();

        public List<Event> Event { get; set; } = new();

    }
}
