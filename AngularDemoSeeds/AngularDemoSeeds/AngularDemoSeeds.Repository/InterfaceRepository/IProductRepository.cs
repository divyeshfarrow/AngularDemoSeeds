using AngularDemoSeeds.Model.DTO;

namespace AngularDemoSeeds.Repository.InterfaceRepository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDTO>> Get();
    }
}
