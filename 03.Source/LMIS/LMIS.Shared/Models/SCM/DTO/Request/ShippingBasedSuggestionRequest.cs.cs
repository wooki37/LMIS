using LMIS.Shared.Models.WMS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMIS.Shared.Models.SCM.DTO.Request
{
    public class ShippingBasedSuggestionRequest
    {
        public ProductDto ProductID { get; set; }
        public int RecentShippingVolume { get; set; }   // 최근 출고량
        public int AvgShippingVolume { get; set; }      // 평균 출고량
        public int SuggestedQuantity { get; set; }      // 제안 수량
        public DateTime FromDate { get; set; }         // 시작일
        public DateTime ToDate { get; set; }           // 종료일
    }
}
