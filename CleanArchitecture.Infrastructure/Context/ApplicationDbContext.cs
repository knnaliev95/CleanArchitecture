using CleanArchitecture.Domain.Modules.Admin.Ixtisases;
using CleanArchitecture.Domain.Modules.Admin.Sobeler;
using GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Context
{
    internal class ApplicationDbContext : DbContext, IUnitOfWork
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Ixtisas> Ixtisas { get; set; }
        public DbSet<Sobe> Sobe { get; set; }
    }
}
