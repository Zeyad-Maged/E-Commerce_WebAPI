using System.ComponentModel.DataAnnotations;

namespace e_commerce_holisticfinal.DTOs
{
    public class CustomerBasicDTO
    {
        [Required]
        public string Name { get; set; }
        [Phone]
        public string Contact { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}
