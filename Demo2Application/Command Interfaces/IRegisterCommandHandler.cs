using Demo2Application.Commands;

namespace Demo2Application.Interfaces
{
    public interface IRegisterCommandHandler
    {
        bool RegisterRider(RegisterRiderCommand registerCommand);

        bool RegisterDriver(RegisterCabCommand registerCommand);
    }
}