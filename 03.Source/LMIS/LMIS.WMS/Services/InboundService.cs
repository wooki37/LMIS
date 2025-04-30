using LMIS.Shared.Models.WMS.DTO.Request;
using LMIS.WMS.Entities;
using LMIS.WMS.Repositories.Interface;
using LMIS.WMS.Services.Interface;

namespace LMIS.WMS.Services
{
    public class InboundService : IInboundService
    {
        private readonly IInboundRepository _repository;

        public InboundService(IInboundRepository repository)
        {
            _repository = repository;
        }

        public async Task<string> CreateAsync(CreateInboundRequest request)
        {
            var inbound = new Inbound
            {
                InboundID = Guid.NewGuid().ToString("N"),
                WarehouseID = request.WarehouseID,
                ShipmentNumber = request.ShipmentNumber,
                ArrivalDate = DateTime.UtcNow,
                Products = request.Products,

            };
            await _repository.SaveAsync(inbound);
            return inbound.InboundID;
        }
    }
}
