using e_commerce_holisticfinal.Data;
using e_commerce_holisticfinal.DTOs;
using e_commerce_holisticfinal.Models;
using Microsoft.EntityFrameworkCore;

namespace e_commerce_holisticfinal.Repositories.Order
{
    public class OrderRepo : IOrderRepo
    {
        private readonly AppDbContext _context;
        public OrderRepo(AppDbContext context)
        {
            _context = context;
        }
        public void AddOrder(OrderCustomerProductDTO dto)
        {
            var search = _context.customers.FirstOrDefault(i => i.Id == dto.CustomerId);
            var add = new Models.Order
            {
                TotalPrice = dto.TotalPrice,
                Products = dto.products.Select(i => new Models.Product
                {
                    Name = i.Name,
                    Description = i.Description,
                    StockQuantity = i.StockQuantity,
                }).ToList(),
                Customer = search,
            };
            _context.orders.Add(add);
            _context.SaveChanges();
        }

        public bool DeleteOrder(int id)
        {
            var search = _context.orders.FirstOrDefault(i => i.Id == id);
            if (search == null)
            {
                return false;
            }
            _context.orders.Remove(search);
            _context.SaveChanges();
            return true;
        }

        public List<OrderGetDTO> GetAllOrders()
        {
            var lis = _context.orders
                .Include(x => x.Customer)
                .Include(y => y.Products)
                .Select(i => new OrderGetDTO
                {
                    TotalPrice = i.TotalPrice,
                    customer = new CustomerBasicDTO
                    {
                        Name = i.Customer.Name,
                        Email = i.Customer.Email,
                        Contact = i.Customer.Contact,
                    },
                    products = _context.products.Select(z => new ProductDTO
                    {
                        Name = z.Name,
                        Description = z.Description,
                        StockQuantity = z.StockQuantity,
                    }).ToList(),
                }).ToList();
            if (lis == null)
            {
                return null;
            }
            return lis;
        }

        public bool UpdateOrder(OrderProductDTO dto, int OrderId)
        {
            var order = _context.orders.Include(i => i.Products).FirstOrDefault(x => x.Id == OrderId);
            if (order == null)
            {
                return false;
            }
            order.TotalPrice = dto.TotalPrice;

            var products = _context.products.Where(i => dto.ProductIds.Contains(i.Id)).ToList();

            order.Products.Clear();
            foreach(var pro in products)
            {
                order.Products.Add(pro);
            }

            _context.SaveChanges();
            return true;
        }
    }
}
