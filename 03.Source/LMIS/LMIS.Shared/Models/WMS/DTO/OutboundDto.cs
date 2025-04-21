using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMIS.Shared.Models.WMS.DTO
{
    public class OutboundDto
    {
        public string OutboundID { get; set; }
        public WarehouseDto WarehouseID { get; set; }
        public string OrderReference { get; set; }
        public string Status { get; set; }
        public DateTime DepartureDate { get; set; }
    }
}
