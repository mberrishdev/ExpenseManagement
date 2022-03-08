using ExpenseManagement.Data;
using ExpenseManagement.Domain.POCO;
using ExpenseManagement.Services.Abstractions;
using ExpenseManagement.Services.Models.Account;
using ExpenseManagement.Services.Models.Jwt;
using Mapster;
using RealEstateManagment.Services.Exceptions;
using System.Security.Cryptography;
using System.Text;

namespace ExpenseManagement.Services.Implementations
{
    public class AccountService : IAccountService
    {
        private readonly IJwtService _jwtService;
        private readonly IUserRepository _userRepository;

        public AccountService(IUserRepository userRepository, IJwtService jwtService)
        {
            _userRepository = userRepository;
            _jwtService = jwtService;
        }

        public async Task<JwtToken> AuthenticateAsync(string username, string password)
        {
            var userEntity = await _userRepository.GetAsync(username, GenerateMD5Hash(password));

            if (userEntity == null)
                throw new AuthenticateException($"username or password is not correct").AddApiError(400, $"username or password is not correct");

            return _jwtService.GenerateSecurityToken(userEntity.UserName);
        }

        public async Task<Guid> RegisterAccountAsync(UserServiceModel user)
        {
            if (await _userRepository.Exists(user.UserName))
                throw new AlreadyExistException($"{user.UserName} already exist").AddApiError(400, $"{user.UserName} already exist");

            var hashedPassword = GenerateMD5Hash(user.Password);
            user.Password = hashedPassword;

            return await _userRepository.CreateAsync(user.Adapt<User>());
        }

        private static string GenerateMD5Hash(string input)
        {
            using MD5 mD5 = MD5.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            byte[] hashBytes = mD5.ComputeHash(bytes);

            StringBuilder sb = new();
            foreach (var t in hashBytes)
            {
                sb.Append(t.ToString("X2"));
            }

            return sb.ToString();
        }

    }
}
