using ExpenseManagement.Domain.POCO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManagement.PersistanceDB.Context
{
    public class ExpenseManagementContext : DbContext
    {

        public ExpenseManagementContext(DbContextOptions<ExpenseManagementContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Expense> Expenses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ExpenseManagementContext).Assembly);
        }

    }
}
