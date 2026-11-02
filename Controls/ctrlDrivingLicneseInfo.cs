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
    public partial class ctrlDrivingLicneseInfo : UserControl
    {
        public Licenses LicenseLoaded { get; private set; }
        public Driver DriverLoaded { get; private set; }
        public ctrlDrivingLicneseInfo()
        {
            InitializeComponent();
        }
        private void DisplayLicense(Licenses license)
        {
            LicenseLoaded = null;

            if (license == null)
            {
                ClearLicenseInfo();
                MessageBox.Show("License not found.");
                return;
            }

            Driver driver = DriverBusiness.FindDriverByDriverID(license.DriverID);

            if (driver == null)
            {
                ClearLicenseInfo();
                MessageBox.Show("Driver information not found.");
                return;
            }

            LicenseLoaded = license;
            DriverLoaded = driver;

            fillLicenseInfo(license, driver);
        }
        private void fillLicenseInfo(Licenses license, Driver driver)
        {
            lbClassName.Text = license.licenseClass.ClassName;
            lbName.Text = driver.personInfo.FullName;
            lbLicenseID.Text = license.LicenseID.ToString();
            lbNationalNo.Text = driver.personInfo.NationalID;
            lbGender.Text = driver.personInfo.GenderName;
            lbIssueDate.Text = license.IssueDate.ToShortDateString();
            lbIssueReason.Text = license.IssueReasonAsString;
            lbNotes.Text = license.Notes;
            lbIsActive.Text = license.IsActiveAsString;
            lbDateOfBirth.Text = driver.personInfo.DateOfBirth.ToShortDateString();
            lbDriverID.Text = driver.DriverID.ToString();
            lbExpirationDate.Text = license.ExpirationDate.ToShortDateString();
            if (!string.IsNullOrEmpty(driver.personInfo.ImagePath) && System.IO.File.Exists(driver.personInfo.ImagePath))
            {
                pbPersonImage.Load(driver.personInfo.ImagePath);
            }
            else
            {
                pbPersonImage.Image = Properties.Resources.anonymous_man;

            }
            bool isDetained = DetainedLicenseBusiness.IsLicenseDetained(license.LicenseID);

            lbIsDetained.Text = (isDetained == true) ? "Yes" : "No";
        }

        public void LoadLicenseInfoByLDApplicationID(int localDrivingApplicationID)
        {
            int applicationID = LocalDrivingLicenseAppBusiness.GetBaseApplicationID(localDrivingApplicationID);

            Licenses license = LicenseBusiness.FindLicenseByApplicationID(applicationID);
            
            DisplayLicense(license);

        }
        public void ClearLicenseInfo()
        {
            LicenseLoaded = null;
            DriverLoaded = null;

            lbClassName.Text = "????";
            lbName.Text = "????";
            lbLicenseID.Text = "????";
            lbNationalNo.Text = "????";
            lbGender.Text = "????";
            lbIssueDate.Text = "????";
            lbIssueReason.Text = "????";
            lbNotes.Text = "????";
            lbIsActive.Text = "????";
            lbDateOfBirth.Text = "????";
            lbDriverID.Text = "????";
            lbExpirationDate.Text = "????";
            lbIsDetained.Text = "????";

            pbPersonImage.ImageLocation = null;
            pbPersonImage.Image = Properties.Resources.anonymous_man;
        }
        public void LoadLicenseInfoByLicenseID(int LicenseID)
        {
            Licenses license = LicenseBusiness.FindLicenseByLicenseID(LicenseID);
          
            DisplayLicense(license);

        }
    }
}
