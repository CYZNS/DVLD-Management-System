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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Project.Appointments.VisionTestAppointments
{
    public partial class frmTakeTest : Form
    {
        public Action onPassedTest;
        int _LocalDrivingApplicationID = -1;
        LocalDrivingLicenseApplication LDApplication;
        Test test;
        int _TestTypeID = -1;
        int _TestAppointmentID = -1;
        string _TestAppointmentDate = "";
        public frmTakeTest(int TestAppointmentID,int LocalDrivingApplicationID,int TestTypeID,string testDate)
        {
            InitializeComponent();
            _LocalDrivingApplicationID = LocalDrivingApplicationID;
            _TestTypeID = TestTypeID;
            _TestAppointmentID = TestAppointmentID;
            _TestAppointmentDate = testDate;
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            LDApplication = LocalDrivingLicenseAppBusiness.FindLocalDrivingApplication(_LocalDrivingApplicationID);
            LicenseClass licenseClass = LicenseClassBusiness.FindLicenseClass(LDApplication.LicenseClassID);
            TestType testType = TestTypeBusiness.FindTestType(_TestTypeID);
            test = new Test();

            lblLocalDrivingLicenseAppID.Text = LDApplication.LocalDrivingLicenseApplicationID.ToString();
            lblDrivingClass.Text = licenseClass.ClassName;
            lblFullName.Text = LDApplication.Person.FullName;
            int totalTrials = TestBusiness.TotalTrialsPerTestType(_LocalDrivingApplicationID,_TestTypeID);
            lblTrial.Text = totalTrials.ToString(); 
            lblFees.Text = testType.TestTypeFees.ToString();
            lbDate.Text = _TestAppointmentDate;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            test.TestAppointmentID = _TestAppointmentID; // just store the appointmentID in the test object 
            test.Notes = txtNotes.Text;
            test.CreatedByUserID = clsGlobalSettings.currentUser.UserID;
            test.TestResult = rbPass.Checked;
            TestBusiness.SaveTest(test);
            TestAppointmentBusiness.LockTestAppointment(test.TestAppointmentID);

            if(test.TestResult ==true)
            {
                onPassedTest?.Invoke();
            }
            this.Close();
        }
    }
}
