using GoShop.Domain.Entities.SoldProduct;
using GoShop.Domain.Entities.SoldProducts;
using GoShop.Service.DTOs.ProductsMarket;
using GoShop.Service.DTOs.SoldProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GoShop.Service.Interfaces.IProductMarketService
{
    public interface IProductMarketService
    {
        ValueTask<ProductMarketDTO> CreateAsync(ProductMarketDTO productMarketDTO);

        ValueTask<ProductMarketDTO> UpdateAsync(int id, ProductMarketDTO productMarketDTO);

        ValueTask<bool> DeleteAsync(int id);

        ValueTask<IEnumerable<ProductMarketDTO>> GetAllAsync(
            Expression<Func<ProductMarket, bool>> expression = null);

        ValueTask<ProductMarketDTO> GetAsync(Expression<Func<ProductMarket, bool>> expression);
    }
}
