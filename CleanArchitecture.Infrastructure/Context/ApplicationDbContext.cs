using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Accounts.Users;
using CleanArchitecture.Domain.Modules.Admin.Diaqnozs;
using CleanArchitecture.Domain.Modules.Admin.EndirimTipis;
using CleanArchitecture.Domain.Modules.Admin.Faizs;
using CleanArchitecture.Domain.Modules.Admin.Hekims;
using CleanArchitecture.Domain.Modules.Admin.Ixtisases;
using CleanArchitecture.Domain.Modules.Admin.MuracietSebebis;
using CleanArchitecture.Domain.Modules.Admin.Sablons;
using CleanArchitecture.Domain.Modules.Admin.Sobeler;
using CleanArchitecture.Domain.Modules.Admin.Teskilats;
using CleanArchitecture.Domain.Modules.Admin.UserScopes;
using CleanArchitecture.Domain.Modules.Admin.XidmetNovus;
using CleanArchitecture.Domain.Modules.Admin.XidmetQrupus;
using CleanArchitecture.Domain.Modules.Admin.Xidmets;
using CleanArchitecture.Domain.Modules.Ambulator.AmbulatorMuraciets;
using CleanArchitecture.Domain.Modules.Ambulator.AmbulatorXidmets;
using CleanArchitecture.Domain.Modules.Aptek.Medaxils;
using CleanArchitecture.Domain.Modules.Aptek.OlcuVahidis;
using CleanArchitecture.Domain.Modules.Aptek.Qaimes;
using CleanArchitecture.Domain.Modules.Aptek.Sinifs;
using CleanArchitecture.Domain.Modules.Aptek.SobeMedaxils;
using CleanArchitecture.Domain.Modules.Aptek.SobeMexarics;
using CleanArchitecture.Domain.Modules.Aptek.SobeStocks;
using CleanArchitecture.Domain.Modules.Aptek.Stocks;
using CleanArchitecture.Domain.Modules.Aptek.Tedarukcus;
using CleanArchitecture.Domain.Modules.Aptek.TelebnameDetails;
using CleanArchitecture.Domain.Modules.Aptek.Telebnames;
using CleanArchitecture.Domain.Modules.Common.Kassas;
using CleanArchitecture.Domain.Modules.Common.OdenenFaizlers;
using CleanArchitecture.Domain.Modules.Common.PasientLogs;
using CleanArchitecture.Domain.Modules.Common.Pasients;
using CleanArchitecture.Domain.Modules.Laboratoriya.CavabQrupus;
using CleanArchitecture.Domain.Modules.Laboratoriya.Cihazs;
using CleanArchitecture.Domain.Modules.Laboratoriya.LisNetices;
using CleanArchitecture.Domain.Modules.Laboratoriya.NumuneDetails;
using CleanArchitecture.Domain.Modules.Laboratoriya.Numunes;
using CleanArchitecture.Domain.Modules.Laboratoriya.Parametrs;
using CleanArchitecture.Domain.Modules.Laboratoriya.Reagents;
using CleanArchitecture.Domain.Modules.Laboratoriya.Referanses;
using CleanArchitecture.Domain.Modules.Laboratoriya.Tubes;
using CleanArchitecture.Domain.Modules.Radiologiya.RadiolojiNetices;
using CleanArchitecture.Domain.Modules.Teserrufat.TMedaxils;
using CleanArchitecture.Domain.Modules.Teserrufat.TOlcuVahidis;
using CleanArchitecture.Domain.Modules.Teserrufat.TQaimes;
using CleanArchitecture.Domain.Modules.Teserrufat.TSinifs;
using CleanArchitecture.Domain.Modules.Teserrufat.TSobeMedaxils;
using CleanArchitecture.Domain.Modules.Teserrufat.TSobeMexarics;
using CleanArchitecture.Domain.Modules.Teserrufat.TSobeStocks;
using CleanArchitecture.Domain.Modules.Teserrufat.TStocks;
using CleanArchitecture.Domain.Modules.Teserrufat.TTedarukcus;
using CleanArchitecture.Domain.Modules.Teserrufat.TTelebnames;
using GenericRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace CleanArchitecture.Infrastructure.Context
{
    internal class ApplicationDbContext : IdentityDbContext<AppUser, IdentityRole<int>, int>, IUnitOfWork
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ApplicationDbContext(DbContextOptions options, IHttpContextAccessor httpContextAccessor) : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
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
        public DbSet<Faiz> Faiz { get; set; }
        public DbSet<UserScope> UserScope { get; set; }


        // ambulator module
        public DbSet<AmbulatorMuraciet> AmbulatorMuraciet { get; set; }
        public DbSet<AmbulatorXidmet> AmbulatorXidmet { get;set; }

        // aptek modula
        public DbSet<Medaxil> Medaxil { get; set; }
        public DbSet<OlcuVahidi> OlcuVahidi { get; set; }
        public DbSet<Qaime> Qaime { get; set; }
        public DbSet<Sinif> Sinif { get; set; }
        public DbSet<SobeMedaxil> SobeMedaxil { get;set; }
        public DbSet<SobeMexaric> SobeMexaric { get; set; }
        public DbSet<SobeStock> SobeStock { get; set; }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<Tedarukcu> Tedarukcu { get; set; }
        public DbSet<Telebname> Telebname { get; set; }
        public DbSet<TelebnameDetail> TelebnameDetail { get; set; }

        // common module
        public DbSet<Kassa> Kassa { get; set; }
        public DbSet<OdenenFaizler> OdenenFaizler { get; set; }
        public DbSet<Pasient> Pasient { get; set; }
        public DbSet<PasientLog> PasientLog { get; set; }

        // laboratoriya module
        public DbSet<CavabQrupu> CavabQrupu { get; set; }
        public DbSet<Cihaz> Cihaz { get; set; }
        public DbSet<LisNetice> LisNetice { get; set; }
        public DbSet<NumuneDetail> NumuneDetail { get; set; }
        public DbSet<Numune> Numune {  get; set; }
        public DbSet<Parametr> Parametr { get; set; }
        public DbSet<Reagent> Reagent { get; set; }
        public DbSet<Referans> Referans { get; set; }
        public DbSet<Tube> Tube { get; set; }

        // radiologiya module
        public DbSet<RadiolojiNetice> RadiolojiNetice { get; set; }

        // teserrufat module
        public DbSet<TMedaxil> TMedaxil { get; set; }
        public DbSet<TOlcuVahidi> TOlcuVahidi { get; set; }
        public DbSet<TQaime> TQaime { get; set; }
        public DbSet<TSinif> TSinif { get; set; }
        public DbSet<TSobeMedaxil> TSobeMedaxil { get;set; }
        public DbSet<TSobeMexaric> TSobeMexaric { get; set; }
        public DbSet<TSobeStock> TSobeStock { get; set; }
        public DbSet<TStock> TStock { get; set; }
        public DbSet<TTelebname> TTelebname { get; set; }
        public DbSet<TTedarukcu> TTedarukcu { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

        //    modelBuilder.Ignore<IdentityUserPasskey<int>>();

        //    // IdentityPasskeyData (introduced in newer Identity versions) does not define a primary key
        //    // and EF Core attempts to map it. Mark it as keyless so migrations/EF model building won't fail.
        //    modelBuilder.Entity<IdentityPasskeyData>().HasNoKey();

        //    // The application's Identity types use int as the key (AppUser : IdentityUser<int>),
        //    // so ignore the generic Identity types with int key rather than Guid.
        //    //modelBuilder.Ignore<IdentityUserClaim<int>>();
        //    //modelBuilder.Ignore<IdentityRoleClaim<int>>();
        //    //modelBuilder.Ignore<IdentityUserToken<int>>();
        //    //modelBuilder.Ignore<IdentityUserLogin<int>>();
        //    //modelBuilder.Ignore<IdentityUserRole<int>>();
        //}

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker.Entries<BaseEntity>();

            // Safe retrieval of user id using injected IHttpContextAccessor
            string? userIdString = _httpContextAccessor?.HttpContext?
                .User?
                .FindFirst(ClaimTypes.NameIdentifier)?
                .Value;

            int userId = 0; // fallback system user id (choose appropriate value)
            if (!string.IsNullOrEmpty(userIdString) && int.TryParse(userIdString, out var parsed))
            {
                userId = parsed;
            }

            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property(p => p.CreateUserId).CurrentValue = userId;
                }

                if (entry.State == EntityState.Modified)
                {
                    if (entry.Property(p => p.IsDeleted).CurrentValue == true)
                    {
                        entry.Property(p => p.DeletedDate).CurrentValue = DateTime.Now;
                        entry.Property(p => p.DeleteUserId).CurrentValue = userId;
                    }
                    else
                    {
                        entry.Property(p => p.UpdatedDate).CurrentValue = DateTime.Now;
                        entry.Property(p => p.UpdateUserId).CurrentValue = userId;
                    }
                }

                if (entry.State == EntityState.Deleted)
                {
                    throw new ArgumentException("Db'den direkt silme edə bilməzsiz");
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
