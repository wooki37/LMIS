using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMIS.Shared.Models.TMS.DTO
{
    public class VehicleDto
    {
        public string VehicleID { get; set; }
        public string LicensePlate { get; set; }
        public string Type { get; set; }
        public decimal Capacity { get; set; }
    }
}
