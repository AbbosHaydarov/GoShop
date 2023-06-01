using GoShop.Service.DTOs.ShtrixCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoShop.Service.DTOs.ProductsMarket
{
    public class ProductMarketDTO
    {
        public string Name { get; set; }

        public int Number { get; set; }

        public ShtrixCodeDTO ShtrixCode { get; set; }
    }
}
