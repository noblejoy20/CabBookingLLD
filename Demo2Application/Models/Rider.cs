using System.Collections.Generic;

namespace Demo2Application.Models
{
    public class Rider
    {
        public int RiderId { get; set; }
        public string RiderName { get; set; }
        public Location Location { get; set; }
        public List<Trip> TripsTaken { get; set; }
    }
}