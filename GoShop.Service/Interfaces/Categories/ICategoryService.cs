using GoShop.Domain.Entities.Categories;
using GoShop.Domain.Entities.SoldProducts;
using GoShop.Service.DTOs.Categories;
using GoShop.Service.DTOs.ProductsMarket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GoShop.Service.Interfaces.Categories
{
    public interface ICategoryService
    {
        ValueTask<CategoryDTO> UpdateAsync(int id, CategoryDTO categoryDTO);
        
        ValueTask<bool> DeleteAsync(int id);

        ValueTask<CategoryDTO> CreateAsync(CategoryDTO categoryDTO);

        ValueTask<CategoryDTO> GetAsync(Expression<Func<Category, bool>> expression);

        ValueTask<IEnumerable<CategoryDTO>> GetAllAsync(
            Expression<Func<Category, bool>> expression = null);
    }
}
