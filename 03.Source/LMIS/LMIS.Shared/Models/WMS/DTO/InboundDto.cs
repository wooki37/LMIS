using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMIS.Shared.Models.WMS.DTO
{
    public class InboundDto
    {
        public string InboundID { get; set; }
        public WarehouseDto WarehouseID { get; set; }
        public string ShipmentNumber { get; set; }
        public string Status { get; set; }
        public DateTime ArrivalDate { get; set; }
    }
}
