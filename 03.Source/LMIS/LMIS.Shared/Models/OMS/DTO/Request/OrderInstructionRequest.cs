using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMIS.Shared.Models.OMS.DTO.Request
{
    public class OrderInstructionRequest
    {
        public string InstructionType { get; set; } // e.g., "Cancel", "Modify"
        public DateTime ExecuteAt { get; set; }
    }
}
