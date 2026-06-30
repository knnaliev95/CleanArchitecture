using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Modules.Accounts.Users
{
    public class AppUser : IdentityUser<int>
    {
        public string Ad {  get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int? CreateUserId { get; set; }
        [ForeignKey(nameof(CreateUserId))]
        public AppUser? CreateUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdateUserId { get; set; }
        [ForeignKey(nameof(UpdateUserId))]
        public AppUser? UpdateUser { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? DeleteUserId { get; set; }
        [ForeignKey(nameof(DeleteUserId))]
        public AppUser? DeleteUser { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
