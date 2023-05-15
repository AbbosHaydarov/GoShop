using GoShop.Data.DbContexts;
using GoShop.Data.IRepositories;
using GoShop.Domain.Entities.ShtrixCodes;

namespace GoShop.Data.Repositories
{
    public class ShtrixCodeRepository : GenericRepositories<ShtrixCode>,IShtrixCodeRepository
    {
        public ShtrixCodeRepository(GoShopDbContext dbContext) : base(dbContext) 
        {
        
        }
    }
}
