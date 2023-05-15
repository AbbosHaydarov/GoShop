using GoShop.Data.IRepositories;

namespace GoShop.Data.UnitOfWorks
{
    public interface IUnitOfWork
    {
        ICategoryRepository CategoryRepository { get; }
        IMarketRepository MarketRepository { get; }
        IProductRepository ProductRepository { get; }
        IShtrixCodeRepository ShtrixCodeRepository { get; }
        ISoldProductRepository SoldProductRepository { get; }
        public ValueTask CompleteAsync();
        public void Dispose();
    }
}
