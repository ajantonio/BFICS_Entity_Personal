using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityPay
{
    public partial class InOutFilling
    {
        public int ID { get; set; }
        public string EmployeeID { get; set; }
        public String CorectType { get; set; }
        public DateTime CorrectDate { get; set; }
        public DateTime CorrectTime { get; set; }
        public String InOutDetails { get; set; }
        public String AppliedBy { get; set; }
        public string Remarks { get; set; }
        public DateTime InOutDate { get; set; }

        public DateTime CorrectDateFrom { get; set; }

        public DateTime CorrectDateTo { get; set; }

    }

    public partial class GetGroupListInOut
    {
        public string GroupCode { get; set; }
        public string GroupName { get; set; }
        public string ShiftCode_MTF1 { get; set; }
        public string ShiftCode_MTF2 { get; set; }
        public string ShiftCode_Sat1 { get; set; }
        public string ShiftCode_Sat2 { get; set; }
        public string ShiftCode_Sun1 { get; set; }
        public string ShiftCode_Sun2 { get; set; }
        public string Mobile_Number { get; set; }
        public string Telephone_Number { get; set; }
        public string VOIP { get; set; }
    }
}
