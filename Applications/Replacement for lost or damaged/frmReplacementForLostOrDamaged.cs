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

namespace DVLD_Project.Applications.Replacement_for_lost_or_damaged
{
    public partial class frmReplacementForLostOrDamaged : Form
    {
        private ApplicationType applicationType;
        private Licenses _oldLicense;
        private int _ReplacedLicenseID = -1;

        public frmReplacementForLostOrDamaged()
        {
            InitializeComponent();
            ctrlDriverLicenseInfoWithFilter1.OnLicenseIDSearch += CtrlDriverLicenseInfoWithFilter1_OnLicenseIDSearch;
        }

        private void ResetLicenseSelectionState()
        {
            _ReplacedLicenseID = -1;
            _oldLicense = null;

            btnIssueReplacement.Enabled = false;
            lkShowLicenseInfo.Enabled = false;
            lkLicenseHistory.Enabled = false;

            lblLocalLicenseID.Text = "????";
            lblApplicationID.Text = "????";
            lbRenewLicenseID.Text = "????";
        }
        private void CtrlDriverLicenseInfoWithFilter1_OnLicenseIDSearch(Licenses license)
        {
            ResetLicenseSelectionState();
            if (license != null)
            {
                _oldLicense = license;
                lblLocalLicenseID.Text = _oldLicense.LicenseID.ToString();
                lkLicenseHistory.Enabled = true;
                if (license.IsActive == false)
                {
                    MessageBox.Show("The license is not active , choose an active license.", "License Not Active", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (license.ExpirationDate <= DateTime.Now)
                {
                    MessageBox.Show($"Selected License is expired.", "License Expired", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                UpdateIssueButtonState();// set s the state of the btnIssue

            }



        }
        private void UpdateIssueButtonState()
        {
            btnIssueReplacement.Enabled =
                _oldLicense != null &&
                _oldLicense.IsActive &&
                _oldLicense.ExpirationDate > DateTime.Now &&
                applicationType != null &&
                _ReplacedLicenseID == -1;
        }
        private void determineApplicationType()
        {
            if (rbLostLicense.Checked)
            {
                applicationType = ApplicationTypeBusiness.FindApplicationType(3); // Lost
            }
            else if (rbDamagedLicense.Checked)
            {
                applicationType = ApplicationTypeBusiness.FindApplicationType(4); // Damaged
            }
            if (applicationType != null)
            {
                lblApplicationFees.Text = applicationType.ApplicationFees.ToString("C");
            }
            else
            {
                lblApplicationFees.Text = "????";
            }
            UpdateIssueButtonState();
        }
        private void SetupReplaceDamagedApplicationFormWithBasicInfo()
        {
            // fill the form with the basic 
            determineApplicationType();
            lblApplicationDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblCreatedByUser.Text = clsGlobalSettings.currentUser.UserName;
        }
        private void frmReplacementForLostOrDamaged_Load(object sender, EventArgs e)
        {
            ResetLicenseSelectionState();
            SetupReplaceDamagedApplicationFormWithBasicInfo();
        }
        private ApplicationModel InitializeAndSetupApplicationModel()
        {
            ApplicationModel application = new ApplicationModel();

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
        private void btnIssueReplacement_Click(object sender, EventArgs e)
        {
            ApplicationModel application = InitializeAndSetupApplicationModel();
            if (ApplicationBusiness.Save(application))
            {
                lblApplicationID.Text = application.ApplicationID.ToString();
                int issueReason = rbLostLicense.Checked ? 3 : 4; // 3 for lost, 4 for damaged
                Licenses newLicense = new Licenses(application.ApplicationID, ctrlDriverLicenseInfoWithFilter1.LoadedDriver.DriverID, _oldLicense.licenseClass, "", issueReason, application.UserID);
                newLicense.ExpirationDate = _oldLicense.ExpirationDate; // Set the expiration date to be the same as the old license
                //newLicense.PaidFees = 0m; i will write this in business layer
                if (LicenseBusiness.Replace(newLicense, _oldLicense.LicenseID))
                {
                    _ReplacedLicenseID = newLicense.LicenseID;
                    lbRenewLicenseID.Text = _ReplacedLicenseID.ToString();
                    lkShowLicenseInfo.Enabled = true;
                    btnIssueReplacement.Enabled = false;
                    lkLicenseHistory.Enabled = true;

                    MessageBox.Show($"License replaced successfully. New License ID: {newLicense.LicenseID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                else
                {
                    btnIssueReplacement.Enabled = false;
                    MessageBox.Show(
                           "Failed to replace the license. Please refresh the license information.",
                           "Error",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Failed to create the application for license replacing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void lkShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicense form = new frmShowLicense(_ReplacedLicenseID,true); // true means show license by License ID not applicationID 
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void rbDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            determineApplicationType();
        }

        private void rbLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            determineApplicationType();

        }
    }
}
