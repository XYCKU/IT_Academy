using System;

namespace Models
{
    public class WrongStoreNameException : Exception
    {
        public WrongStoreNameException(string msg) : base(msg) { }
    }
}
