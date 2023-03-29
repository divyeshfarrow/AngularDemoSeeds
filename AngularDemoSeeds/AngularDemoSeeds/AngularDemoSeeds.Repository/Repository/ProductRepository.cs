using AngularDemoSeeds.EntityFrameworkCore.DataContext;
using AngularDemoSeeds.Model.DTO;
using AngularDemoSeeds.Repository.InterfaceRepository;

namespace AngularDemoSeeds.Repository.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AngularDemoSeedDbContext _angularDemoSeedDbContext;
        public ProductRepository(AngularDemoSeedDbContext angularDemoSeedDbContext)
        {
            _angularDemoSeedDbContext = angularDemoSeedDbContext;
        }

        public async Task<IEnumerable<ProductDTO>> Get()
        {
            var lstProducts = _angularDemoSeedDbContext.ProductMasters
                                                   .Where(x => x.IsActive == true && x.IsDeleted == false)
                                                   .Select(x => new ProductDTO
                                                   {
                                                       Id = x.Id,
                                                       ProductName = x.ProductName,
                                                       Price = x.Price,
                                                   })
                                                   .ToList();
            return lstProducts;
        }
    }
}
