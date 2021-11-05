using System.Collections.Generic;

namespace Demo2Application.Models
{
    public class Rider
    {
        private static int Identity = 1;

        public Rider()
        {
        }

        public Rider(string riderName, List<int> coordinates, string locationName)
        {
            RiderName = riderName;
            RiderId = Identity++;
            Location = new Location(coordinates, locationName);
        }

        public int RiderId { get; set; }
        public string RiderName { get; set; }
        public Location Location { get; set; }
        public List<Trip> TripsTaken { get; set; }
    }
}