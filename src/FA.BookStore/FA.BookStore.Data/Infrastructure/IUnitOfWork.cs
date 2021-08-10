using FA.BookStore.Data.Infrastructure.BaseRepositories;
using FA.BookStore.Models;
using System;
using System.Threading.Tasks;

namespace FA.BookStore.Data.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        BookStoreDbContext DataContext { get; }

        #region Master Data

        IGenericRepository<Category> CategoryRepository { get; }

        #endregion

        int SaveChanges();

        Task<int> SaveChangesAsync();

        IGenericRepository<T> GenericRepository<T>() where T : BaseEntity;
    }
}
