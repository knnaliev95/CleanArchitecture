using CleanArchitecture.Domain.Modules.Admin.Faizs;
using CleanArchitecture.Infrastructure.Context;
using GenericRepository;

namespace CleanArchitecture.Infrastructure.Repositories.Modules.Admin
{
    internal class FaizRepository : Repository<Faiz, ApplicationDbContext>, IFaizRepository
    {
        public FaizRepository(ApplicationDbContext context) : base(context) { }
    }
}
