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

namespace DVLD_Project.Controls
{
    public partial class frmIssueDrivingLicense : Form
    {
        int _localDrivingApplicationID = -1;
        int _PassedTests = 0;
        LocalDrivingLicenseApplication LDApplication;

        public frmIssueDrivingLicense(int localDrivingApplicationID,int passedTests)
        {
            InitializeComponent();
            _localDrivingApplicationID = localDrivingApplicationID;
            this._PassedTests = passedTests;
        }
        private void frmIssueDrivingLicense_Load(object sender, EventArgs e)
        {
            LDApplication = LocalDrivingLicenseAppBusiness.FindLocalDrivingApplication(_localDrivingApplicationID);
            drivingLicenseApplicationDetails1.LoadLocalDrivingLicenseApplicationDetails(LDApplication,_PassedTests);
        }
        private void btnIssue_Click(object sender, EventArgs e)
        {
            Driver driver = DriverBusiness.FindDriverByPersonID(LDApplication.PersonID);
            if(driver == null)
            {
                driver = new Driver();
                driver.PersonID = LDApplication.PersonID;
                driver.UserID = clsGlobalSettings.currentUser.UserID;
                driver.CreatedDate = DateTime.Now;

                if (DriverBusiness.AddDriver(driver))
                {
                    MessageBox.Show("Driver Added Successfuly!!");
                }
                else
                {
                    MessageBox.Show("error adding the driver");
                    return;
                }
            }

            LicenseClass licenseClass = LicenseClassBusiness.FindLicenseClass(LDApplication.LicenseClassID);
            Licenses license = new Licenses(LDApplication.ApplicationID, driver.DriverID, licenseClass, tbNotes.Text, 1, driver.UserID);
            if (LicenseBusiness.AddLicense(license))
            {
                MessageBox.Show($"License with LicenseID: {license.LicenseID} Added Successfuly!");
            }
            else
            {
                MessageBox.Show("error adding the License");
                return;
            }

            ApplicationBusiness.UpdateStatus(LDApplication.ApplicationID, 3);
            this.Close();
        }


    }
}
