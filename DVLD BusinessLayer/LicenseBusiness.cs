using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class LicenseBusiness
    {
        public static int GetActiveLicenseIDByPersonID(int PersonID, int LicenseClassID)
        {
            return LicensesDataAccess.GetActiveLicenseIDByPersonID(PersonID, LicenseClassID);
        }


    }
}
