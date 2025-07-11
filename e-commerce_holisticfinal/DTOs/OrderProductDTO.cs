using e_commerce_holisticfinal.Models;
using System.ComponentModel.DataAnnotations;

namespace e_commerce_holisticfinal.DTOs
{
    public class OrderProductDTO
    {
        [Required]
        public int TotalPrice { get; set; }
        public List<int> ProductIds { get; set; }
        //public List<ProductDTO> products { get; set; }
    }
}
