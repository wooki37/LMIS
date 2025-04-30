using LMIS.Shared.Models.WMS.DTO;
using RabbitMQ.Client.Exceptions;

namespace LMIS.WMS.Entities
{
    public class Inbound
    {
        public string InboundID { get; set; } = Guid.NewGuid().ToString("N");
        public string WarehouseID { get; set; } = Guid.NewGuid().ToString("N");
        public string? ShipmentNumber { get; set; }
        public string? InboundStatus { get; set; } = "Pending";
        public DateTime ArrivalDate { get; set; }
        public List<ProductDto> Products { get; set; } = new List<ProductDto>();

    }
}
