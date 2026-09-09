using DVLD.Models;
using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Driving_License
{
    public partial class frmNewLocalDrivingLicenseApplication : Form
    {
        enum enmode { AddNewLocalDrivingApp = 1, UpdateLocalDrivingApp = 2 }
        enmode _Mode = enmode.AddNewLocalDrivingApp;

        int _LocalDrivingID = -1;
        LocalDrivingLicenseApplication _LDApplication;
        ApplicationType applicationType = ApplicationTypeBusiness.FindApplicationType(1);

        public frmNewLocalDrivingLicenseApplication()
        {
            InitializeComponent();
            _Mode = enmode.AddNewLocalDrivingApp;
        }
        public frmNewLocalDrivingLicenseApplication(int LocalDrivingID)
        {
            InitializeComponent();
            _Mode = enmode.UpdateLocalDrivingApp;
            _LocalDrivingID = LocalDrivingID;
        }
        private void _ResetDefualtValues()
        {
            //this will setup the form with the default values based on the mode (Add or Update)
            fillComboBoxWithLicenseClasses();

            if (_Mode == enmode.AddNewLocalDrivingApp)
            {
                this.Text = "Add New Local Driving License Application";
                _LDApplication = new LocalDrivingLicenseApplication();
                tcApplicationInfo.Enabled = false;
                btnSave.Enabled = false;

                cbLicenseClasses.SelectedIndex = 2;
                lbApplicationFees.Text = applicationType.ApplicationFees.ToString();
                lbApplicationDate.Text = DateTime.Now.ToShortDateString();
                lbUser.Text = clsGlobalSettings.currentUser.UserName;
            }
            else //update Mode
            {
                this.Text = "Update Local Driving License Application";

                tcApplicationInfo.Enabled = true;
                personDetailsWithFilter1.FilterEnabled = false;
                btnSave.Enabled = true;
            }


        }
         private void fillFormWithDetailsForUpdateMode()
         {
            _LDApplication = LocalDrivingLicenseAppBusiness.FindLocalDrivingApplication(_LocalDrivingID);
            
            if (_LDApplication == null)
            {
                MessageBox.Show("No Local Driving License Application with ID = " + _LocalDrivingID, "Application Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }
            
            
            personDetailsWithFilter1.loadPersonDetailsForUpdate(_LDApplication.Person);
            lbLDApplicationID.Text = _LDApplication.LocalDrivingLicenseApplicationID.ToString();
            lbApplicationDate.Text = _LDApplication.ApplicationDate.ToString();
            cbLicenseClasses.SelectedValue = _LDApplication.LicenseClassID;
            lbApplicationFees.Text = _LDApplication.PaidFees.ToString();
            lbUser.Text = UserBusiness.FindUser(_LDApplication.UserID).UserName;
         }
        private void fillComboBoxWithLicenseClasses()
        {
            DataTable dtLicenseClasses = LicenseClassBusiness.GetAllLicenseClasses();
            cbLicenseClasses.DataSource = dtLicenseClasses;
            cbLicenseClasses.DisplayMember = "ClassName";
            cbLicenseClasses.ValueMember = "LicenseClassID";
        }
        private void frmNewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
            if(_Mode == enmode.UpdateLocalDrivingApp)
            {
                fillFormWithDetailsForUpdateMode();
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enmode.AddNewLocalDrivingApp)
            {

                int personID = personDetailsWithFilter1.personID;

                if (personID == -1)
                {
                    MessageBox.Show("please bind the user to a person to complete.", "choose a Person", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    return;

                }
                // the personID is not -1 ( valid ) 
                btnSave.Enabled = true;
                tcApplicationInfo.Enabled = true;
            }
            else // update mode
            {
                tcApplicationInfo.Enabled = true;
                btnSave.Enabled = true;
            }

            tbcDrivingLicenseApplicationIfno.SelectedIndex = 1;
        }
        private void fillLocalDrivingApplicationWithFormData()
        {
            _LDApplication.PersonID = personDetailsWithFilter1.personID;
            _LDApplication.Person = PeopleBusiness.FindPerson(_LDApplication.PersonID);
            if(_Mode == enmode.AddNewLocalDrivingApp) // if the mode is update , I want to keep the original application date and only change the last status update
            {
                _LDApplication.ApplicationDate = DateTime.Now;
            }
            _LDApplication.ApplicationTypeID = 1;
            _LDApplication.applicationType =applicationType;
            _LDApplication.ApplicationStatus = 1;
            _LDApplication.LastStatusDate = DateTime.Now;
            _LDApplication.PaidFees = _LDApplication.applicationType.ApplicationFees;
            _LDApplication.UserID = clsGlobalSettings.currentUser.UserID;
            _LDApplication.LicenseClassID = (int)cbLicenseClasses.SelectedValue;

        }
        private void changeFormModeToUpdateMode()
        {
            this.Text = "Update Local Driving License Application";

            lbLDApplicationID.Text = _LDApplication.LocalDrivingLicenseApplicationID.ToString();
            _Mode = enmode.UpdateLocalDrivingApp;
            personDetailsWithFilter1.FilterEnabled = false;


            // check this
            personDetailsWithFilter1.disableAndSetupGPFilerForUpdateMode();


        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valid!, put the mouse over the red icon(s) to see the error",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            fillLocalDrivingApplicationWithFormData();

            int ApplicationID = ApplicationBusiness.GetActiveApplication( _LDApplication.PersonID,_LDApplication.LicenseClassID,_LDApplication.ApplicationTypeID);

            //missing this: public static int GetActiveLicenseIDByPersonID(int PersonID , int LicenseClassID)
            // I should make the license table and layers

            if (ApplicationID != -1 && _Mode == enmode.AddNewLocalDrivingApp)
            {
                MessageBox.Show("The person already has an active application with ID = " + ApplicationID, "Active Application Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (LocalDrivingLicenseAppBusiness.Save(_LDApplication))
            {
                changeFormModeToUpdateMode();
                MessageBox.Show("Local Driving License Application Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error Saving Local Driving License Application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
