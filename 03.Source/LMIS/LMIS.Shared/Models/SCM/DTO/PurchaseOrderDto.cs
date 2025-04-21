using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMIS.Shared.Models.SCM.DTO
{
    public class PurchaseOrderDto
    {
        public string PurchaseOrderID { get; set; }
        public SupplierDto SupplierID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ExpectedDelivery { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
