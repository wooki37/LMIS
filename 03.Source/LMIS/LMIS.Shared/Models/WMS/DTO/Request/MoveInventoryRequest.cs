using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMIS.Shared.Models.WMS.DTO.Request
{
    public class MoveInventoryRequest
    {
        public string InventoryID { get; set; }
        public string FromRackID { get; set; }
        public string ToRackID { get; set; }
    }
}
