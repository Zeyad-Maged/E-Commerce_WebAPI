using e_commerce_holisticfinal.Models;
using Microsoft.EntityFrameworkCore;

namespace e_commerce_holisticfinal.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<ShoppingCart> shoppingCarts { get; set; }
    }
}
