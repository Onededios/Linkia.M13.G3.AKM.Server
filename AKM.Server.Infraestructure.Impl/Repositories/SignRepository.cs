using AKM.Server.Infrastructure.Contracts.Entities;
using AKM.Server.Infrastructure.Contracts.Repositories;
using AKM.Server.Infrastructure.Impl.Context;
using System.ComponentModel.DataAnnotations;
namespace AKM.Server.Infrastructure.Impl.Repositories
{
    public class SignRepository : EFRepository<User>, ISignRepository
    {
        public SignRepository(DatabaseContext context) : base(context) { }

        public async Task<bool> CreateUserAsync(User user) => await InsertAsync(user);

        public async Task<User?> GetUserAsync(string username, string password) => await GetByConditionAsync(u => (u.username == username || u.email == username) && u.password == password);
    }
}
