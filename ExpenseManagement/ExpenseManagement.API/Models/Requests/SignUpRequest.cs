using ExpenseManagement.API.Infrastracture.Attributes;

namespace ExpenseManagement.API.Models.Requests
{
    public class SignUpRequest
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        [IsValidEmail]
        public string Email { get; set; }
    }
}
