using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityPay
{
    public class LocationEntity
    {
    }

    public partial class RegionEntity
    { 
        
        public int ID {  get; set; }    
        public string Region_Code { get; set; }
        public string Region_Name { get; set; }

        
    }

    public partial class CityEntity


    { 
        public int ID { get; set; }
        public string City_Code { get; set;}
        public string City_Name { get; set;}
        public string Province_Code { get; set;}
    }

    public partial class ProvinceEntity
    { 
        public int ID { get; set;}  
        public string Province_Code { get;set;}
        public string Province_Name { get;set;}
        public string Region_Code { get; set;}
    }

    public partial class ZipCodeEntity
    {  public int ID { get; set;}
        public string Zip_Code { get; set;}
        public string Province_Code { get; set;}
    }

}
