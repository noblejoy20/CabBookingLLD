using Demo2Application.CommandHandlers;
using Demo2Application.Commands;
using Demo2Application.Interfaces;
using Demo2Application.Models;

namespace Demo2Application.Services
{
    public class TripService : ITripService
    {
        private readonly IBookCommandHandler _bookCommand;
        private readonly ICabService _cabService;

        public TripService()
        {
            _cabService = new CabService();
            _bookCommand = new BookTripCommandHandler();
        }

        public void BookTrip(Rider rider, Cab cab, Location loc)
        {
            var trip = new Trip(rider, cab, loc);
            var result = _bookCommand.BookTrip(new BookTripCommand(trip));
            if (result)
            {
                _cabService.ToggleAvailability(cab.CabId);
            }
        }
    }
}