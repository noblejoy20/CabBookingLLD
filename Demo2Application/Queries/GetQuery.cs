using System;
using System.Collections.Generic;
using System.Text;

namespace Demo2Application.Queries
{
    public class GetQuery
    {
        public GetQuery(int riderId)
        {
            RiderId = riderId;
        }

        public int RiderId { get; set; }
    }
}
