using e_commerce_holisticfinal.Models;
using System.ComponentModel.DataAnnotations;

namespace e_commerce_holisticfinal.DTOs
{
    public class OrderGetDTO
    {
        [Required]
        public int TotalPrice { get; set; }
        public CustomerBasicDTO customer { get; set; }
        public List<ProductDTO> products { get; set; }
    }
}
