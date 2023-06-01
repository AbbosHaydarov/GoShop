using GoShop.Domain.Commons;
using GoShop.Domain.Entities.Markets;

namespace GoShop.Domain.Entities.SoldProduct
{
    public class SoldProduct : Auditable
    {
        public int NumberOfSold { get; set; }
        public DateTime SoldAt { get; set; }

        public int MarketId { get; set; }
        public Market Market { get; set; }
    }
}
