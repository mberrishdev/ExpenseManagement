using ExpenseManagement.Data;
using ExpenseManagement.Services.Abstractions;
using ExpenseManagement.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManagement.Services.Implementations
{
    public class ExpenseManService : IExpenseManService
    {
        private readonly IExpenseRepository _expenseRepository;

        public ExpenseManService(IExpenseRepository expenseRepository)
        {
            _expenseRepository = expenseRepository;
        }

        public Task AddExpenseAsync(Expense expense)
        {
            throw new NotImplementedException();
        }

        public Task DeleteExpense(Guid expenseId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Expense>> GetExpenseAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateExpenseAsync(Expense expense)
        {
            throw new NotImplementedException();
        }
    }
}
