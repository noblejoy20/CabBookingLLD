using Demo2Application.Database;
using Demo2Application.Exceptions;
using Demo2Application.Interfaces;
using Demo2Application.Models;
using Demo2Application.Queries;
using Demo2Application.Utilties;
using System.Collections.Generic;
using System.Linq;

namespace Demo2Application.QueryHandlers
{
    public class GetQueriesHandler : CarBookingBase, IQueryService
    {
        private readonly List<Rider> _riders;
        private readonly List<Cab> _cabs;
        private readonly IUtilityHelper _utilityHelper;

        public GetQueriesHandler()
        {
            _riders = Riders;
            _cabs = Drivers;
            _utilityHelper = new UtitlityHelper();
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

        public Rider GetRider(GetQuery getRiderInfo)
        {
            var rider = new Rider();
            if (_riders.Any(r => r.RiderId == getRiderInfo.RiderId))
            {
                rider = _riders.FirstOrDefault(r => r.RiderId == getRiderInfo.RiderId);
            }
            else
            {
                throw new RiderNotFoundException("Rider is not registered with us.");
            }
            return rider;
        }

        public Cab GetCabDriver(Rider riderInfo)
        {
            var availableCab = _cabs.Where(x => x.IsAvailable).Select(x => new Cab()
            {
                CabId = x.CabId,
                Location = x.Location,
                IsAvailable = x.IsAvailable,
                DriverName = x.DriverName,
                CalculatedDistanceToRider = _utilityHelper.CalculatePrice(x.Location, riderInfo.Location, perKMprice)
            }).OrderBy(c => c.CalculatedDistanceToRider).FirstOrDefault();

            if (availableCab == null)
            {
                throw new CabNotFoundException("There is no available Cabs at the moment");
            }

            return availableCab;
        }
    }
}