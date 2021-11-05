using System.Collections.Generic;

namespace Demo2Application.Models
{
    public class Location
    {
        public Location(List<int> coordinates, string locationName)
        {
            Coordinates = (coordinates[0], coordinates[1]);
            LocationName = locationName;
        }

        public (int, int) Coordinates { get; set; }
        public string LocationName { get; set; }
    }
}