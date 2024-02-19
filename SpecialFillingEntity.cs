using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityPay
{
    public partial class SpecialFilling
    {
        public int ID { get; set; }
        public string EmployeeID { get; set; }
        public String SpecialFillingType { get; set; }
        public DateTime SFStartDate { get; set; }
        public DateTime SFEndDate { get; set; }
        public String SFDetails { get; set; }

    }

    public partial class GetMondays
    { public string dt {  get; set; } }

    public partial class GetAllEmployeeNames
    {
        public string EmployeeID { get; set; }

        public string EmployeeName {  get; set; }

    }

}
