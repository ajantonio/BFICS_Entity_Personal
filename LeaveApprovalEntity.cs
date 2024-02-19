using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityPay
{
    public partial class LeaveFillingApproval
    {
        public int ID { get; set; }
        public string EmployeeNo { get; set; }
        public String LeaveType { get; set; }
        public DateTime LeaveStartDate { get; set; }
        public DateTime LeaveEndDate { get; set; }
        public String LeaveDetails { get; set; }
        public String AppliedBy { get; set; }
        public int LeaveReason { get; set; }
        public string Remarks { get; set; }
        public DateTime LeaveToBeApproved { get; set; }

    }
}
