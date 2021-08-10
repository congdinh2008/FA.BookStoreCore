using FA.BookStore.Data.Infrastructure.BaseRepositories;
using FA.BookStore.Models;
using System.Threading.Tasks;

namespace FA.BookStore.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BookStoreDbContext _dbContext;

        public BookStoreDbContext DataContext => _dbContext;

        public UnitOfWork(BookStoreDbContext dbContext)
        {
            _dbContext = dbContext;

        }


        private IGenericRepository<Category> _categoryRepository;

        public IGenericRepository<Category> CategoryRepository =>
            _categoryRepository ?? new GenericRepository<Category>(_dbContext);

        #region Methods
        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }

        public Task<int> SaveChangesAsync()
        {
            return _dbContext.SaveChangesAsync();
        }

        public IGenericRepository<T> GenericRepository<T>() where T : BaseEntity
        {
            return new GenericRepository<T>(_dbContext);
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
        #endregion
    }
}
