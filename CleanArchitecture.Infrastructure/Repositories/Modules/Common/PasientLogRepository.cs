using CleanArchitecture.Domain.Modules.Common.PasientLogs;
using CleanArchitecture.Infrastructure.Context;
using GenericRepository;

namespace CleanArchitecture.Infrastructure.Repositories.Modules.Common
{
    internal class PasientLogRepository : Repository<PasientLog, ApplicationDbContext> , IPasientLogRepository
    {
        public PasientLogRepository(ApplicationDbContext context) : base(context) { }
    }
}
