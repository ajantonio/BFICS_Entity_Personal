using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityPay
{
    internal class AttendanceEntity
    {
    }

    public partial class RequestOvertimeEntity
    { public int ID {  get; set; }
      public  string EmployeeNo { get; set; }
        public string EmployeeName { get; set; }
        public DateTime RequestDateBegin { get; set; }
        public DateTime RequestDateEnd { get; set; }

        public DateTime ApproveDateBegin { get; set; }
        public DateTime ApproveDateEnd { get; set; }

        public decimal NumberOfHours { get; set; }
        public string ShiftSchedule { get; set; }
        public string Remarks { get; set; }
        public int Status { get; set; }
        public string StatusDescription { get; set; }
        public int PayrollStatus { get; set; }
        public int SpecialFiling { get; set; }
        public string RequestedBy {  get; set; }
        public DateTime RequestedDate { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime ApprovedDate { get; set;}
     


    }
}
