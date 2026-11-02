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
    public partial class frmLDAppDetails : Form
    {
        int _LocalDrivingApplicationID = -1;
        int _PassedTests = 0;
        public frmLDAppDetails(int LocalDrivingApplicationID,int passedTests)
        {
            InitializeComponent();
            _LocalDrivingApplicationID = LocalDrivingApplicationID;
            _PassedTests = passedTests;
        }
        

        private void frmLDAppDetails_Load(object sender, EventArgs e)
        {
            LocalDrivingLicenseApplication LDApplication = LocalDrivingLicenseAppBusiness.FindLocalDrivingApplication(_LocalDrivingApplicationID);
            drivingLicenseApplicationDetails1.LoadLocalDrivingLicenseApplicationDetails(LDApplication, _PassedTests);
        }

        private void guna2CirclePictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
