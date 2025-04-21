using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMIS.Shared.Models.TMS.DTO.Request
{
    public class CreateTransportRequest
    {
        public string OrderID { get; set; }
        public string PickupLocation { get; set; }
        public string DeliveryLocation { get; set; }
        public DateTime DesirePickupTime { get; set; }  // 원하는 픽업 시간

        public DispatchAssignmentDto AssignmentStrategy { get; set; } // Assignment strategy (Manual, Automatic)
    }
}
