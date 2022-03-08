using ExpenseManagement.Services.Implementations;
using ExpenseManagement.Services.Abstractions;


namespace ExpenseManagement.API.Infrastracture.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IJwtService, JwtService>();
            services.AddScoped<IExpenseManService, ExpenseManService>();
            services.AddScoped<IAccountService, AccountService>();

            services.AddRepositories();
        }
    }
}
