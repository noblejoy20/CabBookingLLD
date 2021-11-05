using Demo2Application.Command_Interfaces;
using Demo2Application.CommandHandlers;
using Demo2Application.Commands;
using Demo2Application.Interfaces;
using Demo2Application.Models;
using System;

namespace Demo2Application.Services
{
    public class TripService : ITripService
    {
        private readonly IBookCommandHandler _bookCommand;
        private readonly ICancelTripCommandHandler _cancelCommand;
        private readonly ICabService _cabService;

        public TripService()
        {
            _cabService = new CabService();
            _bookCommand = new BookTripCommandHandler();
            _cancelCommand = new CancelTripCommandHandler();
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

        public void CancelTrip(int cabId)
        {
            var result = _cancelCommand.CancelTrip(new CancelTripCommand(cabId));
            if (result)
            {
                Console.WriteLine($"Trip Has been canceled successfully.");
            }
            else
            {
                Console.WriteLine($"Trip couldn't be canceled successfully.");
            }
        }
    }
}