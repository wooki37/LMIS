using LMIS.Shared.Models.SCM.DTO.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMIS.Shared.Models.SCM.DTO
{
    public class ASNMessageDto
    {
        public PurchaseOrderDto PurchaseOrderID { get; set; }
        public SupplierDto SupplierID { get; set; }
        public DateTime ExpectedDelivery { get; set; }
        public List<PurchaseOrderItemRequest> PurchaseOrderItems { get; set; }
    }
}
