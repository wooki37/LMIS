using LMIS.Shared.Models.WMS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMIS.Shared.Models.SCM.DTO.Request
{
    public class PurchaseOrderItemRequest
    {
        public ProductDto ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
