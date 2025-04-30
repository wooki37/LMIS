using LMIS.WMS.Entities;
using LMIS.WMS.Repositories.Interface;

namespace LMIS.WMS.Repositories
{
    public class InboundRepository : IInboundRepository
    {
        public async Task SaveAsync(Inbound inbound)
        {
            await Task.CompletedTask;
            Console.WriteLine($"Inbound create for Warehouse ID {inbound.WarehouseID} saved.");
            // TODO: DB에 실제 저장하는 로직 구현
        }
    }
}
