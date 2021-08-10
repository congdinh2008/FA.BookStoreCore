using FA.BookStore.Data.Infrastructure;
using FA.BookStore.Models;
using FA.BookStore.Services.BaseServices;

namespace FA.BookStore.Services
{
    public class CategoryServices : BaseServices<Category>, ICategoryServices
    {
        public CategoryServices(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}

