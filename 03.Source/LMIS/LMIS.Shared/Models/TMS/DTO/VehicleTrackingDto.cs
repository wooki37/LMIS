using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMIS.Shared.Models.TMS.DTO
{
    public class VehicleTrackingDto
    {
        public string TrackingID { get; set; }
        public string VehicleID { get; set; }
        public DateTime Timestamp { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}
