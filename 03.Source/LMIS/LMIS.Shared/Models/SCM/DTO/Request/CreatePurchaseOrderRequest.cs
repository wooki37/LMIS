using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMIS.Shared.Models.SCM.DTO.Request
{
    public class CreatePurchaseOrderRequest
    {
        public SupplierDto SupplierID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ExpectedDelivery { get; set; }
        public List<PurchaseOrderItemDto> PurchaseOrderItems { get; set; }
    }
}
