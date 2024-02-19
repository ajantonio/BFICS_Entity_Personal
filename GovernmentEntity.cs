using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EntityPay
{
    public class GovernmentEntity
    {

        public int ID;
    }

    public partial class BIRStatusEntity
    {
        public int ID { get; set; }
        public string BIRStatus { get; set; }
    }
    public partial class PagibigEntity
    {



        public int SalaryBracket { get; set; }
        public decimal SalaryBase { get; set; }
        public decimal Percent1 { get; set; }
        public decimal Percent2 { get; set; }


    }
    
        public partial class SSSEntity
        { 
        public int ID { get; set; } 
            public int SalaryBracket { get; set; }
            public decimal SalaryRange1 { get; set; }   
            public decimal SalaryRange2 { get; set; }
            public decimal SalaryBase { get; set; }
            public decimal WISPBase { get; set; }
            public decimal TotalSalaryBase { get; set; }
            public decimal CompanySS { get; set; }
            public decimal CompanyEC { get; set; }
            public decimal CompanyWISP { get; set; }
            public decimal CompanyTotal { get; set; }
            public decimal EmployeeSS { get; set; }
            public decimal EmployeeWISP { get; set; }
            public decimal EmployeeTotal { get; set; }
            public decimal GrandTotal { get; set; }
            public string SalaryType { get; set; }
        }

        public partial class WTaxEntity
        {
            public int ID { get; set; }
            public string SalaryType { get; set; }
            public decimal SalaryRangeFrom { get; set; }
            public decimal SalaryRangeTo { get; set; }
            public decimal SalaryBase { get; set; }
            public decimal TaxRateOnExcess { get; set; }
            public decimal FixTax { get; set; }

            
        }

        public partial class BIRExemptionEntity
        { 
            public string BIRStatus { get; set; }
            public decimal TotalExemption { get; set; }
        }
    public partial class PhilHealthEntity

    { 
        public int ID { get; set; }
        public decimal SalaryRange1 { get; set; }
        public decimal SalaryRange2 { get; set; }
        public decimal SalaryBase { get; set; }
        public decimal PremiumRate { get; set; }


    }


}
