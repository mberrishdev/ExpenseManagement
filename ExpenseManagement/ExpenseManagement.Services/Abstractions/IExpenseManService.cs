
using ExpenseManagement.Services.Models;

namespace ExpenseManagement.Services.Abstractions
{
    public interface IExpenseManService
    {
        Task AddExpenseAsync(Expense expense);
        Task<List<Expense>> GetExpenseAllAsync();
        Task UpdateExpenseAsync(Expense expense);
        Task DeleteExpense(Guid expenseId);
    }
}
