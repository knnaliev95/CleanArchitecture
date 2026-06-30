namespace CleanArchitecture.Domain.Core
{
    public abstract class BaseEntityDto
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreateUserName { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdateUserName { get; set; } 
        public DateTime? DeletedDate { get; set; }
        public string? DeletedUserName { get; set; }
        public bool IsDeleted { get; set; }
    }
}
