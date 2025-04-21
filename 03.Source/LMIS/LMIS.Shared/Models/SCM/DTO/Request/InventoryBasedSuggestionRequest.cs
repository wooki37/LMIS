using LMIS.Shared.Models.WMS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMIS.Shared.Models.SCM.DTO.Request
{
    public class InventoryBasedSuggestionRequest
    {
        public ProductDto ProductID { get; set; }
        public int CurrentStock { get; set; }
        public int MinimumStock { get; set; }
        public WarehouseDto? WarehouseID { get; set; }
    }
}
