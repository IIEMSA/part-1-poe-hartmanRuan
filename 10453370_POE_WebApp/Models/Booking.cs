using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _10453370_POE_WebApp.Models
{
    public class Booking
    {
        [Key]
        public int Booking_ID { get; set; }
       
        public int Event_ID { get; set; }
        //public Event? Event { get; set; } 
        public int Venue_ID { get; set; }
        //public Venue? Venue { get; set; }
        public DateOnly Booking_Date { get; set; }

        [ForeignKey("Venue_ID")]
        public Venue? Venue { get; set; }
        [ForeignKey("Event_ID")]
        public Event? Event { get; set; }
    }
}
