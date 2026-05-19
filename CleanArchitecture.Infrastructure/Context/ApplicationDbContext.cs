using CleanArchitecture.Domain.Modules.Admin.Diaqnozs;
using CleanArchitecture.Domain.Modules.Admin.EndirimTipis;
using CleanArchitecture.Domain.Modules.Admin.Hekims;
using CleanArchitecture.Domain.Modules.Admin.Ixtisases;
using CleanArchitecture.Domain.Modules.Admin.MuracietSebebis;
using CleanArchitecture.Domain.Modules.Admin.Sablons;
using CleanArchitecture.Domain.Modules.Admin.Sobeler;
using CleanArchitecture.Domain.Modules.Admin.Teskilats;
using CleanArchitecture.Domain.Modules.Admin.XidmetNovus;
using CleanArchitecture.Domain.Modules.Admin.XidmetQrupus;
using CleanArchitecture.Domain.Modules.Admin.Xidmets;
using GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Context
{
    internal class ApplicationDbContext : DbContext, IUnitOfWork
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        // admin module
        public DbSet<Ixtisas> Ixtisas { get; set; }
        public DbSet<Sobe> Sobe { get; set; }
        public DbSet<Hekim> Hekim { get; set; }
        public DbSet<Teskilat> Teskilat { get; set; }
        public DbSet<Diaqnoz> Diaqnoz { get; set; }
        public DbSet<EndirimTipi> EndirimTipi { get; set; }
        public DbSet<MuracietSebebi> MuracietSebebi { get; set; }
        public DbSet<Sablon> Sablon { get; set; }
        public DbSet<XidmetNovu> XidmetNovu { get; set; }
        public DbSet<XidmetQrupu> XidmetQrupu { get; set; }
        public DbSet<Xidmet> Xidmet { get; set; }
    }
}
