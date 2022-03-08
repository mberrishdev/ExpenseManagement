using ExpenseManagement.API.Models.Requests;
using ExpenseManagement.Services.Abstractions;
using ExpenseManagement.Services.Models.Account;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : BaseController
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService) : base(accountService)
        {
            _accountService = accountService;
        }

        [HttpPost("AuthenticateAccount")]
        public async Task<IActionResult> AuthenticateAccount(LogInRequest request)
        {
            var result = await _accountService.AuthenticateAsync(request.Username, request.Password);
            return Ok(result);
        }


        [HttpPost("RegisterAccount")]
        public async Task<IActionResult> RegisterAccount(SignUpRequest request)
        {
            var result = await _accountService.RegisterAccountAsync(request.Adapt<UserRequestServiceModel>());
            return Ok(result);

        }
    }


}
