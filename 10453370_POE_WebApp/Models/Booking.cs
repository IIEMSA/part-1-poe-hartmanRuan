using System.ComponentModel.DataAnnotations;

namespace _10453370_POE_WebApp.Models
{
    public class Booking
    {
        [Key]
        public int Booking_ID { get; set; }
        public int Event_ID { get; set; }
       // public Event? Event { get; set; }
        public int Venue_ID { get; set; }
        //public Venue? Venue { get; set; }
        public DateOnly Booking_Date { get; set; }


        public List<Event> Event { get; set; } = new();

        public List<Venue> Venue { get; set; } = new();

        
    }
}
