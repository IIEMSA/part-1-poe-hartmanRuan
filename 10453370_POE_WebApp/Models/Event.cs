using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _10453370_POE_WebApp.Models
{
    public class Event
    {
        [Key]
        public int Event_ID { get; set; }
        public string? Event_Name { get; set; }
        public DateOnly Event_Date { get; set; }
        public string? Description { get; set; }
        public int Venue_ID { get; set; }
        [ForeignKey("Venue_ID")]
        public Venue? Venue { get; set; }

        //public List<Booking> Booking { get; set; } = new();

        //public List<Venue> Venue { get; set; } = new();

        

    }
}
