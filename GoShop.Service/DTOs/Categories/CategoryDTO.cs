using System.ComponentModel.DataAnnotations;

namespace GoShop.Service.DTOs.Categories
{
    public class CategoryForCreationDTO
    {
        [Required]
        public string Name { get; set; }
    }
}
