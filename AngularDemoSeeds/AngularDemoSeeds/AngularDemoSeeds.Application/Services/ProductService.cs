using AngularDemoSeeds.Application.InterfaceServices;
using AngularDemoSeeds.Model.DTO;
using AngularDemoSeeds.Repository.InterfaceRepository;

namespace AngularDemoSeeds.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<IEnumerable<ProductDTO>> Get()
        {
           return await _productRepository.Get();
        }
    }
}
