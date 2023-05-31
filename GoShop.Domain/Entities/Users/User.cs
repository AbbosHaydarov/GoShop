using GoShop.Domain.Commons;
using GoShop.Domain.Entities.Markets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoShop.Domain.Entities.Users
{
    public class User : Auditable
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public int MarketId { get; set; }
        public Market Market { get; set; }
    }
}
