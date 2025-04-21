using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMIS.Shared.Models.TMS.DTO
{
    public class KpiSummaryDto
    {
        public decimal TotalDeliveries { get; set; } // Total number of deliveries
        public DateTime AgvDeliveryTime { get; set; } // Average delivery time
        public double DelayRate { get; set; } // Rate of delayed deliveries
        public decimal TotalTransportCost { get; set; } // Total cost of transport
    }
}
