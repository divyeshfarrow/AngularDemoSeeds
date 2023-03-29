using AngularDemoSeeds.Application.InterfaceServices;
using AngularDemoSeeds.Model.DTO;
using Microsoft.AspNetCore.Mvc;

namespace AngularDemoSeeds.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderDTO>>> Get()
        {
            var data = await _orderService.Get();
            return Ok(data);
        }

        [HttpGet("{orderId}")]
        public async Task<ActionResult<OrderDetailsDTO>> GetById(int orderId)
        {
            var data = await _orderService.GetById(orderId);
            return Ok(data);
        }

        [HttpPost]
        public async Task<ActionResult> SaveOrUpdate(OrderDetailsDTO orderDetailsDTO)
        {
            await _orderService.SaveOrUpdate(orderDetailsDTO);
            return Ok();
        }
    }
}
