using Demo2Application.Command_Interfaces;
using Demo2Application.Commands;
using Demo2Application.Database;
using Demo2Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo2Application.CommandHandlers
{
    public class CancelTripCommandHandler : CarBookingBase, ICancelTripCommandHandler
    {
        private readonly List<Trip> _tripsInProgress;
        public CancelTripCommandHandler()
        {
            _tripsInProgress = TripsInProgress;
        }
        public bool CancelTrip(CancelTripCommand cancelTrip)
        {
            var trip = _tripsInProgress.FirstOrDefault(x => x.Cab.CabId == cancelTrip.CabId);
            if (trip != null)
            {
                Console.WriteLine($"The trip from {trip.Origin} to {trip.Destination} has come to an end. Total price {trip.Price}");
                trip.Cab.IsAvailable = true;
                _tripsInProgress.Remove(trip);
                return true;
            }
            return false;
        }
    }
}
