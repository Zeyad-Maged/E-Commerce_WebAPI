using e_commerce_holisticfinal.Models;
using System.ComponentModel.DataAnnotations;

namespace e_commerce_holisticfinal.DTOs
{
    public class CustomerGetDTO
    {
        [Required]
        public string Name { get; set; }
        [Phone]
        public string Contact { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public int ShoppingCartId { get; set; }
        public ShoppingCartDTO ShoppingCart { get; set; }
        public List<CustomerOrderProductDTO> orders { get; set; }
    }
}
