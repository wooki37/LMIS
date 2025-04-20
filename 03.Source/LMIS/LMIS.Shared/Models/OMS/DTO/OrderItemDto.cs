using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMIS.Shared.Models.OMS.DTO
{
    public class OrderItemDto
    {
        public string OrderItemID { get; set; }
        public string OrderID { get; set; }
        public string ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        //public decimal TotalPrice => Quantity * UnitPrice;
    }
}
