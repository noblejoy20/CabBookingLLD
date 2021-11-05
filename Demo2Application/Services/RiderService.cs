using Demo2Application.CommandHandlers;
using Demo2Application.Commands;
using Demo2Application.Interfaces;
using Demo2Application.Models;
using Demo2Application.Queries;
using Demo2Application.QueryHandlers;
using System;
using System.Collections.Generic;

namespace Demo2Application.Services
{
    public class RiderService
    {
        private readonly IRegisterCommandHandler _registerRider;
        private readonly ITripService _tripService;
        private readonly IQueryService _queryService;

        public RiderService()
        {
            _registerRider = new RegisterCommandHandler();
            _tripService = new TripService();
            _queryService = new GetQueriesHandler();
        }

        public void Register(Rider rider)
        {
            var ans = _registerRider.RegisterRider(new RegisterRiderCommand(rider));
            if (ans)
            {
                Console.WriteLine($"Rider {rider.RiderId} with name {rider.RiderName} has been registered.");
            }
        }

        public void BookARide(Rider rider, Cab cab, Location loc)
        {
            _tripService.BookTrip(rider, cab, loc);
        }

        public List<Trip> GetRiderHistory(int riderId)
        {
            return _queryService.GetRiderHistory(new GetQuery(riderId));
        }

        public Rider GetRiderData(int riderId)
        {
            var fetchedRider = new Rider();
            try
            {
                fetchedRider = _queryService.GetRider(new GetQuery(riderId));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return fetchedRider;
        }
    }
}