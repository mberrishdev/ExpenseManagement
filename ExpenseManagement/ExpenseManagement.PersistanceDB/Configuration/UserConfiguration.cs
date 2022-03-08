using ExpenseManagement.Domain.POCO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExpenseManagement.PersistanceDB.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasIndex(x => new { x.UserName }).IsUnique();

            builder.Property(x => x.Id).HasColumnType("UniqueIdentifier");

            builder.Property(x => x.UserName).IsUnicode(false).IsRequired().HasMaxLength(50);

            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50);

            builder.Property(x => x.LastName).IsRequired().HasMaxLength(50);

            builder.Property(x => x.Email).IsRequired().HasMaxLength(50);


            builder.Property(x => x.Password).IsUnicode(false).IsRequired();
        }
    }
}
