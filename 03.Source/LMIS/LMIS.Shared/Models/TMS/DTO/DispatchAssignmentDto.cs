using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMIS.Shared.Models.TMS.DTO
{
    public class DispatchAssignmentDto
    {
        public string AssignmentID { get; set; }
        public string TransportRequestID { get; set; }
        public string VehicleID { get; set; }
        public string DriverID { get; set; }
        public string AssignmentStatus { get; set; } // Assigned, In-Transit, Completed, Cancelled
        public string AssignmentStrategy { get; set; } // Manual, Automatic
        public DateTime DispatchTime { get; set; }
    }
}
