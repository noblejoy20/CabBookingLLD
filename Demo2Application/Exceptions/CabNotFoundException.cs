using System;

namespace Demo2Application.Exceptions
{
    public class CabNotFoundException : Exception
    {
        public CabNotFoundException(string message) : base(message)
        {
        }
    }
}