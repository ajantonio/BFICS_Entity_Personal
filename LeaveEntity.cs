using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace EntityPay
{
  
    public partial class LeaveEntity
    {
        public int ID { get; set; }
      public string Leave_Type { get; set; }
        public string Leave_Description { get; set; }
        public decimal Monthly_Leave_Credit { get; set; }
        public decimal Yearly_Leave_Credit { get; set; }
        public int Days_To_File { get; set; }
        public decimal Excess_Leave_Derive {  get; set; }  
        public int With_Pay {  get; set; }
        public string GLAccountNo { get; set; }
        public string GLAccountType { get; set; }

    }

    public partial class EmployeeAuthorizedLeaveEntity
    { public int ID { get; set; }

    public string EmployeeNo { get; set;}
    public string LeaveType { get; set; }
    public string LeaveDescription { get;set; }
     public DateTime DateEffective { get; set; }
     public string CreatedBy { get; set; }
     public DateTime? CreatedDate { get; set; }
     public string UpdatedBy { get; set; }
     public DateTime? UpdatedDate { get; set; }
     public decimal LeaveBalance {  get; set; }
        public decimal Credited { get; set; }
        public decimal Avail { get; set; }
        public decimal Forfeited { get; set; }
        public decimal Converted { get; set; }
    }

    public partial class EmployeeLeaveLedgerEntity
    { public int ID { get; set; }
        public string EmployeeNo { get; set; }
        public string EmployeeName { get; set; }
        public string LeaveType { get; set; }
        public string LeaveDescription { get; set; }
        public DateTime DateCredited { get; set; }
        public decimal LeaveCredited { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public decimal LeaveBalance { get; set; }
        public string Remarks { get; set; }

        
    }

    public partial class RequestLeaveEntity
    { public int ID { get; set; }
        public string EmployeeNo { get; set; }
        public string EmployeeName { get; set; }
        public string LeaveType { get; set; }
        public string LeaveDescription { get; set; }

        public DateTime RequestDateBegin { get; set; }
        public DateTime RequestDateEnd { get; set; }

        public int Status { get; set; }
        public string StatusDescription { get; set; }

        public int PayrollStatus { get; set; }
        public string PayrollStatusDescription { get; set; }
        public decimal NumberOfHours { get; set; }

        public decimal NumberOfDays { get; set; }
        public string LeaveReason { get; set; }
        public string LeaveCategory { get; set; }
        public string Remarks { get; set; }
        public int SpecialFiling { get; set; }


        public int RequiredAttachment { get; set; }
        public string AttachmentLink { get; set; }
        public string RequestedBy { get; set; }
        public DateTime RequestedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime ApprovedDate { get; set; }

    }
}
