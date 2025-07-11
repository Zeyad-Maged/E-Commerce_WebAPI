using System.ComponentModel.DataAnnotations;

namespace e_commerce_holisticfinal.Models
{
    public class OrderDTO
    {
        [Required]
        public int TotalPrice { get; set; }
    }
}
