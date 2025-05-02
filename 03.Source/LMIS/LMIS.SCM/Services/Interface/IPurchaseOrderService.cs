using LMIS.Shared.Models.SCM.DTO.Request;

namespace LMIS.SCM.Services.Interface
{
    public interface IPurchaseOrderService
    {
        Task<string> CreateAsync(CreatePurchaseOrderRequest request);
    }
}
