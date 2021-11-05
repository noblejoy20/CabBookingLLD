namespace Demo2Application.Models
{
    public class Cab
    {
        public int CabId { get; set; }
        public string DriverName { get; set; }
        public Location Location { get; set; }
        public bool IsAvailable { get; set; }
    }
}