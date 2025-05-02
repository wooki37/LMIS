using LMIS.SCM.Entities;

namespace LMIS.SCM.Repositories.Interface
{
    public interface IPurchaseOrderRepository
    {
        Task SaveAsync(PurchaseOrder purchaseOrder);
    }
}
