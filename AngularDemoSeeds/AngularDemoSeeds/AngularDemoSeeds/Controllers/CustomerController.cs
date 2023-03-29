using AngularDemoSeeds.Application.InterfaceServices;
using AngularDemoSeeds.Model.DTO;
using Microsoft.AspNetCore.Mvc;

namespace AngularDemoSeeds.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerDTO>>> Get()
        {
            var data = await _customerService.Get();
            return Ok(data);
        }
    }
}
