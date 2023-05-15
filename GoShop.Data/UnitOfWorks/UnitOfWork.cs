using GoShop.Data.DbContexts;
using GoShop.Data.IRepositories;
using GoShop.Data.Repositories;

namespace GoShop.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private GoShopDbContext dbContext;
        public ICategoryRepository CategoryRepository { get; }
        public IMarketRepository MarketRepository { get; }
        public IProductRepository ProductRepository { get; }
        public IShtrixCodeRepository ShtrixCodeRepository { get; }
        public ISoldProductRepository SoldProductRepository { get; }

        public UnitOfWork(GoShopDbContext dbContext)
        {
            this.dbContext = dbContext;

            CategoryRepository = new CategoryRepository(dbContext);
            MarketRepository = new MarketRepository(dbContext);
            ProductRepository = new ProductRepository(dbContext);
            ShtrixCodeRepository = new ShtrixCodeRepository(dbContext);
            SoldProductRepository = new SoldProductRepository(dbContext);
        }

        public async ValueTask CompleteAsync()
        {
            await dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            dbContext.Dispose();
        }
    }
}
