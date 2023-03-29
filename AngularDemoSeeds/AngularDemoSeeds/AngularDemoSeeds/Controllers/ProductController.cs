using AngularDemoSeeds.Application.InterfaceServices;
using AngularDemoSeeds.Model.DTO;
using Microsoft.AspNetCore.Mvc;

namespace AngularDemoSeeds.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> Get()
        {
            var data = await _productService.Get();
            return Ok(data);
        }
    }
}
