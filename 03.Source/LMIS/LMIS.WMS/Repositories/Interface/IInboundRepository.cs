using LMIS.WMS.Entities;

namespace LMIS.WMS.Repositories.Interface
{
    public interface IInboundRepository
    {
        Task SaveAsync(Inbound inbound);
    }
}
