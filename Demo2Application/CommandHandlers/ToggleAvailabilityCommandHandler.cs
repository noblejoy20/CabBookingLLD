using Demo2Application.Database;
using Demo2Application.Interfaces;
using Demo2Application.Models;
using System.Collections.Generic;
using System.Linq;

namespace Demo2Application.CommandHandlers
{
    public class ToggleAvailabilityCommandHandler : CarBookingBase, IUpdateAvailabilityCommandHandler
    {
        private readonly List<Cab> _drivers;

        public ToggleAvailabilityCommandHandler()
        {
            _drivers = Drivers;
        }

        public bool UpdateAvailability(int CabId)
        {
            var result = _drivers.Where(d => d.CabId == CabId).FirstOrDefault();
            if (result != null)
            {
                result.IsAvailable = !result.IsAvailable;
                return true;
            }
            return false;
        }
    }
}