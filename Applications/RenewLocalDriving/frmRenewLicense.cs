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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Project.RenewLocalDriving
{
    public partial class frmRenewLicense : Form
    {
        private ApplicationType applicationType;
        private int _OldLicenseID;
        private LicenseClass licenseClass;
        private int _RenewedLicenseID = -1;

        public frmRenewLicense()
        {
            InitializeComponent();
            ctrlDriverLicenseInfoWithFilter1.OnLicenseIDSearch += CtrlDriverLicenseInfoWithFilter1_OnLicenseIDSearch;
        }
        private void CtrlDriverLicenseInfoWithFilter1_OnLicenseIDSearch(Licenses license)
        {
            ResetLicenseSelectionState();
            if(license!=null)
            {
               
                licenseClass = license.licenseClass;
                _OldLicenseID = license.LicenseID;
                lblLocalLicenseID.Text = _OldLicenseID.ToString();
                int licenseValidityYears = licenseClass.DefaultValidityLength;
                lblExpirationDate.Text = DateTime.Now.AddYears(licenseValidityYears).ToString("dd/MM/yyyy");
                lbLicenseFees.Text = licenseClass.ClassFees.ToString();
                lbTotalFees.Text = (licenseClass.ClassFees + applicationType.ApplicationFees).ToString();

                lkLicenseHistory.Enabled = true;


                if (license.IsActive == false)
                {
                    MessageBox.Show("The license is not active and cannot be used for renewal.", "License Not Active", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (license.ExpirationDate >= DateTime.Now)
                {
                    MessageBox.Show($"Selected License is not yet expired, it will expire on {license.ExpirationDate.ToString("dd/MM/yyyy")}", "License Expired", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                btnRenew.Enabled = true;
            }



        }
        private void ResetLicenseSelectionState()
        {
            _OldLicenseID = -1;
            _RenewedLicenseID = -1;
            licenseClass = null;

            btnRenew.Enabled = false;
            lkShowLicenseInfo.Enabled = false;
            lkLicenseHistory.Enabled = false;

            lblLocalLicenseID.Text = "????";
            lbRenewLicenseID.Text = "????";
            lblApplicationID.Text = "????";
        }
        private void SetupRenewLicenseApplicationFormWithBasicInfo()
        {
            // fill the form with the basic information
            applicationType = ApplicationTypeBusiness.FindApplicationType(2); 

            lblApplicationDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblApplicationFees.Text = applicationType.ApplicationFees.ToString("C");
            lblCreatedByUser.Text = clsGlobalSettings.currentUser.UserName;
            lblIssueDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void frmRenewLicense_Load(object sender, EventArgs e)
        {
            ResetLicenseSelectionState();
            SetupRenewLicenseApplicationFormWithBasicInfo();
        }
        private ApplicationModel InitializeAndSetupApplicationModel()
        {
            ApplicationModel application = new ApplicationModel();

            // fill basic application information
            application.ApplicationDate = DateTime.Now;
            application.applicationType = applicationType;
            application.ApplicationTypeID = applicationType.ApplicationID;
            application.ApplicationStatus = 3;
            application.LastStatusDate = DateTime.Now;
            application.PaidFees = applicationType.ApplicationFees;
            application.UserID = clsGlobalSettings.currentUser.UserID;
            application.PersonID = ctrlDriverLicenseInfoWithFilter1.LoadedDriver.PersonID;
            return application;
        }
        
        private void lkLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string nationalID = ctrlDriverLicenseInfoWithFilter1.LoadedDriver?.personInfo?.NationalID;

            if (string.IsNullOrWhiteSpace(nationalID))
                return;

            frmShowLicenseHistory from = new frmShowLicenseHistory(nationalID);
            from.StartPosition = FormStartPosition.CenterScreen;
            from.ShowDialog();
        }
        private void btnRenew_Click(object sender, EventArgs e)
        {
            ApplicationModel application = InitializeAndSetupApplicationModel();

            if (ApplicationBusiness.Save(application))
            {
                lblApplicationID.Text = application.ApplicationID.ToString();

                Licenses newLicense = new Licenses(
                    application.ApplicationID,
                    ctrlDriverLicenseInfoWithFilter1.LoadedDriver.DriverID,
                    licenseClass,
                    tbNotes.Text,
                    2,
                    application.UserID
                );

                if (LicenseBusiness.Renew(newLicense, _OldLicenseID))
                {
                    MessageBox.Show("License renewed successfully.");

                    lbRenewLicenseID.Text = newLicense.LicenseID.ToString();
                    _RenewedLicenseID = newLicense.LicenseID;

                    lkShowLicenseInfo.Enabled = true;
                    btnRenew.Enabled = false;
                    lkLicenseHistory.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Failed to renew the license.");
                    btnRenew.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show(
                    "Failed to create the application for license renewal.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void lkShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicense form = new frmShowLicense(_RenewedLicenseID,true); // true means show license by License ID not applicationID 
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }
    }
}
