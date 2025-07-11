using System.ComponentModel.DataAnnotations;

namespace e_commerce_holisticfinal.Models
{
    public class CustomerDTO
    {
        [Required]
        public string Name { get; set; }
        [Phone]
        public string Contact { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public ShoppingCartDTO ShoppingCart { get; set; }
        public List<OrderDTO> orders { get; set; }
    }
}
