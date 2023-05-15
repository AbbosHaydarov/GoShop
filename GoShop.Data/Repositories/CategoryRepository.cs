using GoShop.Data.DbContexts;
using GoShop.Data.IRepositories;
using GoShop.Domain.Entities.Categories;

namespace GoShop.Data.Repositories
{
    public class CategoryRepository : GenericRepositories<Category>,ICategoryRepository
    {
       public CategoryRepository(GoShopDbContext dbContext):base(dbContext)
        {

        }
    }
}
