using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ExpenseManagement.API.Infrastracture.Attributes
{
    public class IsValidEmailAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var email = value as string;
            if (string.IsNullOrWhiteSpace(email))
                return false;
            return Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }
    }
}
