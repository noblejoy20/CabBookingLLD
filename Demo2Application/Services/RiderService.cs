using Demo2Application.CommandHandlers;
using Demo2Application.Commands;
using Demo2Application.Interfaces;
using Demo2Application.Models;

namespace Demo2Application.Services
{
    public class RiderService
    {
        private readonly IRegisterCommandHandler _registerRider;
        private readonly ITripService _tripService;

        public RiderService()
        {
            _registerRider = new RegisterCommandHandler();
            _tripService = new TripService();
        }

        public void Register(Rider rider)
        {
            _registerRider.RegisterRider(new RegisterRiderCommand(rider));
        }

        public void BookARide(Rider rider, Cab cab, Location loc)
        {
            _tripService.BookTrip(rider, cab, loc);
        }
    }
}