using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMIS.Shared.Models.TMS.DTO.Request
{
    public class DispatchConfirmRequest
    {
        public string AssignmentID { get; set; } // ID of the assignment to be confirmed
        public bool IsChecklistPassed { get; set; } // Indicates if the checklist has passed
        public DateTime ConfirmedAt { get; set; } // Time of confirmation
    }
}
