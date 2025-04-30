using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMIS.Shared.Models.WMS.DTO.Request
{
    public class CreateInboundRequest
    {
        public string ShipmentNumber { get; set; }
        public string WarehouseID { get; set; }
        public DateTime ArrivalDate { get; set; }
        public List<ProductDto> Products { get; set; } = new List<ProductDto>();
    }
}
