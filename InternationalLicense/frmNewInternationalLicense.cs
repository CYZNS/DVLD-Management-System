using DVLD.Models;
using DVLD_BusinessLayer;
using DVLD_Project.License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.InternationalLicense
{
    public partial class frmNewInternationalLicense : Form
    {

        ApplicationModel _Application;
        Licenses _license;
        Driver _driver;
        InternationalLicenses _InternationalLicense;
        ApplicationType applicationType;
        private int _InternationalLicenseID = -1; 

        public frmNewInternationalLicense()
        {
            InitializeComponent();
            ctrlDriverLicenseInfoWithFilter1.OnLicenseIDSearch += CtrlDriverLicenseInfoWithFilter1_OnLicenseIDSearch;
        }
        private void ResetLicenseSelectionState()
        {
            _license = null;
            _driver = null;
            _InternationalLicenseID = -1;

            btnIssue.Enabled = false;
            lkShowLicenseInfo.Enabled = false;
            lkLicenseHistory.Enabled = false;

            lblLocalLicenseID.Text = "????";
            lblInternationalLicenseID.Text = "????";
            lblApplicationID.Text = "????";
        }
        private void CtrlDriverLicenseInfoWithFilter1_OnLicenseIDSearch(Licenses license)
        {
            ResetLicenseSelectionState();

            if (license != null) // license found!
            {
                _license = license;

                if (license.IsActive == false)
                {
                    MessageBox.Show("This license is not active and cannot be used for international license application.", "License Not Active", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (license.ExpirationDate < DateTime.Now)
                {
                    MessageBox.Show("This license is expired and cannot be used for international license application.", "License Expired", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (license.LicenseClassID != 3)
                {
                    MessageBox.Show("This license is not a class 3 license and cannot be used for international license application.", "License Not Class 3", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // if all checks passed, this means this local license is valid for international license application

                lblLocalLicenseID.Text = license.LicenseID.ToString();
                _driver = DriverBusiness.FindDriverByDriverID(_license.DriverID);

                // check if the driver is already having an international license
                int internationalLicneseID = InternationalLicenseBusiness.GetActiveInternationalLicenseIDByDriverID(_driver.DriverID);
                if (internationalLicneseID != -1)
                {
                    MessageBox.Show($"This driver already has an international license with ID {internationalLicneseID}. Cannot issue another one.", "Driver Already Has International License", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _InternationalLicenseID = internationalLicneseID; // store the existing international license ID to show its information 
                    lkLicenseHistory.Enabled = true; 
                    lkShowLicenseInfo.Enabled = true;
                    return;
                }

                btnIssue.Enabled = true;
            }
            
        }
        private void InitializeAndSetupApplicationModel()
        {
            _Application = new ApplicationModel();

            // fill basic application information
            _Application.ApplicationDate = DateTime.Now;
            _Application.applicationType = applicationType;
            _Application.ApplicationTypeID = applicationType.ApplicationID;
            _Application.ApplicationStatus = 3;
            _Application.LastStatusDate = DateTime.Now;
            _Application.PaidFees = applicationType.ApplicationFees;
            _Application.UserID = clsGlobalSettings.currentUser.UserID;
            _Application.PersonID = _driver.PersonID;
        }
        private void InitializeAndSetupInternationLicense()
        {
            _InternationalLicense = new InternationalLicenses();
            // it will take the applicationID after the application is saved to the database
            _InternationalLicense.DriverID = _driver.DriverID;
            _InternationalLicense.IssueDate = DateTime.Now;
            _InternationalLicense.ExpirationDate = DateTime.Now.AddYears(1);
            _InternationalLicense.LocalLicenseID = _license.LicenseID;
            _InternationalLicense.IsActive = true;
            _InternationalLicense.UserID = clsGlobalSettings.currentUser.UserID;
        }
        private void SetupInternationalLicenseFormWithBasicInfo()
        {
            // fill the form with the basic information
            applicationType = ApplicationTypeBusiness.FindApplicationType(6); // 6 stands for international License application type

            lblApplicationDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblFees.Text = applicationType.ApplicationFees.ToString("C");

            lblCreatedByUser.Text = clsGlobalSettings.currentUser.UserName;
            lblIssueDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblExpirationDate.Text = DateTime.Now.AddYears(1).ToString("dd/MM/yyyy");
        }
        private void frmNewInternationalLicense_Load(object sender, EventArgs e)
        {
            ResetLicenseSelectionState();
            SetupInternationalLicenseFormWithBasicInfo();
            
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            InitializeAndSetupApplicationModel();
            InitializeAndSetupInternationLicense();

            if (ApplicationBusiness.Save(_Application))
            {
                _InternationalLicense.ApplicationID = _Application.ApplicationID;
                if(InternationalLicenseBusiness.AddInternationalLicense(_InternationalLicense))
                {
                    MessageBox.Show("International license issued successfully.", "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblInternationalLicenseID.Text = _InternationalLicense.InternationalLicenseID.ToString();
                    lblApplicationID.Text = _Application.ApplicationID.ToString();
                    
                    _InternationalLicenseID = _InternationalLicense.InternationalLicenseID;
                    btnIssue.Enabled = false;
                    lkShowLicenseInfo.Enabled = true;
                    lkLicenseHistory.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Failed to issue international license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Failed to save application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lkShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowInternationalLicenseInfo form = new frmShowInternationalLicenseInfo(_InternationalLicenseID);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void lkLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseHistory from = new frmShowLicenseHistory(_driver.personInfo.NationalID);
            from.StartPosition = FormStartPosition.CenterScreen;
            from.ShowDialog();
        }
    }
}
