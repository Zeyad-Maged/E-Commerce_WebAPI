using e_commerce_holisticfinal.DTOs;
using e_commerce_holisticfinal.Repositories.Customer;
using e_commerce_holisticfinal.Repositories.Order;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace e_commerce_holisticfinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepo _repo;
        public OrderController(IOrderRepo repo)
        {
            _repo = repo;
        }
        [HttpGet("GetOrders")]
        public IActionResult GetOrders()
        {
            var lis = _repo.GetAllOrders();
            return Ok(lis);
        }
        [HttpPost("AddOrder")]
        public IActionResult AddOrder(OrderCustomerProductDTO dto)
        {
            if(dto == null)
            {
                return BadRequest();
            }
            _repo.AddOrder(dto);
            return Ok();
        }
        [HttpPut("UpdateOrder")]
        public IActionResult UpdateOrder(OrderProductDTO dto, int OrderId)
        {
            if (dto == null)
            {
                return NotFound();
            }
            _repo.UpdateOrder(dto, OrderId);
            return Ok();
        }
        [HttpDelete("DeleteOrder")]
        public IActionResult DeleteOrder(int OrderId)
        {
            var rep = _repo.DeleteOrder(OrderId);
            if (rep == false)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
