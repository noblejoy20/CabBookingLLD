using Demo2Application.Models;
using Demo2Application.Queries;
using System.Collections.Generic;

namespace Demo2Application.Interfaces
{
    public interface IQueryService
    {
        List<Trip> GetRiderHistory(GetQuery getRiderHistory);

        Rider GetRider(GetQuery getRiderInfo);

        Cab GetCabDriver(Rider riderInfo);
    }
}