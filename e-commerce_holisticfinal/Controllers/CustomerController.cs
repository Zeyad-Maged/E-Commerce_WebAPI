using e_commerce_holisticfinal.DTOs;
using e_commerce_holisticfinal.Models;
using e_commerce_holisticfinal.Repositories.Customer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace e_commerce_holisticfinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepo _repo;
        public CustomerController(ICustomerRepo repo)
        {
            _repo = repo;
        }
        [HttpPost("AddCustomer")]
        public IActionResult AddCustomer(CustomerDTO dto)
        {
            if (dto == null)
            {
                return BadRequest();
            }
            else
            {
                _repo.AddCustomer(dto);
                return Ok();
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetCustomer(int id)
        {
            var search = _repo.GetCustomer(id);
            if (search == null)
            {
                return NotFound();
            }
            return Ok(search);
        }
    }
}
