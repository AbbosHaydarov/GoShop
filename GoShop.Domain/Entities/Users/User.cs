using GoShop.Domain.Commons;
using GoShop.Domain.Commons.Enums;

namespace GoShop.Domain.Entities.Users
{
    public class User : Auditable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
    }
}
