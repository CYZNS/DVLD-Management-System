using DVLD.Models;
using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public static bool UpdateLicenseStatus(int licenseID, bool isActive)
        {
            return LicensesDataAccess.UpdateLicenseStatus(licenseID, isActive);
        }

        private static bool DeactivateOldAndIssueNewLicense( Licenses newLicense, int oldLicenseID)
        {
            if (newLicense == null || oldLicenseID <= 0)
                return false;

            if (!UpdateLicenseStatus(oldLicenseID, false))
                return false;

            return AddLicense(newLicense);
        }

        public static bool Renew(Licenses newLicense, int oldLicenseID)
        {
           return DeactivateOldAndIssueNewLicense(newLicense, oldLicenseID);
            
        }
        public static bool Replace(Licenses newLicense, int oldLicenseID)
        {
            newLicense.PaidFees = 0m;
            return DeactivateOldAndIssueNewLicense(newLicense, oldLicenseID);
        }

    }
}
