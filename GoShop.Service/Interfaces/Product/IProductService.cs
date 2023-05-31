using GoShop.Domain.Entities.Products;
using GoShop.Domain.Entities.SoldProduct;
using GoShop.Service.DTOs.Products;
using GoShop.Service.DTOs.SoldProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GoShop.Service.Interfaces.Product
{
    public interface IProductService
    {
        ValueTask<ProductDTO> GetAsync(Expression<Func<ProductDTO, bool>> expression);

        ValueTask<ProductDTO> UpdateAsync(int id, ProductDTO productDTO);

        ValueTask<bool> DeleteAsync(int id);

        ValueTask<IEnumerable<ProductDTO>> GetAllAsync(
            Expression<Func<Products, bool>> expression = null);

        ValueTask<ProductDTO> GetAsync(Expression<Func<Products, bool>> expression);

        //ValueTask<SoldProductDTO> CreateAsync(SoldProductDTO soldProductDTO);
        //
        //ValueTask<SoldProductDTO> UpdateAsync(int id, SoldProductDTO soldProductDTO);
        //
        //ValueTask<bool> DeleteAsync(int id);
        //
        //ValueTask<IEnumerable<SoldProductDTO>> GetAllAsync(
        //    Expression<Func<SoldProduct, bool>> expression = null);
        //
        //ValueTask<SoldProductDTO> GetAsync(Expression<Func<SoldProduct, bool>> expression);
    }
}
