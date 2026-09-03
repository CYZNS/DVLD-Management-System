using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.Models
{
    public class LicenseClass
    {

        public int LicenseClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public int MinimumAge { get; set; }
        public int DefaultValidityLength { get; set; }
        public decimal ClassFees { get; set; }

      public LicenseClass(int licenseClassID , string className , string classDescription, int minimumAge,int defaultValidityLength,decimal classFess)
      {
            this.LicenseClassID = licenseClassID ;
            this.ClassName = className ;
            this.ClassDescription = classDescription ;
            this.MinimumAge = minimumAge ;
            this.DefaultValidityLength = defaultValidityLength ;
            this.ClassFees = classFess ;
      }

    }
}
