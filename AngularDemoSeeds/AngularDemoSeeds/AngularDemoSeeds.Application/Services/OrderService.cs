using AngularDemoSeeds.Application.InterfaceServices;
using AngularDemoSeeds.Model.DTO;
using AngularDemoSeeds.Repository.InterfaceRepository;

namespace AngularDemoSeeds.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public async Task<IEnumerable<OrderDTO>> Get()
        {
            return await _orderRepository.Get();
        }

        public async Task<OrderDetailsDTO> GetById(int orderId)
        {
            return await _orderRepository.GetById(orderId);
        }

        public async Task SaveOrUpdate(OrderDetailsDTO orderDetailsDTO)
        {
            await _orderRepository.SaveOrUpdate(orderDetailsDTO);
        }
    }
}
