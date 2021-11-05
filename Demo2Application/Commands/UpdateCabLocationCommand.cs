using Demo2Application.Models;

namespace Demo2Application.Commands
{
    public class UpdateCabLocationCommand
    {
        public UpdateCabLocationCommand(int cabId, Location location)
        {
            CabId = cabId;
            LocationToBeUpdated = location;
        }

        public int CabId { get; set; }
        public Location LocationToBeUpdated { get; set; }
    }
}