using System;
using System.Collections.Generic;
using System.Text;

namespace Demo2Application.Commands
{
    public class CancelTripCommand
    {
        public CancelTripCommand(int cabId)
        {
            CabId = cabId;
        }

        public int CabId { get; set; }
    }
}
