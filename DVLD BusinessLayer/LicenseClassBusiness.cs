using DVLD.Models;
using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class LicenseClassBusiness
    {

        public static DataTable GetAllLicenseClasses()
        {
            return LicenseClassDataAccess.GetAllLicenseClasses();
        }
        public static LicenseClass FindLicenseClass(int LicenseClassID)
        {
            LicenseClass licenseClass = LicenseClassDataAccess.FindLicenseClass(LicenseClassID);
            return (licenseClass == null) ? null : licenseClass;
        }
    }
}
