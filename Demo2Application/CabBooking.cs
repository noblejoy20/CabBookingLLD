using Demo2Application.Services;
using System;

namespace Demo2Application
{
    public class CabBooking
    {
        public static void Main(string[] args)
        {
            var cabService = new CabService();
            var riderService = new RiderService();
            var tripService = new TripService();
            var inputService = new InputService();

            while (true)
            {
                Console.WriteLine("Welcome to Cab Booking Service.\n" +
                "1.Register Rider\n" +
                "2.Register Driver/Cab\n" +
                "3.Update Cab's Location\n" +
                "4.Switch Cab Availability\n" +
                "5.Fetch ride history of rider\n" +
                "6.Book a Cab\n" +
                "7.End a Trip\n");

                Console.WriteLine("Please enter the option number to continue.\n");
                int num = Convert.ToInt32(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        riderService.Register(inputService.GetRiderDetails());
                        break;
                    case 2:
                        cabService.Register(inputService.GetCabDetails());
                        break;
                    case 3:
                        var result = inputService.GetLocationDetailsOfCab();
                        cabService.UpdateCabLocation(result.Item1, result.Item2);
                        break;
                    case 4:
                        var cabId = inputService.GetCabId();
                        cabService.ToggleAvailability(cabId);
                        break;
                    case 5:
                        var riderId = inputService.GetRiderId();
                        riderService.GetRiderHistory(riderId);
                        break;
                    case 6:
                        break;
                    case 7:
                        cabId = inputService.GetCabId();
                        tripService.CancelTrip(cabId);
                        break;


                }
            }
        }
    }
}