using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityPay
{
    public partial class ShiftEntity
    {
        public int ID { get; set; }
        public string ShiftType { get; set; }
        public string ShiftName { get; set; }
    }

    public partial class RequestShiftEntity
    {
        public int ID { get; set; }
        public string ShiftType { get; set; }
        public string ShiftName { get; set; }
        public string EmployeeNo { get; set; }
        public DateTime WorkDateFrom { get; set; }
        public DateTime WorkDateTo { get; set;}
        public string RequestedBy {  get; set; }    
        public DateTime RequestedDate {  get; set; }    
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }   
        public string ApprovedBy { get; set; }
        public DateTime ApprovedDate { get;set; }

        public int Status { get; set; } 
        public string StatusDescription { get; set; }
        public int PayrollStatus { get; set; }
        public string Remarks { get; set; }
        public string ApprovalRemarks { get; set; }
        public int SpecialFiling { get; set; }

    }
}
