using ExpenseManagement.API.Models.Requests;
using ExpenseManagement.Domain.POCO;
using ExpenseManagement.Services.Models.Account;
using Mapster;

namespace ExpenseManagement.API.Infrastracture.Mappings
{
    public static class MapsterConfiguration
    {
        public static void RegisterMaps(this IServiceCollection service)
        {
            TypeAdapterConfig<UserServiceModel, User>
            .NewConfig()
            .TwoWays();

            TypeAdapterConfig<SignUpRequest, UserServiceModel>
            .NewConfig()
            .TwoWays();
        }
    }
}
