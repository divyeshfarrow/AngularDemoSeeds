using AngularDemoSeeds.Model.DTO;

namespace AngularDemoSeeds.Repository.InterfaceRepository
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<CustomerDTO>> Get();
    }
}
