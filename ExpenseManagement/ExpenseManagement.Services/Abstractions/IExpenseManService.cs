
using ExpenseManagement.Services.Models;

namespace ExpenseManagement.Services.Abstractions
{
    public interface IExpenseManService
    {
        Task AddExpenseAsync(ExpenseServiceModel expense, Guid userId);
        Task<List<ExpenseServiceModel>> GetExpenseAllAsync(Guid userId);
        Task UpdateExpenseAsync(ExpenseServiceModel expense);
        Task DeleteExpense(Guid expenseId);
    }
}
