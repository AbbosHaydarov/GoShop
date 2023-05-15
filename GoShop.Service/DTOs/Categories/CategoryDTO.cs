using System.ComponentModel.DataAnnotations;

namespace GoShop.Service.DTOs.Categories
{
    public class CategoryDTO
    {
        [Required]
        public string Name { get; set; }
    }
}
