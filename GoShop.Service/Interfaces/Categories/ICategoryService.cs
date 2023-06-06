using GoShop.Domain.Entities.Categories;
using GoShop.Domain.Entities.Products;
using GoShop.Service.DTOs.Categories;
using GoShop.Service.DTOs.Products;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GoShop.Service.Interfaces.Categories
{
    public interface ICategoryService
    {
        ValueTask<CategoryDTO> GetAsync(Expression<Func<CategoryDTO, bool>> expression);

        ValueTask<CategoryDTO> UpdateAsync(int id, CategoryDTO productDTO);

        ValueTask<bool> DeleteAsync(int id);

        ValueTask<IEnumerable<CategoryDTO>> GetAllAsync(
            Expression<Func<Category, bool>> expression = null);

        ValueTask<CategoryDTO> GetAsync(Expression<Func<Category, bool>> expression);
    }
}
