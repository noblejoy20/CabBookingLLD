using Demo2Application.Commands;

namespace Demo2Application.Interfaces
{
    public interface IUpdateCommandHandler
    {
        bool UpdateLocation(UpdateCabLocationCommand updateCabLocation);
    }
}