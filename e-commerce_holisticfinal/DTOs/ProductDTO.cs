using System.ComponentModel.DataAnnotations;

namespace e_commerce_holisticfinal.Models
{
    public class ProductDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int StockQuantity { get; set; }
    }
}
