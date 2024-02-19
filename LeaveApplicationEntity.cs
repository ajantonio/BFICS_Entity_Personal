using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityPay
{
    
    public partial class LeaveFilling
    {
        public int ID { get; set; }
        public string EmployeeNo { get; set; }
        public String LeaveType { get; set; }
        public DateTime LeaveStartDate { get; set; }
        public DateTime LeaveEndDate { get; set; }
        public String LeaveDetails { get; set; }
        public String AppliedBy { get; set; }
        public string LeaveReason { get; set; }
        public int Holiday { get; set; }
        public int RestDay { get; set; }
        public int LWOP { get; set; }
        public string Remarks { get; set; }
        public int SpecialFiling { get; set; }
        public int RequiredAttachment { get; set; }
        public string AttachmentLink { get; set; }  
        public int Query { get; set; }
    }

    public partial class LeaveFillingDetails
    {
        public int ID { get; set; }
        public string EmployeeNo { get; set; }
        public String LeaveType { get; set; }
        public DateTime LeaveDate { get; set; }
        public int Holiday { get; set; }
        public int Halfday { get; set; }
        public int Restday { get; set; }
        public int LWOP  { get; set; }
        public decimal NoOfHours  { get; set; }
        public int FirstHalf { get; set; }
        public int SecondHalf { get; set; }
        public String LeaveDetails { get; set; }
        public String AppliedBy { get; set; }
        public string LeaveReason { get; set; }
        public string Remarks { get; set; }
        public int Status { get; set; }
        public int SpecialFiling { get; set; }
        public decimal LeaveDebit { get; set; } 
    }
    public partial class LeaveFillingList
    {
        public int ID { get; set; }
        public string EmployeeNo { get; set; }
        public string EmployeeName {  get; set; }
        public DateTime LeaveDate { get; set; }
        public String NoOfHours { get; set; }
        public int Halfday { get; set; }
        public int FirstHalf { get; set; }
        public int SecondHalf { get; set; }
        public int Holiday { get; set; }
        public int Restday { get; set; }
        public int LWOP { get; set; }
        public int Status { get; set; } 
        public string StatusDescription { get; set; }

    }
    public partial class GetAuthLeave 
    {
        public int ID { get; set; }
        public string LeaveType { get; set; }
        public string LeaveDesc { get; set; }
    }
    public partial class GetLeaveReasons
    {
        public int ID { get; set; }
        public string LeaveType { get; set; }
        public string LeaveDesc { get; set; }
    }

}



