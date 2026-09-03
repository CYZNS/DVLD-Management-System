using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.Models
{
    public class LocalDrivingLicenseApplication :ApplicationModel
    {
        public int LocalDrivingLicenseApplicationID { get; set; }
        public int LicenseClassID { get; set; }
        //public LicenseClass licenseClass { get; set; } if I needed it I will uncomment it 

        public LocalDrivingLicenseApplication(int applicationID, int personID,People person, DateTime applicationDate,
           int applicationTypeID, ApplicationType applicationType, int applicationStatus,
           DateTime lastStatusDate, decimal paidFees, int userID,int localDrivingLicenseApplicationID,
            int licenseClassID) 
            : base(applicationID,personID,person,applicationDate,applicationTypeID,applicationType,applicationStatus,lastStatusDate,paidFees,userID)
        {
            
            LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            LicenseClassID = licenseClassID;
        }

        public LocalDrivingLicenseApplication(ApplicationModel application, int localDrivingLicenseApplicationID,
           int licenseClassID)
           : base(application.ApplicationID, application.PersonID, application.Person, application.ApplicationDate, application.ApplicationTypeID, application.applicationType, application.ApplicationStatus, application.LastStatusDate, application.PaidFees, application.UserID)
        {

            LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            LicenseClassID = licenseClassID;
        }
        public LocalDrivingLicenseApplication(ApplicationModel application,int licenseClassID)
           : base(application.ApplicationID, application.PersonID, application.Person, application.ApplicationDate, application.ApplicationTypeID, application.applicationType, application.ApplicationStatus, application.LastStatusDate, application.PaidFees, application.UserID)
        {

            LocalDrivingLicenseApplicationID = -1;
            LicenseClassID = licenseClassID;
        }

        // if I used license class object I will uncomment this constructor

        //public LocalDrivingLicenseApplication(int applicationID, int personID, People person, DateTime applicationDate,
        //   int applicationTypeID, ApplicationType applicationType, int applicationStatus,
        //   DateTime lastStatusDate, decimal paidFees, int userID, int localDrivingLicenseApplicationID,
        //    int licenseClassID, LicenseClass licenseClass)
        //    : base(applicationID, personID, person, applicationDate, applicationTypeID, applicationType, applicationStatus, lastStatusDate, paidFees, userID)
        //{

        //    LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
        //    LicenseClassID = licenseClassID;
        //    this.licenseClass = licenseClass;
        //}



    }
}
