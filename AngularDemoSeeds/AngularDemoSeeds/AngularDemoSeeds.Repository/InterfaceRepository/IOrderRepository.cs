using AngularDemoSeeds.Model.DTO;

namespace AngularDemoSeeds.Repository.InterfaceRepository
{
    public interface IOrderRepository
    {
        Task<IEnumerable<OrderDTO>> Get();
        Task<OrderDetailsDTO> GetById(int orderId);
        Task SaveOrUpdate(OrderDetailsDTO orderDetailsDTO);
    }
}
