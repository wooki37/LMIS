using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMIS.Shared.Models.WMS.DTO
{
    public class InventoryDto
    {
        public string InventoryID { get; set; }
        public ProductDto ProductID { get; set; }
        public WarehouseDto WarehouseID { get; set; }
        public int Quantity { get; set; }
    }
}
