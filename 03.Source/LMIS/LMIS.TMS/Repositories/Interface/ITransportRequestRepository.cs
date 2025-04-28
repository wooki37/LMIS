using LMIS.TMS.Entities;

namespace LMIS.TMS.Repositories.Interface
{
    public interface ITransportRequestRepository
    {
        Task SaveAsync(TransportRequest request);
    }
}
