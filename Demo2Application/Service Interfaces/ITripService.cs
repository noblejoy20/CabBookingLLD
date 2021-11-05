using Demo2Application.Models;

namespace Demo2Application.Interfaces
{
    public interface ITripService
    {
        void BookTrip(Rider rider, Cab cab, Location loc);
    }
}