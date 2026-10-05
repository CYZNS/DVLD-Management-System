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
    public partial class ctrlScheduleTest : UserControl
    {
        public event Action OnSaveComplete; // I should implement this so the gridView know when to refresh and to not refresh when nothing is changed
        LocalDrivingLicenseApplication LDApplication;
        TestAppointment _testAppointment;
        int _AppointmentID = -1;
        int _TestTypeID = -1;
        ApplicationModel retakeTestApplication;
        public ctrlScheduleTest()
        {
            InitializeComponent();
        }
        private void SetupRetakeTestApplicationInfo()
        {
            // get the retake test applicationType fees
            ApplicationType retakeTestApplicationType = ApplicationTypeBusiness.FindApplicationType(7);

            lblRetakeAppFees.Text = retakeTestApplicationType.ApplicationFees.ToString();
            double totalFees = Convert.ToDouble(lblRetakeAppFees.Text) + Convert.ToDouble(lblFees.Text);
            lblTotalFees.Text = totalFees.ToString();
            retakeTestApplication = new ApplicationModel();
            retakeTestApplication.PersonID = LDApplication.PersonID;
            retakeTestApplication.Person = LDApplication.Person;
            retakeTestApplication.ApplicationTypeID = 7;
            retakeTestApplication.applicationType = retakeTestApplicationType;
            retakeTestApplication.PaidFees = Convert.ToDecimal(lblRetakeAppFees.Text);  
            retakeTestApplication.UserID = clsGlobalSettings.currentUser.UserID;
            retakeTestApplication.ApplicationDate = DateTime.Now;
        }
        private void InitializeTestAppointmentWithBasicValues()
        {
            _testAppointment = new TestAppointment();
            _testAppointment.TestTypeID = _TestTypeID; 
            _testAppointment.LocalDrivingApplicationID = LDApplication.LocalDrivingLicenseApplicationID;
            _testAppointment.PaidFees = decimal.Parse(lblFees.Text);
            _testAppointment.UserID = clsGlobalSettings.currentUser.UserID;
            _testAppointment.isLocked = false;

            dtpTestDate.Value = DateTime.Now; // default value


            // check if he has failed a previous test:
            if(TestBusiness.DoesFailOnTestType(_testAppointment.LocalDrivingApplicationID,_testAppointment.TestTypeID))
            {
                gbRetakeTestInfo.Enabled = true;
                SetupRetakeTestApplicationInfo();
            }
            else
                gbRetakeTestInfo.Enabled = false;
        }
        private void SetObjectAndFormForUpdate()
        {
            _testAppointment = TestAppointmentBusiness.FindTestAppointment(this._AppointmentID);
            
            if (_testAppointment == null)
            {
                MessageBox.Show("Error: Could not find appointment details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dtpTestDate.Value = _testAppointment.AppointmentDate;

            if(_testAppointment.RetakeTestID !=-1) // we are in retake test update mode
            {
                retakeTestApplication = ApplicationBusiness.FindApplication(_testAppointment.RetakeTestID);
                lblRetakeTestAppID.Text = retakeTestApplication.ApplicationID.ToString();
                lblRetakeAppFees.Text = retakeTestApplication.applicationType.ApplicationFees.ToString();
                double totalFees = Convert.ToDouble(lblRetakeAppFees.Text) + Convert.ToDouble(lblFees.Text);
                lblTotalFees.Text = totalFees.ToString();
                gbRetakeTestInfo.Enabled = true;
            }

            if (_testAppointment.isLocked == true)
            {
                dtpTestDate.Enabled = false;
                lbLocked.Visible = true;
                btnSave.Enabled = false;
                return;
            }
        }
        private void FillFormWithDetails(int localDrivingApplicationID, int testTypeID)
        {
            LDApplication = LocalDrivingLicenseAppBusiness.FindLocalDrivingApplication(localDrivingApplicationID);
            LicenseClass licenseClass = LicenseClassBusiness.FindLicenseClass(LDApplication.LicenseClassID);
            TestType testType = TestTypeBusiness.FindTestType(testTypeID);

            lblLocalDrivingLicenseAppID.Text = LDApplication.LocalDrivingLicenseApplicationID.ToString();
            lblDrivingClass.Text = licenseClass.ClassName;
            lblFullName.Text = LDApplication.Person.FullName;
            int totalTrials = TestBusiness.TotalTrialsPerTestType(localDrivingApplicationID, testTypeID);
            lblTrial.Text = totalTrials.ToString(); 
            lblFees.Text = testType.TestTypeFees.ToString();
            gbRetakeTestInfo.Enabled = false;

        }
        public void loadTestDetails(int appointmentID, int localDrivingApplicationID, int testTypeID)
        {
            this._AppointmentID = appointmentID;
            this._TestTypeID = testTypeID;

            FillFormWithDetails(localDrivingApplicationID, testTypeID);

            if (this._AppointmentID ==-1)
            {
                InitializeTestAppointmentWithBasicValues();
            }
            else // update mode
            {
                SetObjectAndFormForUpdate();
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _testAppointment.AppointmentDate = dtpTestDate.Value;

            if(retakeTestApplication!=null)// if it is not null so it is retake test mode
            {
                
                retakeTestApplication.LastStatusDate = DateTime.Now;
                retakeTestApplication.ApplicationStatus = 3;

                if(!ApplicationBusiness.Save(retakeTestApplication))
                {
                    MessageBox.Show("Error: Could not save the Retake Application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                lblRetakeTestAppID.Text = retakeTestApplication.ApplicationID.ToString();
                _testAppointment.RetakeTestID = retakeTestApplication.ApplicationID;
            }
            if (TestAppointmentBusiness.SaveTestAppointment(_testAppointment))
            {
                MessageBox.Show("Appointment Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error saving appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            OnSaveComplete?.Invoke();
        }
        
    }
}
