using AKM.Server.Infrastructure.Contracts.Entities;
using AKM.Server.Infrastructure.Contracts.Repositories;
using AKM.Server.Infrastructure.Impl.Context;
namespace AKM.Server.Infrastructure.Impl.Repositories
{
    public class UserRepository : EFRepository<User>, IUserRepository
    {
        public UserRepository(DatabaseContext context) : base(context) { }

        public async Task<bool> CreateUserAsync(User user) => await InsertAsync(user);
        public async Task<User?> SignInAsync(string username, string password) => await GetByConditionAsync(u => (u.username == username || u.email == username) && u.password == password);
        public async Task<User?> GetUserAsync(Guid id) => await GetByIdAsync(id);
        public async Task<bool> UpdateUserAsync(User user) => await UpdateAsync(user);
        public async Task<bool> CheckUsernameAsync(string inp) => await CheckAttrAsync(u => u.username == inp);
        public async Task<bool> CheckMailAsync(string inp) => await CheckAttrAsync(u => u.email == inp);
        public async Task<User?> GetUserByIdAsync(Guid id) => await GetByIdAsync(id);
    }
}
