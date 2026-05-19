using CleanArchitecture.Domain.Modules.Admin.MuracietSebebis;
using CleanArchitecture.Infrastructure.Context;
using GenericRepository;

namespace CleanArchitecture.Infrastructure.Repositories.Modules.Admin
{
    internal class MuracietSebebiRepository : Repository<MuracietSebebi, ApplicationDbContext>, IMuracietSebebiRepository
    {
        public MuracietSebebiRepository(ApplicationDbContext contex) : base(contex) { }
    }
}
