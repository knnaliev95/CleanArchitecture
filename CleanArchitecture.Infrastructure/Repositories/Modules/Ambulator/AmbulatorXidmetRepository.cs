using CleanArchitecture.Domain.Modules.Ambulator.AmbulatorXidmets;
using CleanArchitecture.Infrastructure.Context;
using GenericRepository;

namespace CleanArchitecture.Infrastructure.Repositories.Modules.Ambulator
{
    internal class AmbulatorXidmetRepository : Repository<AmbulatorXidmet, ApplicationDbContext>, IAmbulatorXidmetRepository
    {
        public AmbulatorXidmetRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
