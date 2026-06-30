using CleanArchitecture.Domain.Modules.Accounts.Users;
using CleanArchitecture.Infrastructure.Context;
using GenericRepository;

namespace CleanArchitecture.Infrastructure.Repositories.Modules.Accounts
{
    internal class AppUserRepository : Repository<AppUser, ApplicationDbContext>, IAppUserRepository
    {
        public AppUserRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
