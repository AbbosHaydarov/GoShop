using GoShop.Domain.Entities.SoldProducts;
using GoShop.Domain.Entities.Users;
using GoShop.Service.DTOs.ProductsMarket;
using GoShop.Service.DTOs.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GoShop.Service.Interfaces.Users
{
    public interface IUserService
    {
        ValueTask<UserDTO> CreateAsync(UserDTO userDTO);

        ValueTask<UserDTO> UpdateAsync(int id, UserDTO userDTO);

        ValueTask<bool> DeleteAsync(int id);

        ValueTask<IEnumerable<UserDTO>> GetAllAsync(
            Expression<Func<User, bool>> expression = null);

        ValueTask<UserDTO> GetAsync(Expression<Func<User, bool>> expression);
    }
}
