using System.Collections.Generic;

namespace Demo2Application.Models
{
    public class Cab
    {
        private static int Identity = 1;

        public Cab()
        {
        }

        public Cab(string driverName, List<int> coordinates, string locationName)
        {
            CabId = Identity++;
            DriverName = driverName;
            Location = new Location(coordinates, locationName);
            CalculatedDistanceToRider = 0;
        }

        public int CabId { get; set; }
        public string DriverName { get; set; }
        public Location Location { get; set; }
        public bool IsAvailable { get; set; }

        public double CalculatedDistanceToRider { get; set; }
    }
}