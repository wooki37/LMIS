using LMIS.SCM.Entities;
using LMIS.SCM.Repositories.Interface;

namespace LMIS.SCM.Repositories
{
    public class PurchaseOrderRepository : IPurchaseOrderRepository
    {
        private static List<PurchaseOrder> purchaseOrders = new List<PurchaseOrder>();

        public Task SaveAsync(PurchaseOrder purchaseOrder)
        {
            purchaseOrders.Add(purchaseOrder);
            Console.WriteLine($"Purchase Order {purchaseOrder.PurchaseOrderID} saved.");
            return Task.CompletedTask;
        }
    }
}
