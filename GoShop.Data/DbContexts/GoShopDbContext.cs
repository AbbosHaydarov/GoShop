using GoShop.Domain.Entities.Categories;
using GoShop.Domain.Entities.Markets;
using GoShop.Domain.Entities.Products;
using GoShop.Domain.Entities.ShtrixCodes;
using GoShop.Domain.Entities.SoldProduct;
using GoShop.Domain.Entities.SoldProducts;
using GoShop.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoShop.Data.DbContexts
{
    public class GoShopDbContext : DbContext
    {
        public GoShopDbContext(DbContextOptions<GoShopDbContext> options) 
            : base(options) 
        { 
        
        }

        public virtual DbSet<Category> Categories{ get; set; }
        public virtual DbSet<Market> Markets { get; set; }
        public virtual DbSet<Domain.Entities.Products.Product> Products { get; set; }
        public virtual DbSet<ShtrixCode> ShtrixCodes { get; set; }
        public virtual DbSet<Products> SoldProduct { get; set; }
        public virtual DbSet<ProductMarket> ProductMarkets { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
