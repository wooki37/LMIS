using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMIS.Shared.Models.TMS.DTO.Request
{
    public class CreateAssignmentRequest
    {
        public string TransportRequestID { get; set; } // ID of the transport request
        public string VehicleID { get; set; } // ID of the vehicle to be assigned
        public string DriverID { get; set; } // ID of the driver to be assigned
        public DateTime DispatchTime { get; set; } // Time of dispatch
    }
}
