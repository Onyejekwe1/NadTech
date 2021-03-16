using System;

namespace NadTech.Core.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsDeleted { get; set; }

        public BaseEntity()
        {
            DateCreated = DateTime.Now;
            DateModified = DateTime.Now;
        }
    }
}
