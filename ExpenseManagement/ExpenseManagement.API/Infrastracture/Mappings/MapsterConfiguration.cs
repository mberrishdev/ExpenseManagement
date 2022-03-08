using ExpenseManagement.API.Models.Requests;
using ExpenseManagement.Domain.POCO;
using ExpenseManagement.Services.Models;
using ExpenseManagement.Services.Models.Account;
using Mapster;

namespace ExpenseManagement.API.Infrastracture.Mappings
{
    public static class MapsterConfiguration
    {
        public static void RegisterMaps(this IServiceCollection service)
        {
            TypeAdapterConfig<UserRequestServiceModel, User>
            .NewConfig()
            .TwoWays();

            TypeAdapterConfig<UserRequestServiceModel, Models.User>
            .NewConfig()
            .TwoWays();
            

            TypeAdapterConfig<UserServiceModel, User>
            .NewConfig()
            .TwoWays();

            TypeAdapterConfig<SignUpRequest, UserRequestServiceModel>
            .NewConfig()
            .TwoWays();

            TypeAdapterConfig<ExpenseServiceModel, Expense>
            .NewConfig()
            .TwoWays();
            
        }
    }
}
