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
    public partial class ctrlDriverLicenseInfoWithFilter : UserControl
    {
        public ctrlDriverLicenseInfoWithFilter()
        {
            InitializeComponent();
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            ctrlDrivingLicneseInfo1.LoadLicenseInfoByLicenseID(25);
        }
    }
}
