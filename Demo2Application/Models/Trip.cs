namespace Demo2Application.Models
{
    public class Trip
    {
        public Trip(Rider rider, Cab cab, Location location)
        {
            Rider = rider;
            Cab = cab;
            Origin = rider.Location;
            Destination = location;
        }

        public Location Origin { get; set; }
        public Location Destination { get; set; }
        public Rider Rider { get; set; }
        public Cab Cab { get; set; }
        public double Price { get; set; }
    }
}