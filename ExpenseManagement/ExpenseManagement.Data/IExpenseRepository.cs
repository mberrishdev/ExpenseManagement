using ExpenseManagement.Domain.POCO;

namespace ExpenseManagement.Data
{
    public interface IExpenseRepository
    {
        Task AddExpenseAsync(Expense expense);
        Task<List<Expense>> GetExpenseAllAsync();
        Task UpdateExpenseAsync(Expense expense);
        Task DeleteExpense(Guid expenseId);
    }
}
