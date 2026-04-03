using CleanArchitecture.Domain.Modules.Admin.Ixtisases;
using CleanArchitecture.Infrastructure.Context;
using GenericRepository;

namespace CleanArchitecture.Infrastructure.Repositories
{
    internal class IxtisasRepository : Repository<Ixtisas, ApplicationDbContext>, IIxtisasRepository
    {
        public IxtisasRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
