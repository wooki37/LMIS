using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMIS.Shared.Models.OMS.DTO
{
    public class OrderHistoryDto
    {
        public string HistoryID { get; set; }
        public string OrderID { get; set; }
        public string Status { get; set; }
        public DateTime ChangedAt { get; set; }
        public string ChangedBy { get; set; }
    }
}
