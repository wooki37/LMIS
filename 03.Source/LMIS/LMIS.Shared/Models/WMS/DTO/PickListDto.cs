using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMIS.Shared.Models.WMS.DTO
{
    public class PickListDto
    {
        public string PickListID { get; set; }
        public OutboundDto OutboundID { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
