using LMIS.Shared.Models.WMS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMIS.Shared.Models.SCM.DTO
{
    public class PurchaseSuggestionDto
    {
        public ProductDto ProductID { get; set; }
        public int CurrentStock { get; set; }      // 현재 수량
        public int Threshold { get; set; }         // 한계 물량
        public int SuggestedQuantity { get; set; } // 제안 수량
        public string Source { get; set; }            // 제안 출처(WMS or OMS)
    }
}
