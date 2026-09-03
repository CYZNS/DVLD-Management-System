using DVLD.Models;
using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_BusinessLayer
{
    public class ApplicationBusiness
    {
        public static DataTable getAllApplications()
        {
            return ApplicationDataAccess.GetAllApplications();
        }
        public static ApplicationModel FindApplication(int ApplicationID)
        {
            ApplicationModel application = ApplicationDataAccess.FindApplication(ApplicationID);
            return (application == null) ? null : application;
        }
        public static bool AddNewApplication(ApplicationModel application)
        {
            application.ApplicationID = ApplicationDataAccess.AddNewApplication(application);
            return application.ApplicationID != -1;
        }
        public static bool UpdateApplication(ApplicationModel application)
        {
            return ApplicationDataAccess.UpdateApplication(application);
        }
        public static bool Save(ApplicationModel application)
        {
            if (application.ApplicationID == -1)
            {
                return AddNewApplication(application);
            }
            else
            {
                return UpdateApplication(application);
            }
        }
    }
}
