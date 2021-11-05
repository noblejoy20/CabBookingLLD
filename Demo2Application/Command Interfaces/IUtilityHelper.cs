using Demo2Application.Models;

namespace Demo2Application.Interfaces
{
    public interface IUtilityHelper
    {
        double CalculatePrice(Location origin, Location destination, double perKMPrice);
    }
}