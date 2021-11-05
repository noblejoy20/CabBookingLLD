using Demo2Application.Models;

namespace Demo2Application.Commands
{
    public class RegisterRiderCommand
    {
        public RegisterRiderCommand(Rider rider)
        {
            Rider = rider;
        }

        public Rider Rider { get; set; }
    }
}