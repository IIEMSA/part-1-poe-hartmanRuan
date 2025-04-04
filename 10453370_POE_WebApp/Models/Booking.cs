namespace _10453370_POE_WebApp.Models
{
    public class Booking
    {

        public int BookingID { get; set; }
        public int eventID { get; set; }
        public Event? Event { get; set; }
        public int venueID { get; set; }
        public Venue? Venue { get; set; }
        public DateTime bookingDate { get; set; }
        
    }
}
