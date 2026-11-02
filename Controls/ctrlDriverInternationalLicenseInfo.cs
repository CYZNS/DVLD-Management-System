using DVLD.Models;
using DVLD_BusinessLayer;
using DVLD_Project.Properties;
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
    public partial class ctrlDriverInternationalLicenseInfo : UserControl
    {
        private int _InternationalLicenseID;
        private InternationalLicenses _InternationalLicense;
        private Driver DriverInfo; // I think I should put a driver object in the international license object because the international license is related to a driver, and I need to access the driver's information when displaying the international license info.
        public ctrlDriverInternationalLicenseInfo()
        {
            InitializeComponent();
        }
        private void _LoadPersonImage()
        {
            if (DriverInfo.personInfo.Gender == 0)
            {
                pbPersonImage.Image = Properties.Resources.gender_male;
            }
            else
            {

                pbPersonImage.Image = Properties.Resources.gender_Female;

            }

            pbPersonImage.ImageLocation = null;

            if (!string.IsNullOrWhiteSpace(DriverInfo.personInfo.ImagePath))
            {
                pbPersonImage.ImageLocation = DriverInfo.personInfo.ImagePath;
            }

        }
        private void clearInternationalLicenseInfo()
        {
            _InternationalLicenseID = -1;
            _InternationalLicense = null;
            DriverInfo = null;
            lblInternationalLicenseID.Text = "????";
            lblApplicationID.Text = "????";
            lblIsActive.Text = "????";
            lblLocalLicenseID.Text = "????";
            lblFullName.Text = "????";
            lblNationalNo.Text = "????";
            lblGendor.Text = "????";
            lblDateOfBirth.Text = "????";
            lblDriverID.Text = "????";
            lblIssueDate.Text = "????";
            lblExpirationDate.Text = "????";
            pbPersonImage.ImageLocation = null;
            pbPersonImage.Image = null;

        }
        public void loadInternationalLicenseInfo(int internationalLicenseID)
        {
            _InternationalLicenseID = internationalLicenseID;
            _InternationalLicense = InternationalLicenseBusiness.FindInternationalLicenseInfoByLicenseID(_InternationalLicenseID);
            if (_InternationalLicense == null)
            {
                MessageBox.Show("International license not found.");
                clearInternationalLicenseInfo();
                return;
            }
            DriverInfo = DriverBusiness.FindDriverByDriverID(_InternationalLicense.DriverID);

            lblInternationalLicenseID.Text = _InternationalLicense.InternationalLicenseID.ToString();
            lblApplicationID.Text = _InternationalLicense.ApplicationID.ToString();
            lblIsActive.Text = _InternationalLicense.IsActive ? "Yes" : "No";
            lblLocalLicenseID.Text = _InternationalLicense.LocalLicenseID.ToString();
            lblFullName.Text = DriverInfo.personInfo.FullName;
            lblNationalNo.Text = DriverInfo.personInfo.NationalID;
            lblGendor.Text = DriverInfo.personInfo.Gender == 0 ? "Male" : "Female";
            lblDateOfBirth.Text = DriverInfo.personInfo.DateOfBirth.ToString("dd/MM/yyyy"); ;

            lblDriverID.Text = _InternationalLicense.DriverID.ToString();
            lblIssueDate.Text = _InternationalLicense.IssueDate.ToString("dd/MM/yyyy");
            lblExpirationDate.Text = _InternationalLicense.ExpirationDate.ToString("dd/MM/yyyy");
            _LoadPersonImage();
        }
    }
}
