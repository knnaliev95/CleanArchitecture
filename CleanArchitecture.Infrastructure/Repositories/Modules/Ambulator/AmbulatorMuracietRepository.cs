using CleanArchitecture.Domain.Modules.Ambulator.AmbulatorMuraciets;
using CleanArchitecture.Infrastructure.Context;
using GenericRepository;

namespace CleanArchitecture.Infrastructure.Repositories.Modules.Ambulator
{
    internal class AmbulatorMuracietRepository : Repository<AmbulatorMuraciet, ApplicationDbContext>, IAmbulatorMuracietRepository
    {
        public AmbulatorMuracietRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
