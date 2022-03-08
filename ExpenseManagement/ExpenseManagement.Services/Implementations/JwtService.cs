using ExpenseManagement.Services.Abstractions;
using ExpenseManagement.Services.Models.Jwt;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManagement.Services.Implementations
{
    public class JwtService : IJwtService
    {
        private readonly string _secret;
        private readonly int _expDateInMinutes;

        public JwtService(IOptions<JwtConfiguration> options)
        {
            _secret = options.Value.Secret;
            _expDateInMinutes = options.Value.ExpirationInMinutes;
        }

        public JwtToken GenerateSecurityToken(string userName)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_secret);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, userName),
                }),
                Expires = DateTime.UtcNow.AddMinutes(_expDateInMinutes),
                Audience = "localhost",
                Issuer = "localhost",
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return new JwtToken()
            {
                Token = tokenHandler.WriteToken(token)
            };

        }
    }
}
