using ExpenseManagement.Services.Models.Jwt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManagement.Services.Abstractions
{
    public interface IJwtService
    {
        JwtToken GenerateSecurityToken(string userName);
    }
}
