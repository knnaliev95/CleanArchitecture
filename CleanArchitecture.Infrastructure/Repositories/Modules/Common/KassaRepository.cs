using CleanArchitecture.Domain.Modules.Common.Kassas;
using CleanArchitecture.Infrastructure.Context;
using GenericRepository;

namespace CleanArchitecture.Infrastructure.Repositories.Modules.Common
{
    internal class KassaRepository : Repository<Kassa, ApplicationDbContext>, IKassaRepository
    {
        public KassaRepository(ApplicationDbContext context) : base(context) { }
    }
}
