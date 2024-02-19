using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityPay
{
    public class QueryEntity
    {
        public int QueryID { get; set; }
        public string QueryName { get; set; }
    }

    public class QueryResult
    {
        public string ResultReturn { get; set; }
        public string ResultOutput { get; set; }
    }
}
