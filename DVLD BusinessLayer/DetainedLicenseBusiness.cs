using DVLD.Models;
using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class DetainedLicenseBusiness
    {
        public static bool IsLicenseDetained(int licenseID)
        {
            return DetainedLicenseDataAccess.IsLicenseDetained(licenseID)!=-1;
        }
        public static int IsLicenseDetainedWithReturnDetainID(int licenseID)
        {
            return DetainedLicenseDataAccess.IsLicenseDetained(licenseID);
        }
        public static bool DetainLicense(DetainedLicense license)
        {
            license.DetainID = DetainedLicenseDataAccess.DetainLicense(license);
            return license.DetainID != -1;
        }
        public static DetainedLicense FindDetainedLicense(int DetainedID)
        {
            return DetainedLicenseDataAccess.FindDetainedLicense(DetainedID);
        }
        public static bool ReleaseDetainedLicense(int detainedID, int ReleasedByUserID, int ReleaseApplicationID)
        {
            return DetainedLicenseDataAccess.ReleaseDetainedLicense(detainedID,ReleasedByUserID,ReleaseApplicationID);
        }
        public static DataTable GetAllDetainedLicenses()
        {
            return DetainedLicenseDataAccess.GetAllDetainedLicenses();
        }
    }
}
