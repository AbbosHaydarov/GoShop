using GoShop.Domain.Commons;
using GoShop.Domain.Entities.Categories;
using GoShop.Domain.Entities.ShtrixCodes;

namespace GoShop.Domain.Entities.Products
{
    public class Product : Auditable
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public int ShtrixCodeId { get; set; }
        public ShtrixCode ShtrixCode { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
