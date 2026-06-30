using CleanArchitecture.Domain.Core;
using CleanArchitecture.Domain.Modules.Accounts.Users;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Modules.Admin.UserScopes
{
    public class UserScope : BaseEntity
    {
        public int UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public AppUser? User { get; set; }
        public string ScopeType { get; set; } = string.Empty;
        public int ScopeId { get; set; }
        public string ScopeName { get; set; } = string.Empty;
    }
}
