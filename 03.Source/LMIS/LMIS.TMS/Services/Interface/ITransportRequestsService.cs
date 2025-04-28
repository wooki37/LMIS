using LMIS.Shared.Models.TMS.DTO.Request;

namespace LMIS.TMS.Services.Interface
{
    public interface ITransportRequestsService
    {
        Task<string> CreateAsync(CreateTransportRequest request);
    }
}
