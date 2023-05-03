using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoShop.Domain.Commons;

namespace GoShop.Domain.Entities.ShtrixCodes
{
    public class ShtrixCode : Auditable
    {
        public string Code { get; set; }
    }
}
