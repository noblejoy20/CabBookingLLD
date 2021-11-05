using Demo2Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo2Application.Services
{
    public class InputService
    {
        public Rider GetRiderDetails()
        {
            Console.WriteLine("Enter the name of the Rider:\t");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the coordinates:\t");
            string coordinates = Console.ReadLine();
            var output = coordinates.Split(' ').Select(x => Convert.ToInt32(x)).ToList();
            Console.WriteLine("Enter the location:\t");
            string locationName = Console.ReadLine();
            return new Rider(name, output, locationName);
        }

        public Cab GetCabDetails()
        {
            Console.WriteLine("Enter the name of the Driver:\t");
            string name = Console.ReadLine();
            var location = GetLocation();
            return new Cab(name, new List<int>() { location.Coordinates.Item1, location.Coordinates.Item2 }, location.LocationName);
        }

        public (int, Location) GetLocationDetailsOfCab()
        {
            var Id = GetCabId();
            var location = GetLocation();
            return (Id, location);
        }

        public Location GetLocation()
        {
            Console.WriteLine("Enter the coordinates:\t");
            string coordinates = Console.ReadLine();
            var output = coordinates.Split(' ').Select(x => Convert.ToInt32(x)).ToList();
            Console.WriteLine("Enter the location:\t");
            string locationName = Console.ReadLine();
            return new Location(output, locationName);
        }

        public int GetCabId()
        {
            Console.WriteLine("Enter the cab Id whose data needs to be changed:\t");
            int Id = Convert.ToInt32(Console.ReadLine());
            return Id;
        }

        public int GetRiderId()
        {
            Console.WriteLine("Enter the rider Id whose history needs to be fetched:\t");
            int Id = Convert.ToInt32(Console.ReadLine());
            return Id;
        }
    }
}