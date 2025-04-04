namespace _10453370_POE_WebApp.Models
{
    public class Venue
    {
        public int venueID { get; set; }
        public string venueName { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public string ImageURL { get; set; }

        public List<Booking> Bookings { get; set; } = new();

    }
}
