using LMIS.TMS.Entities;
using LMIS.TMS.Repositories.Interface;

namespace LMIS.TMS.Repositories
{
    public class TransportRequestsRepository : ITransportRequestRepository
    {
        public async Task SaveAsync(TransportRequest request)
        {
            await Task.CompletedTask;
            Console.WriteLine($"Transport request for Order ID {request.OrderID} saved.");
            // TODO: DB에 실제 저장하는 로직 구현
        }
    }
}
