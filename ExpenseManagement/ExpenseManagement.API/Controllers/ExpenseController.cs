using ExpenseManagement.API.Models.Requests;
using ExpenseManagement.API.Models.Responses;
using ExpenseManagement.Services.Abstractions;
using ExpenseManagement.Services.Models;
using Mapster;
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
        public async Task<IActionResult> GetAllExpenses()
        {
            var user = await GetUser();

            var resut = await _expenseManSrvice.GetExpenseAllAsync(user.Id);
            return new JsonResult(resut.Select(expense=>new Expense()
            {
                Id = expense.Id,
                Name = expense.Name,
                Price = expense.Price,
                Currency =expense.Currency,
                Date   =expense.Date
            }));
        }

        [HttpPost]
        public async Task<IActionResult> Post(ExpensePostRequest request)
        {
            var user = await GetUser();

            await _expenseManSrvice.AddExpenseAsync(request.Adapt<ExpenseServiceModel>(), user.Id);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Guid expenseId)
        {
            await _expenseManSrvice.DeleteExpense(expenseId);
            return Ok();
        }


    }


}
