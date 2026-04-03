using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Core
{
    public abstract class BaseEntityDto
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
