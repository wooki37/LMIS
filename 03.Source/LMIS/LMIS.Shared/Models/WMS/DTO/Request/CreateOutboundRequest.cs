using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMIS.Shared.Models.WMS.DTO.Request
{
    public class CreateOutboundRequest
    {
        public string WarehouseID { get; set; }
        public string OrderReference { get; set; }
        public DateTime DepartureDate { get; set; }
    }
}
