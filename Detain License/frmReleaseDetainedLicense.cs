using DVLD.Models;
using DVLD_BusinessLayer;
using DVLD_Project.License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Detain_License
{
    public partial class frmReleaseDetainedLicense : Form
    {
        DetainedLicense detainedLicense;
        private ApplicationType applicationType;

        private int _DetainID = -1;

        public frmReleaseDetainedLicense()
        {
            InitializeComponent();
            ctrlDriverLicenseInfoWithFilter1.OnLicenseIDSearch += CtrlDriverLicenseInfoWithFilter1_OnLicenseIDSearch;
        }
        public frmReleaseDetainedLicense(int DetainID)
        {
            InitializeComponent();
            _DetainID = DetainID;
        }

        private void ResetLicenseSelectionState()
        {
            detainedLicense = null;
            applicationType = null;
                
            btnRelease.Enabled = false;
            lkShowLicenseInfo.Enabled = false;
            lkLicenseHistory.Enabled = false;

            lbDetainID.Text = "[???]";
            lbDetainDate.Text = "[??/??/????]";
            lbLicenseID.Text = "[???]";
            lbApplicationID.Text = "[???]";
            lbUserID.Text = "[????]";
            lbTotalFees.Text = "[???]";
            lblApplicationFees.Text = "[$$$]";
            lbFineFees.Text = "[$$$]";

        }
        private void CtrlDriverLicenseInfoWithFilter1_OnLicenseIDSearch(Licenses license)
        {
            ResetLicenseSelectionState();
            if (license!=null)
            {
                lkLicenseHistory.Enabled = true;
                lbLicenseID.Text = license.LicenseID.ToString();
                int DetainedLicenseID = DetainedLicenseBusiness.IsLicenseDetainedWithReturnDetainID(license.LicenseID);
                if (DetainedLicenseID ==-1) // if it is -1 so the license is not detained
                {
                    MessageBox.Show("Selected license is not detained,choose another one.");
                    return;
                }
                detainedLicense = DetainedLicenseBusiness.FindDetainedLicense(DetainedLicenseID);
                if(detainedLicense !=null)
                {
                    fillReleaseDetainedLicenseApplicationWithBasicInfo();
                    btnRelease.Enabled = true;
                }

                


            }
        }
        private void fillReleaseDetainedLicenseApplicationWithBasicInfo()
        {
            applicationType = ApplicationTypeBusiness.FindApplicationType(5);
            lbDetainID.Text = detainedLicense.DetainID.ToString();
            lbDetainDate.Text = detainedLicense.DetainDate.ToShortDateString();
            lbLicenseID.Text = detainedLicense.LicenseID.ToString();
            lbUserID.Text = detainedLicense.CreatedByUserID.ToString();
            decimal applicationFees = applicationType.ApplicationFees;
            decimal fineFees = detainedLicense.FineFees;
            lblApplicationFees.Text = applicationFees.ToString();
            lbFineFees.Text = fineFees.ToString();
            decimal totalFees = applicationFees + fineFees;
            lbTotalFees.Text = totalFees.ToString();

        }
        private void SetupFormForLoadedDetainID()
        {
            lkLicenseHistory.Enabled = true;
            detainedLicense = DetainedLicenseBusiness.FindDetainedLicense(_DetainID);
            
            if (detainedLicense != null)
            {
                if(detainedLicense.IsReleased == true)
                {
                    MessageBox.Show("Selected license is released you can't release it another time");
                    this.Close();
                    return;
                }
                fillReleaseDetainedLicenseApplicationWithBasicInfo();
                lbLicenseID.Text = detainedLicense.LicenseID.ToString();
                btnRelease.Enabled = true;
            }
            ctrlDriverLicenseInfoWithFilter1.LoadReadyDriverLicense(detainedLicense.LicenseID);

        }
        private void frmReleaseDetainedLicense_Load(object sender, EventArgs e)
        {
            ResetLicenseSelectionState();
            if (_DetainID != -1)
            {
                SetupFormForLoadedDetainID();
            }
        }
        private ApplicationModel InitializeAndSetupApplicationModel()
        {
            ApplicationModel application = new ApplicationModel();
            application.PersonID = ctrlDriverLicenseInfoWithFilter1.LoadedDriver.PersonID;
            application.ApplicationDate = DateTime.Now;
            application.applicationType = applicationType;
            application.ApplicationTypeID = applicationType.ApplicationID;
            application.ApplicationStatus = 3;
            application.LastStatusDate = DateTime.Now;
            application.PaidFees = applicationType.ApplicationFees;
            application.UserID = clsGlobalSettings.currentUser.UserID;
            return application;
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (detainedLicense == null)
                return;

                ApplicationModel application = InitializeAndSetupApplicationModel();

            if(ApplicationBusiness.Save(application))
            {
                lbApplicationID.Text = application.ApplicationID.ToString();
                if(DetainedLicenseBusiness.ReleaseDetainedLicense(detainedLicense.DetainID,clsGlobalSettings.currentUser.UserID,application.ApplicationID))
                {
                    MessageBox.Show("License is released successfuly!");
                    btnRelease.Enabled = false;
                    lkShowLicenseInfo.Enabled = true;
                    return;
                }
                else
                {
                    MessageBox.Show("error releasing the license");
                    btnRelease.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("error saving the application");
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
            frmShowLicense form = new frmShowLicense(detainedLicense.LicenseID, true); // true means show license by License ID not applicationID 
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }
    }
}
