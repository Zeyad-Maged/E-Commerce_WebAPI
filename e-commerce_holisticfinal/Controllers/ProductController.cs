using e_commerce_holisticfinal.Models;
using e_commerce_holisticfinal.Repositories.Customer;
using e_commerce_holisticfinal.Repositories.Product;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace e_commerce_holisticfinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepo _repo;
        public ProductController(IProductRepo repo)
        {
            _repo = repo;
        }
        [HttpPost("AddProduct")]
        public IActionResult AddProduct(ProductDTO dto)
        {
            if (dto == null)
            {
                return BadRequest();
            }
            else 
            {
                _repo.AddProduct(dto);
                return Ok();
            }
        }
    }
}
