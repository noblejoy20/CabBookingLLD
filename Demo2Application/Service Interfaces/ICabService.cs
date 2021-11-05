using Demo2Application.Models;

namespace Demo2Application.Interfaces
{
    public interface ICabService
    {
        void Register(Cab cab);

        void UpdateCabLocation(int cabId, Location loc);

        void ToggleAvailability(int cabId);
    }
}