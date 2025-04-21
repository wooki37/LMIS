using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMIS.Shared.Models.SCM.DTO.Request
{
    public class SupplierRequest
    {
        public SupplierDto SupplierID { get; set; }
        public string SupplierName { get; set;; }
        public string SupplierContact { get; set; }
        public string SupplierAddress { get; set; }
    }
}
