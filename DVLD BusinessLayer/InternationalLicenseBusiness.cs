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
    public class InternationalLicenseBusiness
    {
        public static DataTable GetAllInternationalLicensesForPersonID(int PersonID)
        {
            return InternationalLicenseDataAccess.GetAllInternationalLicensesForPersonID(PersonID);
        }
        public static DataTable GetAllInternationalLicenses()
        {
            return InternationalLicenseDataAccess.GetAllInternationalLicenses();
        }
        public static int GetActiveInternationalLicenseIDByDriverID(int DriverID)
        {
            return InternationalLicenseDataAccess.GetActiveInternationalLicenseIDByDriverID(DriverID);
        }
        public static bool AddInternationalLicense(InternationalLicenses internationalLicense)
        {
            internationalLicense.InternationalLicenseID = InternationalLicenseDataAccess.AddInternationalLicense(internationalLicense);
            return internationalLicense.InternationalLicenseID != -1;
        }
        public static InternationalLicenses FindInternationalLicenseInfoByLicenseID(int InternationallicenseID)
        {
            return InternationalLicenseDataAccess.FindInternationalLicenseInfoByLicenseID(InternationallicenseID);
        }
    }
}
