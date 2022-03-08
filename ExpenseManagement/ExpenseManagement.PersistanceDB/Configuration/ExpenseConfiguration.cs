using ExpenseManagement.Domain.POCO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManagement.PersistanceDB.Configuration
{
    public class ExpenseConfiguration : IEntityTypeConfiguration<Expense>
    {
        public void Configure(EntityTypeBuilder<Expense> builder)
        {
            builder.Property(x => x.Id).HasColumnType("UniqueIdentifier");

            builder.Property(x => x.UserId).HasColumnType("UniqueIdentifier");

            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);

            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.Currency).IsUnicode(false).IsRequired().HasMaxLength(5);

            builder.Property(x => x.Date).IsRequired();
        }
    }
}
