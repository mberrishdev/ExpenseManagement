namespace ExpenseManagement.API.Infrastracture.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddRepositories();
        }
    }
}
