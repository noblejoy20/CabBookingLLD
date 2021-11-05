using Demo2Application.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo2Application.Command_Interfaces
{
    public interface ICancelTripCommandHandler
    {
        bool CancelTrip(CancelTripCommand cancelTrip);
    }
}
