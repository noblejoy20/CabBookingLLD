using Demo2Application.Models;

namespace Demo2Application.Commands
{
    public class RegisterCabCommand
    {
        public RegisterCabCommand(Cab cab)
        {
            Cab = cab;
        }

        public Cab Cab { get; set; }
    }
}