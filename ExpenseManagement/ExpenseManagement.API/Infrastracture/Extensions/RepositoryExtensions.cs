using ExpenseManagement.Data;
using ExpenseManagement.Data.EF.Repository;
using RealEstateManagment.Data;

namespace ExpenseManagement.API.Infrastracture.Extensions
{
    public static class RepositoryExtensions
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IExpenseRepository, ExpenseRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        }
    }
}
