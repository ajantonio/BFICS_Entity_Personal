using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityPay
{
    public partial class EmployeeProfile
    {
        public int ID { get; set; }
        public String EmployeeNo { get; set; }
        public String EmployeeName { get; set; }
        public string LastName { get; set; }
        public String FirstName { get; set; }
        public string MiddleName { get; set; }
        public string NickName { get; set; }


        public string EmployeeAdd1 { get; set; }
      public string EmployeeAdd2 { get; set; }
      public DateTime DateHired { get; set; }
      public DateTime DateOfBirth { get; set; }

      public string BIRStatus { get; set; }
      public string PagibigStatus { get; set; }




      public string EmployeeTIN { get; set; }
      public string EmployeeSSSNo { get; set; }
      public string EmployeePagIbigNo { get; set; }
      public string EmployeePhealthNo { get; set; }

      public string EmployeeTelNo { get; set; }
      public string EmployeeEmail { get; set; }
      public string EmployeeCountry { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Province { get; set; }

        public string EmployeeGender { get; set; }
      public string EmployeeDesc { get; set; }
      public string EmployeePicture { get; set; }


      public string DepartmentCode { get; set; }
      public string ModeofPay { get; set; }
      public string PinNumber { get; set; }
     
   
      public string EmployeeAddress { get; set; }

      public string ZipCode { get; set; }
      public string Nationality { get; set; }
      public string CivilStatus { get; set; }
      public string BirthPlace { get; set; }
      public string Religion { get; set; }
      public string Height { get; set; }
      public string Weight { get; set; }
      public string PersonalEmailAddress { get; set; }
      public string CompanyEmailAddress { get; set; }
      public string PersonToNotify { get; set; }
      public string ContactOfPersonToNotify { get; set; }


        public string EmployeePosition { get; set; }
        public string BankAcctNo { get; set; }
        public string AcctCode { get; set; }
        public string MonthlyPay { get; set; }
        public string StatusState { get; set; }

        public string Title { get; set; }

        public string BloodType { get; set; }
        public string Barangay { get; set; }
        public string Subdivision { get; set; }
        public string Street { get; set; }
        public string No_Bldg { get; set; }

        public string DepartmentName { get; set; }
        public string PositionTitle { get; set; }
        public string BranchName { get; set; }

    }

    public partial class EmployeeDependent
    {  
      public int ID { get; set; }
      public string EmployeeNo { get; set; }
      public string DependentName { get; set; }
      public DateTime DateOfBirthDependent { get; set; }
      public string Relationship { get; set; }
    }


    public partial class EmployeeEducation
    {
        public int ID { get; set; }
        public string EmployeeNo { get; set; }
      public string LevelOfEducation { get; set; }
      public string Course { get; set; }
      public string School { get; set; }
      public string Location { get; set; }
      public DateTime DateEducationFrom { get; set; }
      public DateTime DateEducationTo { get; set; }
    }

    public partial class EmployeePosition
    {
        public int ID { get; set; }
        public string EmployeeNo { get; set; }
      public string BankAccountNo { get; set; }
      public string CostCenterCode { get; set; }
      public string BIRStatus { get; set; }
      public string PagIbigStatusPayment { get; set; }
      public Decimal MonthlyBasicPay { get; set; }
      public string StatusCode { get; set; }
      public DateTime DateEffective { get; set; }
      public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public string UnitCode { get; set; }
        public string UnitName { get; set; }
      public string BranchCode { get; set; }
        public string BranchName { get; set; }
      public string PositionCode { get; set; }
        public string PositionTitle { get; set; }
      public string ShiftType { get; set; }
        public string ShiftName { get; set; }
      public string EmployeeStatusCode { get; set; }
        public string EmployeeStatus { get; set; }
        public string StatusDesc { get; set; }
        public string StatusState { get; set; }
      public Boolean ComputeLate { get; set; }
      public Boolean ComputeUnder { get; set; }
      public string CompensationType { get; set; }
        public string CompensationDesc { get; set; }    
      public decimal DailyBasicPay { get; set; }
       
    }

    public partial class EmployeeStatus
    {
        public int ID { get; set; }
        public string StatusCode { get; set; }
        public string StatusDesc { get; set; }
      public string StatusState { get; set; }
      public string ChangeBy { get; set; }
      public string ChangeDatetime { get; set; }
    }

    public partial class ApproverEntity
    { 
        public string ApproverNo { get; set; }
        public string ApproverName {  get; set; }
        public string EmployeeNo { get; set; }
        public int LevelOfApprover { get; set; }
        public string LevelDescription { get; set; }
        public DateTime DateEffectivity { get; set; }
        public int ApproverStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set;}

        public string UpdatedBy { get; set; }
        public  DateTime? UpdatedDate { get; set; }

    }

    public partial class RegularScheduleEntity
    { 
        public int ID { get; set; }
        public string EmployeeNo { get; set; }

        public DateTime EffectivityDate { get; set; }
        public string Day1 { get; set; }
        public string Day2 { get; set; }
        public string Day3 { get; set; }
        public string Day4 { get; set; }
        public string Day5 { get; set; }
        public string Day6 { get; set; }
        public string Day7 { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int status { get; set; }
    }

}
