using System.ComponentModel.DataAnnotations;

namespace e_commerce_holisticfinal.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public int TotalPrice { get; set; }
        public List<Product> Products { get; set; }
        public Customer Customer { get; set; }
    }
}
