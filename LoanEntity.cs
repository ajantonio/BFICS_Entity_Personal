using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityPay
{

    public partial class LoanEntity
    {
        public int ID { get; set; }
        public string LoanType { get; set; }
        public string LoanDescription { get; set; }
        public string GLAccountNo { get; set; }
        public string GLAccountType { get; set; }
    }

    public partial class LoanScheduleEntity
    {
        public int ID { get; set; }
        public DateTime DeductionStart { get; set; }
        public DateTime DeductionEnd { get; set; }

        public String EmployeeNo { get; set; }
        public String EmployeeName { get; set; }

        public Decimal PeriodDeduct { get; set; }
        public Decimal LoanAmount { get; set; }
        public Decimal TotalDeduct { get; set; }
        public String LoanType { get; set; }
        public String LoanDescription { get; set; }
        public Decimal Balance { get; set; }

        public DateTime LoanDate { get; set; }
    }


    public partial class LoanScheduleDetailsEntity
    { 
        public int ID { get; set; }
        public string LoanType { get; set;}
        public string LoanDescription { get; set; }
        public String EmployeeNo { get; set;}
        public string EmployeeName { get; set; }
        public DateTime DateOfDeduction { get; set; }
        public Decimal AmountOfDeduction { get; set;}
        public int Status { get; set; }
        public int LoanScheduleID { get; set; }

    } 

}
