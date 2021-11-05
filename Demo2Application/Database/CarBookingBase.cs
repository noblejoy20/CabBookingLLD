using Demo2Application.Models;
using System.Collections.Generic;

namespace Demo2Application.Database
{
    public abstract class CarBookingBase
    {
        protected static List<Cab> Drivers;

        protected static List<Rider> Riders;
        protected static List<Trip> TripsInProgress;
        protected static double perKMprice = 5.0;

        static CarBookingBase()
        {
            Drivers = new List<Cab>();
            Riders = new List<Rider>();
            TripsInProgress = new List<Trip>();
        }
    }
}