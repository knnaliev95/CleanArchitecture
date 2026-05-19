using CleanArchitecture.Domain.Modules.Admin.Hekims;
using CleanArchitecture.Infrastructure.Context;
using GenericRepository;

namespace CleanArchitecture.Infrastructure.Repositories.Modules.Admin
{
    internal class HekimRepository : Repository<Hekim, ApplicationDbContext>, IHekimRepository
    {
        public HekimRepository(ApplicationDbContext context) : base(context) { }
    }
}
