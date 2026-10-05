using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class DetainedLicenseBusiness
    {
        public static bool IsLicenseDetained(int licenseID)
        {
            return DetainedLicenseDataAccess.IsLicenseDetained(licenseID);
        }

    }
}
