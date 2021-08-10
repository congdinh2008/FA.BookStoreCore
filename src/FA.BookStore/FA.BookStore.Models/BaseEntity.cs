using System;

namespace FA.BookStore.Models
{
    public class BaseEntity : IBaseEntity
    {
        public Guid Id { get; set; }

        public bool IsDeleted { get; set; }

        public DateTimeOffset InsertedAt { get; set; }

        public DateTimeOffset UpdatedAt { get; set; }
    }
}