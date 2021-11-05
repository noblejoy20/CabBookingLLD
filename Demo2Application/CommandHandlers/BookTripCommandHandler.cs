using Demo2Application.Commands;
using Demo2Application.Database;
using Demo2Application.Interfaces;
using Demo2Application.Models;
using Demo2Application.Utilties;
using System.Collections.Generic;

namespace Demo2Application.CommandHandlers
{
    public class BookTripCommandHandler : CarBookingBase, IBookCommandHandler
    {
        private readonly List<Trip> _trips;
        private readonly IUtilityHelper _helper;

        public BookTripCommandHandler()
        {
            _trips = TripsInProgress;
            _helper = new UtitlityHelper();
        }

        public bool BookTrip(BookTripCommand bookCommand)
        {
            bookCommand.Trip.Price = _helper.CalculatePrice(bookCommand.Trip.Origin, bookCommand.Trip.Destination, perKMprice);
            _trips.Add(bookCommand.Trip);
            bookCommand.Trip.Cab.Location = bookCommand.Trip.Rider.Location = bookCommand.Trip.Destination;
            return true;
        }
    }
}