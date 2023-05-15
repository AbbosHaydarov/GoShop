using GoShop.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GoShop.Data.IRepositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
    }
}
