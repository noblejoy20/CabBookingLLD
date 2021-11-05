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

        public void RegisterRider(RegisterRiderCommand registerCommand)
        {
            _riders.Add(registerCommand.Rider);
        }

        public void RegisterDriver(RegisterCabCommand registerCommand)
        {
            _drivers.Add(registerCommand.Cab);
        }
    }
}