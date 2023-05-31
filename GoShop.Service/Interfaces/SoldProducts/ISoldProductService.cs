using System.Linq.Expressions;
using GoShop.Domain.Entities.SoldProduct;
using GoShop.Service.DTOs.SoldProducts;

namespace GoShop.Service.Interfaces.SoldProducts
{
    public interface ISoldProductService
    {
        ValueTask<SoldProductDTO> CreateAsync(SoldProductDTO soldProductDTO);

        ValueTask<SoldProductDTO> UpdateAsync(int id, SoldProductDTO soldProductDTO);

        ValueTask<bool> DeleteAsync(int id);

        ValueTask<IEnumerable<SoldProductDTO>> GetAllAsync(
            Expression<Func<Domain.Entities.SoldProduct.Product, bool>> expression = null);

        ValueTask<SoldProductDTO> GetAsync(Expression<Func<Domain.Entities.SoldProduct.Product, bool>> expression);
    }
}
