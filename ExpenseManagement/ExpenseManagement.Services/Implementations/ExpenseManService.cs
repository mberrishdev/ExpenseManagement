using ExpenseManagement.Data;
using ExpenseManagement.Domain.POCO;
using ExpenseManagement.Services.Abstractions;
using ExpenseManagement.Services.Models;
using Mapster;

namespace ExpenseManagement.Services.Implementations
{
    public class ExpenseManService : IExpenseManService
    {
        private readonly IExpenseRepository _expenseRepository;

        public ExpenseManService(IExpenseRepository expenseRepository)
        {
            _expenseRepository = expenseRepository;
        }

        public async Task<List<ExpenseServiceModel>> GetExpenseAllAsync(Guid userId)
        {
            var result = await _expenseRepository.GetExpenseAllAsync(userId);

            return result.Select(expense => new ExpenseServiceModel()
            {
                Id = expense.Id,
                Name = expense.Name,
                Price = expense.Price,
                Currency = expense.Currency,
                Date = expense.Date
            }).ToList();
        }

        public async Task AddExpenseAsync(ExpenseServiceModel expense, Guid userId)
        {
            Expense newExpense = new Expense()
            {
                UserId = userId,
                Name = expense.Name,
                Price = expense.Price,
                Currency = expense.Currency,
                Date = expense.Date
            };

            await _expenseRepository.AddExpenseAsync(newExpense);
        }

        //ToDo: we neet to add one to many relationship between User and Expense


        public async Task DeleteExpense(Guid expenseId)
        {
            await _expenseRepository.DeleteExpense(expenseId);
        }

        public Task UpdateExpenseAsync(ExpenseServiceModel expense)
        {
            throw new NotImplementedException();
        }

    }
}
