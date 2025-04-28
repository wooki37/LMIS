using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMIS.Shared.Models.OMS.DTO.Request
{
    public class CreateOrderRequest
    {
        public string CustomerID { get; set; }
        public List<OrderItemDto> OrderItems { get; set; } = new List<OrderItemDto>();
        public string OrderStatus { get; set; } = "Pending"; //Default :  Pending, Completed, Cancelled
        public string OrderType { get; set; } = "Standard"; // Default :Standard, Express
        public decimal TotalAmount { get; set; } = 0.0m; // Default : 0.0m
    }
}
