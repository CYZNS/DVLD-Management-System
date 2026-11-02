using DVLD.Models;
using DVLD_BusinessLayer;
using DVLD_Project.Appointments.VisionTestAppointments;
using DVLD_Project.Driving_License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Appointments
{
    public partial class frmListTestsAppointments : Form
    {
        int _localDrivingLicenseApplicationID = -1;
        int _TestTypeID = -1;
        LocalDrivingLicenseApplication LDApplication;
        int _passedTests = 0;
        public frmListTestsAppointments(int localDrivingLicenseApplicationID,int passedTests,int testTypeID)                
        {
            InitializeComponent();
            this._localDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            this._passedTests = passedTests;
            this._TestTypeID = testTypeID;

        }
        private void changeTitleOfTestBasedOnTestType(int testType)
        {
            switch(testType)
            {
                case 1:
                    lbTestTypeTitle.Text = "Vision Test Appointments";
                    break;
                case 2:
                    lbTestTypeTitle.Text = "Written Test Appointments";
                    break;
                case 3:
                    lbTestTypeTitle.Text = "Street Test Appointments";
                    break;
            }
        }
        private void refreshForm()
        {
            LDApplication = LocalDrivingLicenseAppBusiness.FindLocalDrivingApplication(_localDrivingLicenseApplicationID);
            drivingLicenseApplicationDetails1.LoadLocalDrivingLicenseApplicationDetails(LDApplication, _passedTests);
            changeTitleOfTestBasedOnTestType(_TestTypeID);
            refreshGrid();
        }
        private void frmVisionTest_Load(object sender, EventArgs e)
        {
            refreshForm();
        }
        private void refreshGrid()
        {
            dgvVisionTestAppointments.DataSource = TestAppointmentBusiness.GetAllTestAppointmentsForTestTypeForLocalDrivingApplication(_localDrivingLicenseApplicationID, this._TestTypeID);
        }
        private void btnAddVisionTestAppointment_Click(object sender, EventArgs e)
        {

            if(TestAppointmentBusiness.HasActiveAppointment(_localDrivingLicenseApplicationID, 1))
            {
                MessageBox.Show("You already have an active appointment for this test type.");
                return;
            }
            if(TestBusiness.DoesPassOnTestType(_localDrivingLicenseApplicationID,_TestTypeID))
            {
                MessageBox.Show("This Person already passed this test before, you can only retake test if failed", "You passed the Test!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            frmScheduleTest ScheduleTest = new frmScheduleTest(_localDrivingLicenseApplicationID, this._TestTypeID);
            ScheduleTest.StartPosition = FormStartPosition.CenterScreen;
            ScheduleTest.ShowDialog();

            if(ScheduleTest.DialogResult == DialogResult.OK)
            {
                refreshGrid();
            }
          

        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedTestAppointmentID = (int)dgvVisionTestAppointments.CurrentRow.Cells["TestAppointmentID"].Value;

            frmScheduleTest ScheduleTest = new frmScheduleTest(selectedTestAppointmentID, _localDrivingLicenseApplicationID,this._TestTypeID);
            ScheduleTest.StartPosition = FormStartPosition.CenterScreen;
            ScheduleTest.ShowDialog();

            if (ScheduleTest.DialogResult == DialogResult.OK)
            {
                refreshGrid();
            }
           

        }
        private void changePassedTestAfterPassingTheTest()
        {
            _passedTests++;
        }
        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedTestAppointmentID = (int)dgvVisionTestAppointments.CurrentRow.Cells["TestAppointmentID"].Value;
            string TestAppointmentDate = dgvVisionTestAppointments.CurrentRow.Cells["AppointmentDate"].Value.ToString();
            frmTakeTest takeTest = new frmTakeTest(selectedTestAppointmentID,_localDrivingLicenseApplicationID, this._TestTypeID,TestAppointmentDate);
            takeTest.StartPosition = FormStartPosition.CenterScreen;
            takeTest.onPassedTest += changePassedTestAfterPassingTheTest;
            takeTest.ShowDialog();
            refreshForm();

        }
    }
}