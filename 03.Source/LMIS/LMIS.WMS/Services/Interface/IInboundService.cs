using LMIS.Shared.Models.WMS.DTO.Request;

namespace LMIS.WMS.Services.Interface
{
    public interface IInboundService
    {
        Task<string> CreateAsync(CreateInboundRequest request);
    }
}
