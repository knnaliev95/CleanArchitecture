using CleanArchitecture.Domain.Modules.Admin.UserScopes;
using CleanArchitecture.Infrastructure.Context;
using GenericRepository;

namespace CleanArchitecture.Infrastructure.Repositories.Modules.Admin
{
    internal class UserScopeRepository : Repository<UserScope, ApplicationDbContext>, IUserScopeRepository
    {
        public UserScopeRepository(ApplicationDbContext context) : base(context) { }
    }
}
