using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityPay
{
    public partial class CompanyEntity
    {
        public int ID { get; set; }
        public string CompanyCode { get; set; }
      public string CompanyName { get; set; }
      public string Address1 { get; set; }
      public string Address2 { get; set; }
      public string SSSNo { get; set; }
      public string TIN { get; set; }
      public string PhilhealthNo { get; set; }
    }

    public partial class DepartmentEntity
    { public int ID { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public string CompanyCode { get; set; }
    }

    public partial class UnitEntity
    {
        public int ID { get; set; }

        public string UnitCode { get; set; }
        public string UnitName { get; set; }

        public string DepartmentCode { get; set; }
        
        public string CompanyCode { get; set; }
    }

    public partial class BranchEntity
    { public int ID { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string CompanyCode { get; set; }
    }

    public partial class PositionEntity
    {   public int ID { get; set; }
        public string PositionCode { get; set; }
        public string PositionTitle { get; set; }
        public string CompanyCode { get; set;}
        public string ClassCode { get; set;}
    }

    public partial class ShiftTypeEntity
    { public int ID { get; set; }   

    public string ShiftType { get; set;}    
        public string ShiftName { get; set; }
    }

    public partial class EmployeeStatusEntity
    { public int ID { get; set; } 
        public string StatusCode { get; set; }
        public string StatusDesc { get; set; }
        public string StatusState { get; set; }
    }

    public partial class CompensationTypeEntity
    { public int ID { get; set; }
        public string CompensationType { get; set;}
        public string CompensationDesc { get; set; }   
    }


}

