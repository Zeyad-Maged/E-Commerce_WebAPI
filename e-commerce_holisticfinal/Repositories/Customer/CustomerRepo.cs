using e_commerce_holisticfinal.Data;
using e_commerce_holisticfinal.DTOs;
using e_commerce_holisticfinal.Models;
using Microsoft.EntityFrameworkCore;

namespace e_commerce_holisticfinal.Repositories.Customer
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly AppDbContext _context;
        public CustomerRepo(AppDbContext context)
        {
            _context = context;
        }

        public void AddCustomer(CustomerDTO dto)
        {
            var add = new Models.Customer
            {
                Name = dto.Name,
                Contact = dto.Contact,
                Email = dto.Email,
                ShoppingCart = new ShoppingCart
                {
                    NumberofItems = dto.ShoppingCart.NumberofItems,
                },
                orders = dto.orders.Select(i => new Models.Order
                {
                    TotalPrice = i.TotalPrice,
                }).ToList(),
            };
            _context.customers.Add(add);
            _context.SaveChanges();
        }

        public CustomerGetDTO GetCustomer(int Id)
        {
            var search = _context.customers
                .Include(y => y.ShoppingCart)
                .Include(i => i.orders)
                .ThenInclude(x => x.Products)
                .FirstOrDefault(i => i.Id == Id);
            if (search == null)
            {
                return null;
            }
            var cust = new CustomerGetDTO
            {
                Name = search.Name,
                Email = search.Email,
                Contact = search.Contact,
                orders = search.orders.Select(i => new CustomerOrderProductDTO
                {
                    TotalPrice = i.TotalPrice,
                    Products = i.Products.Select(x => new ProductDTO
                    {
                        Name = x.Name,
                        Description = x.Description,
                        StockQuantity = x.StockQuantity,
                    }).ToList(),
                }).ToList(),
                ShoppingCart = new ShoppingCartDTO
                {
                    NumberofItems = search.ShoppingCart.NumberofItems,
                },
            };
            return cust;
        }
    }
}
