using Demo2Application.Commands;

namespace Demo2Application.Interfaces
{
    public interface IBookCommandHandler
    {
        bool BookTrip(BookTripCommand bookCommand);
    }
}