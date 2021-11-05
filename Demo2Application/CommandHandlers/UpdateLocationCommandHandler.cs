using Demo2Application.Commands;
using Demo2Application.Database;
using Demo2Application.Interfaces;
using Demo2Application.Models;
using System.Collections.Generic;
using System.Linq;

namespace Demo2Application.CommandHandlers
{
    public class UpdateLocationCommandHandler : CarBookingBase, IUpdateCommandHandler
    {
        private readonly List<Cab> _drivers;

        public UpdateLocationCommandHandler()
        {
            _drivers = Drivers;
        }

        public bool UpdateLocation(UpdateCabLocationCommand updateCabLocation)
        {
            var result = _drivers.Where(d => d.CabId == updateCabLocation.CabId).FirstOrDefault();
            if (result != null)
            {
                result.Location = updateCabLocation.LocationToBeUpdated;
                return true;
            }
            return false;
        }
    }
}