using DVLD.Models;
using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Project.Controls
{
    public partial class DrivingLicenseApplicationDetails : UserControl
    {
        public DrivingLicenseApplicationDetails()
        {
            InitializeComponent();
        }

        public void LoadLocalDrivingLicenseApplicationDetails(LocalDrivingLicenseApplication DLapplication, int passedTests)
        {
            if (DLapplication != null)
            {
                lbDLAppID.Text = DLapplication.LocalDrivingLicenseApplicationID.ToString();
                LicenseClass licenseClass = LicenseClassBusiness.FindLicenseClass(DLapplication.LicenseClassID);
                lbLicenseClass.Text = licenseClass.ClassName;
                lbPassedTests.Text = passedTests.ToString();

                // I instantiated an object because I don't have composition with ApplicationModel , so I need to create an instance of ApplicationModel using the properties of DLapplication. This is necessary because the LoadApplicationDetails method expects an ApplicationModel object as a parameter.
                ApplicationModel application = new ApplicationModel(DLapplication.ApplicationID, DLapplication.PersonID, DLapplication.Person, DLapplication.ApplicationDate, DLapplication.ApplicationTypeID, DLapplication.applicationType
               , DLapplication.ApplicationStatus, DLapplication.LastStatusDate, DLapplication.PaidFees, DLapplication.UserID);

                applicationDetailsBaiscInfo1.LoadApplicationDetails(application);
            }
            else
            {
                MessageBox.Show("Application details not found.");
            }
        }
    }
}
