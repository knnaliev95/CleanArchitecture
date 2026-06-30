using CleanArchitecture.Domain.Modules.Accounts.Users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Core
{
    public abstract class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int CreateUserId { get; set; }
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