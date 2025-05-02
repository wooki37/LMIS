using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMIS.Shared.Models.SCM.DTO.Request
{
    public class CreateSupplierRequest
    {
        public string SupplierName { get; set; } = string.Empty;
        public string SupplierEmail { get; set; } = string.Empty;
        public string SupplierContact { get; set; } = string.Empty;
        public string SupplierAddress { get; set; } = string.Empty;
    }
}
