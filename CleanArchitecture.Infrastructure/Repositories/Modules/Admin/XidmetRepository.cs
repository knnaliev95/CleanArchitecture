using CleanArchitecture.Domain.Modules.Admin.Xidmets;
using CleanArchitecture.Infrastructure.Context;
using GenericRepository;

namespace CleanArchitecture.Infrastructure.Repositories.Modules.Admin
{
    internal class XidmetRepository : Repository<Xidmet, ApplicationDbContext>, IXidmetRepository
    {
        public XidmetRepository(ApplicationDbContext context) : base(context) { }
    }
}
