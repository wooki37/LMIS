using LMIS.Shared.Models.TMS.DTO;

namespace LMIS.TMS.Entities
{
    public class TransportRequest
    {
        public string TransportRequestID { get; set; } = Guid.NewGuid().ToString("N");
        public string OrderID { get; set; } = Guid.NewGuid().ToString("N");
        public string? PickupLocation { get; set; }
        public string? DeliveryLocation { get; set; }
        public DateTime RequestPickupDate { get; set; }
        public string? RequestStatus { get; set; } = "Requested";
        public DispatchAssignmentDto AssignmentStrategy { get; set; } // Manual, Automatic
    }
}
