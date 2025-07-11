using e_commerce_holisticfinal.Models;
using System.ComponentModel.DataAnnotations;

namespace e_commerce_holisticfinal.DTOs
{
    public class CustomerOrderProductDTO
    {
        [Required]
        public int TotalPrice { get; set; }
        public List<ProductDTO> Products { get; set; }
    }
}
