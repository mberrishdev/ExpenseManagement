using ExpenseManagement.Domain.POCO;

namespace ExpenseManagement.Data
{
    public interface IUserRepository
    {
        Task<User> GetAsync(string username, string password);
        Task<Guid> CreateAsync(User user);
        Task<bool> Exists(string userName);
    }
}
