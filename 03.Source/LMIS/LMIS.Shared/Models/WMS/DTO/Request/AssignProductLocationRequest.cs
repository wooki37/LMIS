﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMIS.Shared.Models.WMS.DTO.Request
{
    public class AssignProductLocationRequest
    {
        public string ProductID { get; set; }
        public string RackID { get; set; }
    }
}
