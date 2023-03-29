using AngularDemoSeeds.EntityFrameworkCore.DataContext;
using AngularDemoSeeds.EntityFrameworkCore.Entity;
using AngularDemoSeeds.Model.DTO;
using AngularDemoSeeds.Repository.InterfaceRepository;
using Microsoft.EntityFrameworkCore;

namespace AngularDemoSeeds.Repository.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AngularDemoSeedDbContext _angularDemoSeedDbContext;
        public OrderRepository(AngularDemoSeedDbContext angularDemoSeedDbContext)
        {
            _angularDemoSeedDbContext = angularDemoSeedDbContext;
        }

        public async Task<IEnumerable<OrderDTO>> Get()
        {
           var lstOrders = _angularDemoSeedDbContext.OrderMasters
                            .Include(x => x.CustomerMaster)
                            .Where(x => x.IsActive == true && x.IsDeleted == false)
                            .Select(x => new OrderDTO
                            {
                                Id = x.Id,
                                CustomerName = x.CustomerMaster.CustomerName,
                                TotalAmountofOrder = x.TotalOrderAmount,
                            })
                            .ToList();
            return lstOrders;
        }

        public async Task<OrderDetailsDTO> GetById(int orderId)
        {
            var orderDetailsDTO = _angularDemoSeedDbContext.OrderMasters
                                .Include(x => x.OrderDetailMasters)
                                .Where(x => x.Id == orderId)
                                .Select(x => new OrderDetailsDTO
                                {
                                    OrderId = x.Id,
                                    CustomerId = x.CustomerMasterId,
                                    TotalAmountofOrder = x.TotalOrderAmount,
                                    OrderDetailsProductWise = x.OrderDetailMasters
                                                               .Join(_angularDemoSeedDbContext.ProductMasters, od => od.ProductMasterId, pm => pm.Id, (od1, pm1) => new { od1, pm1 })
                                                               .Select(y => new OrderDetailsProductWiseDTO
                                                               {
                                                                   Id = y.od1.Id,
                                                                   ProductId = y.od1.ProductMasterId,
                                                                   Quantity = y.od1.Quantity,
                                                                   Price = y.pm1.Price,
                                                                   TotalAmount = y.od1.TotalAmount
                                                               }).ToList()
                                }).FirstOrDefault();
            return orderDetailsDTO;
        }

        public async Task SaveOrUpdate(OrderDetailsDTO orderDetailsDTO)
        {
            if (orderDetailsDTO.OrderId > 0)
            {
                OrderMaster orderMaster = await _angularDemoSeedDbContext.OrderMasters.FindAsync(orderDetailsDTO.OrderId);
                if (orderMaster == null)
                {
                    //return NotFound();
                }

                orderMaster.CustomerMasterId = orderDetailsDTO.CustomerId;
                orderMaster.TotalOrderAmount = orderDetailsDTO.TotalAmountofOrder;
                orderMaster.IsActive = true;
                orderMaster.IsDeleted = false;
                orderMaster.ModifiedBy = orderDetailsDTO.CustomerId;
                orderMaster.ModifiedDate = DateTime.Now;
                _angularDemoSeedDbContext.OrderMasters.Update(orderMaster);
                await _angularDemoSeedDbContext.SaveChangesAsync();

                await _angularDemoSeedDbContext.OrderDetailMasters.Where(p => p.OrderMasterId == orderDetailsDTO.OrderId).ExecuteDeleteAsync();

                var ListOrderDetails = orderDetailsDTO.OrderDetailsProductWise.ToList();
                List<OrderDetailMaster> LstorderDetailMasters =
                                                orderDetailsDTO.OrderDetailsProductWise
                                                .Select(x => new OrderDetailMaster
                                                {
                                                    OrderMasterId = orderDetailsDTO.OrderId,
                                                    ProductMasterId = x.ProductId,
                                                    Quantity = x.Quantity,
                                                    TotalAmount = x.TotalAmount
                                                })
                                                .ToList();
                await _angularDemoSeedDbContext.OrderDetailMasters.AddRangeAsync(LstorderDetailMasters);
                await _angularDemoSeedDbContext.SaveChangesAsync();
            }
            else
            {

                OrderMaster orderMaster = new OrderMaster
                {
                    CustomerMasterId = orderDetailsDTO.CustomerId,
                    TotalOrderAmount = orderDetailsDTO.TotalAmountofOrder,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedBy = orderDetailsDTO.CustomerId,
                    CreatedDate = DateTime.Now
                };
                _angularDemoSeedDbContext.OrderMasters.Add(orderMaster);
                await _angularDemoSeedDbContext.SaveChangesAsync();

                int lastInsertedId = orderMaster.Id;

                var ListOrderDetails = orderDetailsDTO.OrderDetailsProductWise.ToList();
                List<OrderDetailMaster> LstorderDetailMasters =
                                                orderDetailsDTO.OrderDetailsProductWise
                                                .Select(x => new OrderDetailMaster
                                                {
                                                    OrderMasterId = lastInsertedId,
                                                    ProductMasterId = x.ProductId,
                                                    Quantity = x.Quantity,
                                                    TotalAmount = x.TotalAmount
                                                })
                                                .ToList();
                await _angularDemoSeedDbContext.OrderDetailMasters.AddRangeAsync(LstorderDetailMasters);
                await _angularDemoSeedDbContext.SaveChangesAsync();
            }
        }
    }
}
