using System;
using System.Collections.Generic;
using System.Data;
using DVLD_DataAccessLayer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD.Models;

namespace DVLD_BusinessLayer
{
    public class ApplicationTypeBusiness
    {

        public static DataTable getAllApplicationTypes()
        {
            return ApplicationTypeDataAccess.GetAllApplicationTypes();
        }
        public static ApplicationType FindApplicationType(int ApplicationTypeID)
        {
            ApplicationType application = ApplicationTypeDataAccess.FindApplicationType(ApplicationTypeID);
            return (application == null) ? null : application;
        }
        public static bool UpdateApplicationType(ApplicationType applicationType)
        {
            return ApplicationTypeDataAccess.UpdateApplicationType(applicationType);
        }
    }
}
