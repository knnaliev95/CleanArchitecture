using CleanArchitecture.Domain.Modules.Admin.Diaqnozs;
using CleanArchitecture.Infrastructure.Context;
using GenericRepository;

namespace CleanArchitecture.Infrastructure.Repositories.Modules.Admin
{
    internal class DiaqnozRepository : Repository<Diaqnoz, ApplicationDbContext>, IDiaqnozRepository
    {
        public DiaqnozRepository(ApplicationDbContext context) : base(context) { }
    }
}
