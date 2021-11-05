using Demo2Application.Database;
using Demo2Application.Interfaces;
using Demo2Application.Models;
using Demo2Application.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo2Application.QueryHandlers
{
    public class GetQueriesHandler: CarBookingBase, IQueryService
    {
        private readonly List<Rider> _riders;
        public GetQueriesHandler()
        {
            _riders = Riders;
        }

        public List<Trip> GetRiderHistory(GetQuery getRiderHistory)
        {
            var result = new List<Trip>();
            if (_riders.Any(r => r.RiderId == getRiderHistory.RiderId))
            {
                result = _riders.FirstOrDefault(r => r.RiderId == getRiderHistory.RiderId)?.TripsTaken;
            }
            return result;
        }
    }
}
