using CleanArchitecture.Domain.Modules.Admin.Teskilats;
using CleanArchitecture.Infrastructure.Context;
using GenericRepository;

namespace CleanArchitecture.Infrastructure.Repositories.Modules.Admin
{
    internal class TeskilatRepository : Repository<Teskilat, ApplicationDbContext>, ITeskilatRepository
    {
        public TeskilatRepository(ApplicationDbContext context) : base(context) { }
    }
}
