using LMIS.OMS.Entities;
using LMIS.OMS.Repositories.Interface;
using LMIS.OMS.Services.Interface;
using LMIS.Shared.Models.OMS.DTO.Request;

namespace LMIS.OMS.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly IOrdersRepository _repository;

        public OrdersService(IOrdersRepository repository)
        {
            _repository = repository;
        }
        public async Task<string> CreateAsync(CreateOrderRequest request)
        {
            var order = new Order
            {
                OrderID = Guid.NewGuid().ToString("N"),
                CustomerID = request.CustomerID,
                OrderDate = DateTime.UtcNow,
                OrderStatus = request.OrderStatus,
                OrderType = request.OrderType,
                TotalAmount = request.TotalAmount,
            };
            await _repository.SaveAsync(order);

            return order.OrderID;
        }
    }
}
