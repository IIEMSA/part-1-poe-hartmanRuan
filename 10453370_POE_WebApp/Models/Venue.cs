using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace _10453370_POE_WebApp.Models
{
    public class Venue
    {
        [Key]
        public int Venue_ID { get; set; }
        public string? Venue_Name { get; set; }
        public string? Location { get; set; }

        
        [Range(1, int.MaxValue, ErrorMessage = "Capacity must be greater than 0.")]
        public int Capacity { get; set; }
        
        public string? ImageURL { get; set; }
        [NotMapped]
        public IFormFile? ImageFile { get; set; }

        //public List<Booking> Booking { get; set; } = new();

        //public List<Event> Event { get; set; } = new();

        


    }
}
