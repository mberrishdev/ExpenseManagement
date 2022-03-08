using ExpenseManagement.Domain.POCO;
using RealEstateManagment.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManagement.Data.EF.Repository
{
    public class ExpenseRepository : IExpenseRepository
    {

        private readonly IBaseRepository<Expense> _baseRepository;

        public ExpenseRepository(IBaseRepository<Expense> baseRepository)
        {
            _baseRepository = baseRepository;
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
