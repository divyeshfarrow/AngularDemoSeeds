using AngularDemoSeeds.EntityFrameworkCore.DataContext;
using AngularDemoSeeds.Model.DTO;
using AngularDemoSeeds.Repository.InterfaceRepository;

namespace AngularDemoSeeds.Repository.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AngularDemoSeedDbContext _angularDemoSeedDbContext;
        public CustomerRepository(AngularDemoSeedDbContext angularDemoSeedDbContext)
        {
            _angularDemoSeedDbContext = angularDemoSeedDbContext;
        }

        public async Task<IEnumerable<CustomerDTO>> Get()
        {
            var lstCustomers = _angularDemoSeedDbContext.CustomerMasters
                             .Where(x => x.IsActive == true && x.IsDeleted == false)
                             .Select(x => new CustomerDTO
                             {
                                 Id = x.Id,
                                 CustomerName = x.CustomerName,
                                 PhoneNumber = x.PhoneNumber,
                                 Address = x.Address,
                                 District = x.District,
                                 Pincode = x.Pincode
                             })
                             .ToList();
            return lstCustomers;
        }
    }
}
