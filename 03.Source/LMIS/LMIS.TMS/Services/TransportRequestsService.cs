using LMIS.Shared.Models.OMS.DTO;
using LMIS.Shared.Models.TMS.DTO.Request;
using LMIS.TMS.Entities;
using LMIS.TMS.Repositories.Interface;
using LMIS.TMS.Services.Interface;

namespace LMIS.TMS.Services
{
    public class TransportRequestsService : ITransportRequestsService
    {
        private readonly ITransportRequestRepository _repository;

        public TransportRequestsService(ITransportRequestRepository repository)
        {
            _repository = repository;
        }

        public async Task<string> CreateAsync(CreateTransportRequest request)
        {
            var transportRequest = new TransportRequest
            {
                TransportRequestID = Guid.NewGuid().ToString("N"),
                OrderID = request.OrderID,
                PickupLocation = request.PickupLocation,
                DeliveryLocation = request.DeliveryLocation,
                RequestPickupDate = request.RequestPickupDate,
            };
            await _repository.SaveAsync(transportRequest);

            return transportRequest.TransportRequestID;
        }
    }
}
