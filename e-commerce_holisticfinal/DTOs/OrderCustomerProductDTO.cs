using e_commerce_holisticfinal.Models;
using System.ComponentModel.DataAnnotations;

namespace e_commerce_holisticfinal.DTOs
{
    public class OrderCustomerProductDTO
    {
        [Required]
        public int TotalPrice { get; set; }
        public int CustomerId { get; set; }
        public List<ProductDTO> products { get; set; }
    }
}
