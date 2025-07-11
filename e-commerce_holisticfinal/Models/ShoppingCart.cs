namespace e_commerce_holisticfinal.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public int NumberofItems { get; set; }
        public Customer customer { get; set; }
    }
}
