using GoShop.Domain.Commons;
using GoShop.Domain.Entities.Markets;
using GoShop.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoShop.Domain.Entities.SoldProducts
{
    public class ProductMarket : Auditable
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        
        public int MarketId { get; set; }
        public Market Market { get; set; }
    }
}
