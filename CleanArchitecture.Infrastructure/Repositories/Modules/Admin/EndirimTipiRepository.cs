using CleanArchitecture.Domain.Modules.Admin.EndirimTipis;
using CleanArchitecture.Infrastructure.Context;
using GenericRepository;

namespace CleanArchitecture.Infrastructure.Repositories.Modules.Admin
{
    internal class EndirimTipiRepository : Repository<EndirimTipi, ApplicationDbContext>, IEndirinTipiRepository
    {
        public EndirimTipiRepository(ApplicationDbContext context) : base(context) { }
    }
}
