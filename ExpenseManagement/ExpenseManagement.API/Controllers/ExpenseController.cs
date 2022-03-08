using ExpenseManagement.Services.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseManagement.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseController : BaseController
    {

        private readonly IExpenseManService _expenseManSrvice;

        public ExpenseController(IExpenseManService expenseManService, IAccountService accountService) : base(accountService)
        {
            _expenseManSrvice = expenseManService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllExpense()
        {
            var user = await GetUser());

            _expenseManSrvice.GetExpenseAllAsync(user.Id);
        }


    }


}
