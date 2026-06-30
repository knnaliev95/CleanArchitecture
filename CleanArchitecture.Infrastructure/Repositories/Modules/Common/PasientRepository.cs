using CleanArchitecture.Domain.Modules.Common.Pasients;
using CleanArchitecture.Infrastructure.Context;
using GenericRepository;

namespace CleanArchitecture.Infrastructure.Repositories.Modules.Common
{
    internal class PasientRepository : Repository<Pasient, ApplicationDbContext>, IPasientRepository 
    {
        public PasientRepository(ApplicationDbContext context) : base(context) { } 
    }
}
