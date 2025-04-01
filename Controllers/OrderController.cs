using Microsoft.AspNetCore.Mvc;
using st10301625_ICE_Task_2.Models;

namespace st10301625_ICE_Task_2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly OrderService _orderService;

        public OrderController(OrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost("place")]
        public IActionResult PlaceOrder([FromBody] Order order)
        {
            _orderService.PlaceOrder(order);
            return Ok("Order placed successfully!");
        }
    }
}
