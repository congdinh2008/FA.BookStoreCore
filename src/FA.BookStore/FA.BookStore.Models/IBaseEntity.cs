using System;

namespace FA.BookStore.Models
{
    public interface IBaseEntity
    {
        Guid Id { get; set; }
        DateTimeOffset InsertedAt { get; set; }
        bool IsDeleted { get; set; }
        DateTimeOffset UpdatedAt { get; set; }
    }
}