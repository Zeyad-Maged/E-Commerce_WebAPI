using e_commerce_holisticfinal.Data;
using e_commerce_holisticfinal.Models;

namespace e_commerce_holisticfinal.Repositories.Product
{
    public class ProductRepo : IProductRepo
    {
        private readonly AppDbContext _context;
        public ProductRepo(AppDbContext context)
        {
            _context = context;
        }

        public void AddProduct(ProductDTO dto)
        {
            var add = new Models.Product
            {
                Name = dto.Name,
                Description = dto.Description,
                StockQuantity = dto.StockQuantity,
            };
            _context.products.Add(add);
            _context.SaveChanges();
        }
    }
}
