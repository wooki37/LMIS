using LMIS.Shared.Models.OMS.DTO.Request;

namespace LMIS.OMS.Services.Interface
{
    public interface IOrdersService
    {
        Task<string> CreateAsync(CreateOrderRequest request);
    }
}
