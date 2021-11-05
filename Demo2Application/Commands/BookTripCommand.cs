using Demo2Application.Models;

namespace Demo2Application.Commands
{
    public class BookTripCommand
    {
        public BookTripCommand(Trip trip)
        {
            Trip = trip;
        }

        public Trip Trip { get; set; }
    }
}