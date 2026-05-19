using Microsoft.AspNetCore.Identity;

namespace CleanArchitecture.Domain.Modules.Accounts.Users
{
    public class AppUser : IdentityUser<int>
    {
        public string Ad {  get; set; } = string.Empty;
    }
}
