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
    public class LicenseBusiness
    {
        public static DataTable GetAllLicensesForPersonID(int PersonID)
        {
            return LicensesDataAccess.GetAllLicensesForPersonID(PersonID);
        }
        public static int GetActiveLicenseIDByPersonID(int PersonID, int LicenseClassID)
        {
            return LicensesDataAccess.GetActiveLicenseIDByPersonID(PersonID, LicenseClassID);
        }
        public static Licenses FindLicenseByLicenseID(int licenseID)
        {
            return LicensesDataAccess.FindLicenseByLicenseID(licenseID);
        }
        public static Licenses FindLicenseByApplicationID(int applicationID)
        {
            return LicensesDataAccess.FindLicenseByApplicationID(applicationID);
        }
        public static bool AddLicense(Licenses license)
        {
            license.LicenseID = LicensesDataAccess.AddLicense(license);
            return license.LicenseID != -1;
        }

    }
}
