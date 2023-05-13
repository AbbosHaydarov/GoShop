using GoShop.Data.DbContexts;
using GoShop.Data.IRepositories;
using GoShop.Domain.Entities.Markets;

namespace GoShop.Data.Repositories
{
    public class MarketRepository : GenericRepositories<Market>,IMarketRepository
    {
        public MarketRepository(GoShopDbContext dbContext) : base(dbContext) 
        { 
        
        }
    }
}
