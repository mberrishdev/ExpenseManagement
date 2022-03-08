using ExpenseManagement.API.Models;
using ExpenseManagement.Services.Abstractions;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseManagement.API.Controllers
{
    public class BaseController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public BaseController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        protected async Task<User> GetUser()
        {
            var userName = HttpContext.Request.HttpContext.User.Identities.FirstOrDefault()?.Name;

            if (userName == null)
                throw new NullReferenceException();

            var result = await _accountService.GetUserAsync(userName);

            return result.Adapt<User>();
        }
    }
}
