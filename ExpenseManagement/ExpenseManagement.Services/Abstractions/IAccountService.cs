using ExpenseManagement.Services.Models.Account;
using ExpenseManagement.Services.Models.Jwt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManagement.Services.Abstractions
{
    public interface IAccountService
    {
        Task<Guid> RegisterAccountAsync(UserServiceModel account);
        Task<JwtToken> AuthenticateAsync(string username, string password);
    }
}
