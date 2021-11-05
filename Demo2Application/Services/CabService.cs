using Demo2Application.CommandHandlers;
using Demo2Application.Commands;
using Demo2Application.Interfaces;
using Demo2Application.Models;
using Demo2Application.QueryHandlers;
using System;

namespace Demo2Application.Services
{
    public class CabService : ICabService
    {
        private readonly IRegisterCommandHandler _registerDriver;
        private readonly IUpdateCommandHandler _updateLocation;
        private readonly IUpdateAvailabilityCommandHandler _updateAvailability;
        private readonly IQueryService _queryService;

        public CabService()
        {
            _registerDriver = new RegisterCommandHandler();
            _updateLocation = new UpdateLocationCommandHandler();
            _updateAvailability = new ToggleAvailabilityCommandHandler();
            _queryService = new GetQueriesHandler();
        }

        public void Register(Cab cab)
        {
            _registerDriver.RegisterDriver(new RegisterCabCommand(cab));
        }

        public void UpdateCabLocation(int cabId, Location loc)
        {
            var isUpdateSuccess = _updateLocation.UpdateLocation(new UpdateCabLocationCommand(cabId, loc));
            if (isUpdateSuccess)
            {
                Console.WriteLine($"Driver {cabId} location updated to {loc.LocationName}");
            }
            else
            {
                Console.WriteLine($"Driver location update failed");
            }
        }

        public void ToggleAvailability(int cabId)
        {
            var isUpdateSuccess = _updateAvailability.UpdateAvailability(cabId);
            if (isUpdateSuccess)
            {
                Console.WriteLine($"Driver Availability status has changed.");
            }
            else
            {
                Console.WriteLine($"Driver Availability status has not been changed.");
            }
        }

        public Cab GetAvailableCab(Rider riderData)
        {
            var newCab = new Cab();
            try
            {
                newCab = _queryService.GetCabDriver(riderData);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return newCab;
        }
    }
}