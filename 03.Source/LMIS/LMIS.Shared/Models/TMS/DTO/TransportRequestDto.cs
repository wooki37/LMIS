using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMIS.Shared.Models.TMS.DTO
{
    public class TransportRequestDto
    {
        public string TransportReqeustID { get; set; }
        public string PickupLocation { get; set; }
        public string DeliveryLocation { get; set; }
        public DateTime RequestDate { get; set; }
        public string Status { get; set; }
    }
}
