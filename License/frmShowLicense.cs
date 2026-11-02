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
       private readonly bool byLicenseID = false;

       private readonly int _ID = -1;
        public frmShowLicense(int id,bool byLicenseID)
        {
            InitializeComponent();
            this._ID = id;
            this.byLicenseID = byLicenseID;
        }
       

        private void frmShowLicense_Load(object sender, EventArgs e)
        {
            if(byLicenseID)
                ctrlDrivingLicneseInfo1.LoadLicenseInfoByLicenseID(_ID);
            else
                ctrlDrivingLicneseInfo1.LoadLicenseInfoByLDApplicationID(_ID);
        }
    }
}
