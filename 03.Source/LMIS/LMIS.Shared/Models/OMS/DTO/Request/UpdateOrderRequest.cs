using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMIS.Shared.Models.OMS.DTO.Request
{
    public class UpdateOrderRequest
    {
        public List<OrderItemDto> OrderItems { get; set; } = new List<OrderItemDto>();
        public string? OrderStatus { get; set; }
    }
}
