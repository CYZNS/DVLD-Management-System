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
                lbDLAppID.Text = DLapplication.ApplicationID.ToString();
                LicenseClass licenseClass = LicenseClassBusiness.FindLicenseClass(DLapplication.LicenseClassID);
                lbLicenseClass.Text = licenseClass.ClassName;
                lbPassedTests.Text = passedTests.ToString();

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
