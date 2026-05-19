using CleanArchitecture.Domain.Modules.Admin.XidmetNovus;
using CleanArchitecture.Infrastructure.Context;
using GenericRepository;

namespace CleanArchitecture.Infrastructure.Repositories.Modules.Admin
{
    internal class XidmetNovuRepository : Repository<XidmetNovu, ApplicationDbContext>, IXidmetNovuRepository
    {
        public XidmetNovuRepository(ApplicationDbContext context) : base(context) { }
    }
}
