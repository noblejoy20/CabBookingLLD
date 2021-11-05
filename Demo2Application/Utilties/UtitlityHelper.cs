using Demo2Application.Interfaces;
using Demo2Application.Models;
using System;

namespace Demo2Application.Utilties
{
    public class UtitlityHelper : IUtilityHelper
    {
        public double CalculatePrice(Location origin, Location destination, double perKMPrice)
        {
            var xdist = (origin.Coordinates.Item1 - destination.Coordinates.Item1) * (origin.Coordinates.Item1 - destination.Coordinates.Item1);
            var ydist = (origin.Coordinates.Item2 - destination.Coordinates.Item2) * (origin.Coordinates.Item2 - destination.Coordinates.Item2);
            var distance = Math.Sqrt(xdist + ydist);
            return distance * perKMPrice;
        }
    }
}