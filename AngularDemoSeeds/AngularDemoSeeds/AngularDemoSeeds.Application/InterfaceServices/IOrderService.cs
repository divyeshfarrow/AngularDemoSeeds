using AngularDemoSeeds.Model.DTO;

namespace AngularDemoSeeds.Application.InterfaceServices
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderDTO>> Get();
        Task<OrderDetailsDTO> GetById(int orderId);
        Task SaveOrUpdate(OrderDetailsDTO orderDetailsDTO);
    }
}
