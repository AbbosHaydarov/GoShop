using GoShop.Data.DbContexts;
using GoShop.Data.IRepositories;
using GoShop.Domain.Entities.SoldProduct;

namespace GoShop.Data.Repositories
{
    public class SoldProductRepository : GenericRepositories<Products>,ISoldProductRepository
    {
        public SoldProductRepository(GoShopDbContext dbContext) : base(dbContext)
        {
        
        }
    }
}
