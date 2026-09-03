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

namespace DVLD_Project.Driving_License
{
    public partial class frmNewLocalDrivingLicenseApplication : Form
    {
        enum enmode { AddNewLocalDrivingApp = 1, UpdateLocalDrivingApp = 2 }
        enmode _Mode = enmode.AddNewLocalDrivingApp;

        int _LocalDrivingID = -1;
        LocalDrivingLicenseApplication _LDApplication;
        User _UserMadeTheApplication;
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

            if (_Mode == enmode.AddNewLocalDrivingApp)
            {
                this.Text = "Add New Local Driving License Application";
                tcApplicationInfo.Enabled = false;
                btnSave.Enabled = false;
            }
            else //update Mode
            { 
                this.Text = "Update Local Driving License Application";

                tcApplicationInfo.Enabled = true;
                personDetailsWithFilter1.FilterEnabled = false;
                btnSave.Enabled = true;
            }


        }
         private void fillFormWithUserDetails() 
         {
            _LDApplication = LocalDrivingLicenseAppBusiness.FindLocalDrivingApplication(_LocalDrivingID);
            
            if (_LDApplication == null)
            {
                MessageBox.Show("No Local Driving License Application with ID = " + _LocalDrivingID, "Application Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }
            //this code will be executed only if the user is found and the form is in update mode
            _UserMadeTheApplication = UserBusiness.FindUser(_LDApplication.UserID);
            personDetailsWithFilter1.loadPersonDetailsForUpdate(_LDApplication.Person);
            lbLDApplicationID.Text = _LDApplication.LocalDrivingLicenseApplicationID.ToString();
            lbApplicationDate.Text = _LDApplication.ApplicationDate.ToString();
            cbLicenseClasses.SelectedValue = _LDApplication.LicenseClassID;
            lbApplicationFees.Text = _LDApplication.applicationType.ApplicationFees.ToString();
            lbUser.Text = _UserMadeTheApplication.UserName;
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
            fillComboBoxWithLicenseClasses();
            _ResetDefualtValues();
            if(_Mode == enmode.UpdateLocalDrivingApp)
            {
                fillFormWithUserDetails();
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
                // the personID is not -1 ( valid ) and the person is not already a user
                btnSave.Enabled = true;
                tcApplicationInfo.Enabled = true;
            }
        }
    }
}
