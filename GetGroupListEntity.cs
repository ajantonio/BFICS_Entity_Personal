using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityPay
{
    public partial class GetGroupListEntity
    {

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
}
