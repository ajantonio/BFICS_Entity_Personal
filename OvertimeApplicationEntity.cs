using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityPay
{
    public partial class OvertimeFilling
    {
        public int ID { get; set; }
        public String OvertimeType { get; set; }
        public DateTime OvertimeStartDate { get; set; }
        public DateTime OvertimeEndtDate { get; set; }
        public String OverTimeDetails { get; set; }
        public string EmployeeID { get; set; }
        public string Remarks { get; set; }
        public String AppliedBy { get; set; }
        public DateTime WorkDate { get; set; }
        public String Request { get; set; }
    }
}
