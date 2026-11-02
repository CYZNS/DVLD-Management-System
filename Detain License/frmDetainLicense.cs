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

namespace DVLD_Project.Detain_License
{
    public partial class frmDetainLicense : Form
    {
        private int _SelectedLicenseID = -1;
        public frmDetainLicense()
        {
            InitializeComponent();
            ctrlDriverLicenseInfoWithFilter1.OnLicenseIDSearch += CtrlDriverLicenseInfoWithFilter1_OnLicenseIDSearch;
        }
        private void CtrlDriverLicenseInfoWithFilter1_OnLicenseIDSearch(Licenses license)
        {
            ResetLicenseSelectionState();
            if (license != null)
            {
                
                lbLicenseID.Text = license.LicenseID.ToString();
                if (license.IsActive == false)
                {
                    MessageBox.Show("The license is not active , choose an active license.", "License Not Active", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (DetainedLicenseBusiness.IsLicenseDetained(license.LicenseID))
                {
                    MessageBox.Show($"Selected License is already detained.", "License Already Detained", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                _SelectedLicenseID = license.LicenseID;
                lkLicenseHistory.Enabled = true;
                btnDetain.Enabled = true;

            }



        }

        private void ResetLicenseSelectionState()
        {
            _SelectedLicenseID = -1;
            btnDetain.Enabled = false;
            lkShowLicenseInfo.Enabled = false;
            lkLicenseHistory.Enabled = false;

            lbLicenseID.Text = "????";
            lbDetainID.Text = "????";
            tbFineFees.Text = "";
            errorProvider1.SetError(tbFineFees, "");
        }
        private void SetupDetainLicenseFormWithBasicInfo()
        {
            // fill the form with the basic 
            lbDetainDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblCreatedByUser.Text = clsGlobalSettings.currentUser.UserName;
        }

        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            ResetLicenseSelectionState();
            SetupDetainLicenseFormWithBasicInfo();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if (_SelectedLicenseID <= 0)
                return;
            if (!this.ValidateChildren())
                return;

            DetainedLicense _Detainedlicense = new DetainedLicense();
            _Detainedlicense.LicenseID = _SelectedLicenseID;
            _Detainedlicense.DetainDate = DateTime.Now;
            _Detainedlicense.CreatedByUserID = clsGlobalSettings.currentUser.UserID;
            _Detainedlicense.FineFees = Convert.ToDecimal(tbFineFees.Text);
            _Detainedlicense.IsReleased = false;
            
            if (DetainedLicenseBusiness.DetainLicense(_Detainedlicense))
            {
                
                MessageBox.Show($"License detained successfully. Detain ID : {_Detainedlicense.DetainID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbDetainID.Text = _Detainedlicense.DetainID.ToString();
                lkShowLicenseInfo.Enabled = true;
                btnDetain.Enabled = false;
                lkLicenseHistory.Enabled = true;
            }
            else
            {
                btnDetain.Enabled = false;
                MessageBox.Show("Failed to detain the license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        

        private void tbFineFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFineFees.Text))
            {
                errorProvider1.SetError(tbFineFees, "Fine fees are required.");
                e.Cancel = true;
                return;
            }
            if (!decimal.TryParse(tbFineFees.Text, out decimal fineFees)  || fineFees < 0)
            {
                errorProvider1.SetError(tbFineFees, "Enter a valid fine amount.");
                e.Cancel = true;
                return;
            }
            errorProvider1.SetError(tbFineFees, "");
        }

        private void lkShowLicenseInfo_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicense form = new frmShowLicense(_SelectedLicenseID, true); // true means show license by License ID not applicationID 
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();

        }

        private void lkLicenseHistory_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string nationalID = ctrlDriverLicenseInfoWithFilter1.LoadedDriver?.personInfo?.NationalID;

            if (string.IsNullOrWhiteSpace(nationalID))
                return;

            frmShowLicenseHistory from = new frmShowLicenseHistory(nationalID);
            from.StartPosition = FormStartPosition.CenterScreen;
            from.ShowDialog();

        }
    }
}
