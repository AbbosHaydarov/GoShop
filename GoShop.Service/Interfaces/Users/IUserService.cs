using GoShop.Domain.Entities.Users;
using GoShop.Service.DTOs.Users;
using System.Linq.Expressions;

namespace GoShop.Service.Interfaces.Users
{
    public interface IUserService
    {
        ValueTask<IEnumerable<UserForViewDTO>> GetAllAsync(Expression<Func<User, bool>> expression = null);
        ValueTask<UserForViewDTO> GetAsync(Expression<Func<User, bool>> expression);
        ValueTask<UserForViewDTO> CreateAsync(UserForCreationDTO dto);
        ValueTask<bool> DeleteAsync(long id);
        ValueTask<UserForViewDTO> UpdateAsync(long id, UserForUpdateDTO dto);
        ValueTask<bool> ChangePasswordAsync(UserForChangePasswordDTO dto);
        ValueTask<bool> ChangeRoleAsync(long userId, byte roleId);
        Task<UserForViewDTO> GetUserInfoAsync();
    }
}
