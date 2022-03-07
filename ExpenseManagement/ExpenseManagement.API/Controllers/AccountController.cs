using ExpenseManagement.API.Models.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        public AccountController()
        {
        }

        [HttpPost("AuthenticateAccount")]
        public async Task<IActionResult> AuthenticateAccount(LogInRequest request)
        {

            return Ok();
        }

        [HttpPost("RegisterAccount")]
        public async Task<IActionResult> RegisterAccount(SignUpRequest request)
        {
            return Ok();
        }
    }


}
