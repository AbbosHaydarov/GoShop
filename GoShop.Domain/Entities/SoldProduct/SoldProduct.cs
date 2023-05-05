using GoShop.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoShop.Domain.Entities.SoldProduct
{
    public class SoldProduct
    {
        public int NumberOfSold { get; set; }
        public int ProductMarketId { get; set; }
        public DateTime SoldAt { get; set; }
        //public ProductMarket Productmarket { get; set; }
    }
}
