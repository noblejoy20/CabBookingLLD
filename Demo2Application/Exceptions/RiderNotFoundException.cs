using System;

namespace Demo2Application.Exceptions
{
    public class RiderNotFoundException : Exception
    {
        public RiderNotFoundException(string message) : base(message)
        {
        }
    }
}