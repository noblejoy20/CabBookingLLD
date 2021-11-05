using Demo2Application.Commands;

namespace Demo2Application.Interfaces
{
    public interface IRegisterCommandHandler
    {
        void RegisterRider(RegisterRiderCommand registerCommand);

        void RegisterDriver(RegisterCabCommand registerCommand);
    }
}