using ExpenseManagement.Domain.POCO;
using Microsoft.EntityFrameworkCore;
using RealEstateManagment.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManagement.Data.EF.Repository
{
    public class UserRepository : IUserRepository
    {

        private readonly IBaseRepository<User> _baseRepository;

        public UserRepository(IBaseRepository<User> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<Guid> CreateAsync(User user)
        {
            await _baseRepository.AddAsync(user);
            return user.Id;
        }

        public async Task<bool> Exists(string userName)
        {
            return await _baseRepository.AnyAsync(x => x.UserName == userName);
        }

        public async Task<User> GetAsync(string username, string password)
        {
            return await _baseRepository.Table.SingleOrDefaultAsync(x => x.UserName == username && x.Password == password);
        }

        public async Task<User> GetAsync(string username)
        {
            return await _baseRepository.Table.SingleOrDefaultAsync(x => x.UserName == username);
        }
    }
}
