namespace _10453370_POE_WebApp.Models
{
    public class Event
    {
        public int eventID { get; set; }
        public string eventName { get; set; }
        public DateTime eventDate { get; set; }
        public string Description { get; set; }
        public int venueID { get; set; }

        public List<Booking> Bookings { get; set; } = new();
    }
}
