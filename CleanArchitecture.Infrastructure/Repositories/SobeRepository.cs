using CleanArchitecture.Domain.Modules.Admin.Sobeler;
using CleanArchitecture.Infrastructure.Context;
using GenericRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Infrastructure.Repositories
{
    internal class SobeRepository : Repository<Sobe, ApplicationDbContext>, ISobeRepository
    {
        public SobeRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
