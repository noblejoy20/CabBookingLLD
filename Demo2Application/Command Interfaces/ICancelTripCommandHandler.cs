using Demo2Application.Commands;

namespace Demo2Application.Command_Interfaces
{
    public interface ICancelTripCommandHandler
    {
        bool CancelTrip(CancelTripCommand cancelTrip);
    }
}