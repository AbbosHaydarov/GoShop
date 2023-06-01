using GoShop.Domain.Commons;
using GoShop.Domain.Commons.Enums;

namespace GoShop.Domain.Entities.Users
{
    public class User : Auditable
    {
        public string Email { get; set; }

        public string Password { get; set; }
        public UserRole Role { get; set; }

        public int MarketId { get; set; }
        public Market Market { get; set; }
    }
}
