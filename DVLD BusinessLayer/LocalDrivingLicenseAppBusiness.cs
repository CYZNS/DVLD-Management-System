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
    public class LocalDrivingLicenseAppBusiness
    {

        public static DataTable GetAllLocalDrivingApplications()
        {
            return LocalDrivingLicenseDataAccess.GetAllLocalDrivingApplications();
        }
        public static LocalDrivingLicenseApplication FindLocalDrivingApplication(int LocalDrivingApplicationID)
        {
            LocalDrivingLicenseApplication application = LocalDrivingLicenseDataAccess.FindLocalDrivingApplication(LocalDrivingApplicationID);
            return (application == null) ? null : application;
        }
        public static bool AddNewLocalDrivingApplication(LocalDrivingLicenseApplication application)
        {
            application.LocalDrivingLicenseApplicationID = LocalDrivingLicenseDataAccess.AddNewLocalDrivingApplication(application);
            return application.LocalDrivingLicenseApplicationID != -1;
        }

        public static bool UpdateLocalDrivingApplication(LocalDrivingLicenseApplication application)
        {
            return LocalDrivingLicenseDataAccess.UpdateLocalDrivingApplication(application);
        }

        public static bool save(LocalDrivingLicenseApplication application)
        {
            if(application.LocalDrivingLicenseApplicationID==-1)
            {
                return AddNewLocalDrivingApplication(application);
            }
            else
            {
                return UpdateLocalDrivingApplication(application);
            }
        }

    }
}
