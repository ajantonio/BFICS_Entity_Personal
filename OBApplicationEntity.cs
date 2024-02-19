using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityPay
{
    public partial class OBFilling
    {
        public int ID { get; set; }
        public string EmployeeNo { get; set; }
        public String OBType { get; set; }
        public DateTime OBStartDate { get; set; }
        public DateTime OBEndtDate { get; set; }
        public String OBDetails { get; set; }
        public String AppliedBy { get; set; }
        public string Remarks { get; set; }

    }

    public partial class OBFillingList
    { 
        public string EmpNumber { get; set; }
        public string EmpName { get; set; }
        public DateTime OBDateBegin { get; set; }
        public DateTime OBDateEnd { get; set; }
        public Decimal NoOfHours { get; set; }
        public string Remarks { get; set; }
        public DateTime DataChange {  get; set; }
        public DateTime DateApproved { get; set;}
        public String ApprovedBy { get; set;}
        public string ApproverName { get; set; }
        public int ID { get; set; }
    
    
    }

    public partial class OBFillingListAll
    {
        public string EmpNumber { get; set; }
        public string EmpName { get; set; }
        public DateTime OBDateBegin { get; set; }
        public DateTime OBDateEnd { get; set; }
        public Decimal NoOfHours { get; set; }
        public string Remarks { get; set; }
        public DateTime DataChange { get; set; }
        public DateTime DateApproved { get; set; }
        public String ApprovedBy { get; set; }
        public string ApproverName { get; set; }
        public string Status {  get; set; }


    }


    public partial class GetGroupList 
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
