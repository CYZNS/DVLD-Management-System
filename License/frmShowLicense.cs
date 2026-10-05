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

namespace DVLD_Project.License
{
    public partial class frmShowLicense : Form
    {
        int _LocalDrivingApplicationID = -1;
        public frmShowLicense(int localDrivingApplicationID)
        {
            InitializeComponent();
            this._LocalDrivingApplicationID = localDrivingApplicationID;
        }

        private void frmShowLicense_Load(object sender, EventArgs e)
        {
            ctrlDrivingLicneseInfo1.LoadLicenseInfoByLDApplicationID(_LocalDrivingApplicationID);
        }
    }
}
