using CleanArchitecture.Domain.Modules.Admin.XidmetQrupus;
using CleanArchitecture.Infrastructure.Context;
using GenericRepository;

namespace CleanArchitecture.Infrastructure.Repositories.Modules.Admin
{
    internal class XidmetQrupuRepository : Repository<XidmetQrupu, ApplicationDbContext>, IXidmetQrupuRepository
    {
        public XidmetQrupuRepository(ApplicationDbContext context) : base(context) { }
    }
}
