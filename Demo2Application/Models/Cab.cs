using System.Collections.Generic;

namespace Demo2Application.Models
{
    public class Cab
    {
        private static int Identity = 1;
        public Cab(string driverName, List<int> coordinates, string locationName)
        {
            CabId = Identity++;
            DriverName = driverName;
            Location = new Location(coordinates, locationName);
        }
        public int CabId { get; set; }
        public string DriverName { get; set; }
        public Location Location { get; set; }
        public bool IsAvailable { get; set; }
    }
}