using ExpenseManagement.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateManagment.Services.Exceptions
{
    public class BaseException : Exception
    {
        public ApiError ApiError { get; set; }
        private string ErrorMessage { get; set; }

        protected BaseException(string message)
            : base(message) => ErrorMessage = message;

        public BaseException(string message, Exception exception)
            : base(message, exception) => ErrorMessage = message;

        public BaseException AddApiError(int errorCode, string message)
        {
            ApiError = new ApiError
            {
                Status = errorCode,
                Detail = message
            };
            return this;
        }
    }
}
