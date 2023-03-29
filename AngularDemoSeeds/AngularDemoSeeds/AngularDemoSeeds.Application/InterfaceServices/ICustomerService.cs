using AngularDemoSeeds.Model.DTO;

namespace AngularDemoSeeds.Application.InterfaceServices
{
    public interface ICustomerService
    {
        Task<IEnumerable<CustomerDTO>> Get();
    }
}
