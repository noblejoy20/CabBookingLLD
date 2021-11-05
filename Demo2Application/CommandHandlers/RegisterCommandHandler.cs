using Demo2Application.Commands;
using Demo2Application.Database;
using Demo2Application.Interfaces;
using Demo2Application.Models;
using System.Collections.Generic;

namespace Demo2Application.CommandHandlers
{
    public class RegisterCommandHandler : CarBookingBase, IRegisterCommandHandler
    {
        private readonly List<Rider> _riders;
        private readonly List<Cab> _drivers;

        public RegisterCommandHandler()
        {
            _riders = Riders;
            _drivers = Drivers;
        }

        public bool RegisterRider(RegisterRiderCommand registerCommand)
        {
            _riders.Add(registerCommand.Rider);
            return true;
        }

        public bool RegisterDriver(RegisterCabCommand registerCommand)
        {
            _drivers.Add(registerCommand.Cab);
            return true;
        }
    }
}