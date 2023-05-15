using GoShop.Data.DbContexts;
using GoShop.Data.IRepositories;
using GoShop.Domain.Entities.Products;

namespace GoShop.Data.Repositories
{
    public class ProductRepository : GenericRepositories<Product>,IProductRepository
    {
        public ProductRepository(GoShopDbContext dbContext) : base(dbContext) 
        {
        
        }
    }
}
