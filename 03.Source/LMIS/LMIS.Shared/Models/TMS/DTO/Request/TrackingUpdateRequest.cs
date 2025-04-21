using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMIS.Shared.Models.TMS.DTO.Request
{
    public class TrackingUpdateRequest
    {
        public string VehicleID { get; set; } // ID of the vehicle being tracked
        public DateTime Timestamp { get; set; } // Time of the tracking update
        public decimal Latitude { get; set; } // Latitude of the vehicle's location
        public decimal Longitude { get; set; } // Longitude of the vehicle's location
    }
}
