using CleanArchitecture.Domain.Modules.Admin.Sablons;
using CleanArchitecture.Infrastructure.Context;
using GenericRepository;

namespace CleanArchitecture.Infrastructure.Repositories.Modules.Admin
{
    internal class SablonRepository : Repository<Sablon, ApplicationDbContext>, ISablonRepository
    {
        public SablonRepository(ApplicationDbContext context) : base(context) { }
    }
}
