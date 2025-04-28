using LMIS.OMS.Entities;
using LMIS.OMS.Repositories.Interface;

namespace LMIS.OMS.Repositories
{
    public class OrdersRepository : IOrdersRepository
    {
        public async Task SaveAsync(Order order)
        {
            await Task.CompletedTask;
            Console.WriteLine($"Order for Customer ID {order.CustomerID} saved.");
        }
    }
}
