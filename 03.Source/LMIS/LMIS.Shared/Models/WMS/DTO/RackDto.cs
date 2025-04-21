using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMIS.Shared.Models.WMS.DTO
{
    public class RackDto
    {
        public string RackID { get; set; }
        public WarehouseDto WarehouseID { get; set; }
        public string RackCode { get; set; }
        public string Description { get; set; }
    }
}
