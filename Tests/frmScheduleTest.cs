using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Appointments.VisionTestAppointments
{
    public partial class frmScheduleTest : Form
    {
        
        int _localDrivingLicenseApplicationID = -1;
        int _AppointmentID = -1;
        int _TestTypeID = -1;
        public frmScheduleTest(int LocalDrivingLicenseApplicationID,int testTypeID)
        {
            InitializeComponent();
            ctrlScheduleTest1.OnSaveComplete += ctrlScheduleTestOnSaveCompleted;

            this._localDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this._TestTypeID = testTypeID;
        }
        // this constructor is for the update mode:
        public frmScheduleTest(int AppointmentID, int LocalDrivingLicenseApplicationID,int testTypeID)
        {
            InitializeComponent();
            ctrlScheduleTest1.OnSaveComplete += ctrlScheduleTestOnSaveCompleted;

            this._localDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this._AppointmentID = AppointmentID;
            this._TestTypeID = testTypeID;

        }

        private void frmScheduleTest_Load(object sender, EventArgs e)
        {

            ctrlScheduleTest1.loadTestDetails(this._AppointmentID, this._localDrivingLicenseApplicationID,_TestTypeID);
        }
        private void ctrlScheduleTestOnSaveCompleted()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        
    }
}
