using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateManagment.Services.Exceptions
{
    public class AuthenticateException : BaseException
    {
        public AuthenticateException(string message) : base(message)
        {
        }
    }
}
