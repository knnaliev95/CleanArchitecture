using CleanArchitecture.Domain.Modules.Admin.Sobeler;
using CleanArchitecture.Infrastructure.Context;
using GenericRepository;

namespace CleanArchitecture.Infrastructure.Repositories.Modules.Admin
{
    internal class SobeRepository : Repository<Sobe, ApplicationDbContext>, ISobeRepository
    {
        public SobeRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
