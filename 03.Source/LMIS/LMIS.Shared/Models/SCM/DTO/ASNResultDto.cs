using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMIS.Shared.Models.SCM.DTO
{
    public class ASNResultDto
    {
        public PurchaseOrderDto PurchaseOrderID { get; set; }
        public bool IsSuccess { get; set; }
        public DateTime Timestamp { get; set; }
        public string? ErrorMessage { get; set; }
    }
}
