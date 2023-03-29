using AngularDemoSeeds.Model.DTO;

namespace AngularDemoSeeds.Application.InterfaceServices
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> Get();
    }
}
