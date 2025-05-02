using LMIS.SCM.Entities;
using LMIS.SCM.Repositories.Interface;
using LMIS.SCM.Services.Interface;
using LMIS.Shared.Models.SCM.DTO.Request;

namespace LMIS.SCM.Services
{
    public class PurchaseOrderService : IPurchaseOrderService
    {
        private readonly IPurchaseOrderRepository _repository;

        public PurchaseOrderService(IPurchaseOrderRepository repository)
        {
            _repository = repository;
        }

        public async Task<string> CreateAsync(CreatePurchaseOrderRequest request)
        {
            var purchaseOrder = new PurchaseOrder
            {
                PurchaseOrderID = Guid.NewGuid().ToString("N"),
                SupplierID = request.SupplierID,
                OrderDate = DateTime.UtcNow,
                ExpectedDelivery = request.ExpectedDelivery,
                PurchaseOrderItems = request.PurchaseOrderItems.Select(item => new PurchaseOrderItem
                {
                    ProductID = item.ProductID,
                    Quantity = item.Quantity,
                    UnitPrice = item.UnitPrice,
                }).ToList(),
                TotalAmount = request.PurchaseOrderItems.Sum(item => item.Quantity * item.UnitPrice),
            };
            await _repository.SaveAsync(purchaseOrder);

            return purchaseOrder.PurchaseOrderID;
        }
    }
}
