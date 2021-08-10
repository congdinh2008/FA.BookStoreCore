using FA.BookStore.Data.Infrastructure;
using FA.BookStore.Models;
using FA.BookStore.Services.BaseServices;

namespace FA.BookStore.Services
{
    public class BookServices : BaseServices<Book>, IBookServices
    {
        public BookServices(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}

