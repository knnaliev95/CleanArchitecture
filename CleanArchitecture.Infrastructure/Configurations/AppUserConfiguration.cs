using CleanArchitecture.Domain.Modules.Accounts.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Infrastructure.Configurations
{
    internal sealed class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder) {
            builder.HasIndex(i => i.UserName).IsUnique();
        }
    }
}
