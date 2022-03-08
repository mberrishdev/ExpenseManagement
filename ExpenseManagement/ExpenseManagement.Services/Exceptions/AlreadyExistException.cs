using System;

namespace RealEstateManagment.Services.Exceptions
{
    public class AlreadyExistException : BaseException
    {
        public AlreadyExistException(string message) : base(message) 
        { 
        }

    }
}
