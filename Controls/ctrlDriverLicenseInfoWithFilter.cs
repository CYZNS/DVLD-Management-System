using DVLD.Models;
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
        public event Action <Licenses> OnLicenseIDSearch; // Event to notify when a license ID is searched
        public Driver LoadedDriver
        {
            get
            {
                return ctrlDrivingLicneseInfo1.DriverLoaded;
            }
        }
        private void disableFilter(int licenseID)
        {
            tbLicenseID.Text = licenseID.ToString();
            gpFilter.Enabled = false;
        }
        public ctrlDriverLicenseInfoWithFilter()
        {
            InitializeComponent();
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbLicenseID.Text, out int licenseID) || licenseID <= 0)
            {
                MessageBox.Show("Please enter a valid License ID.","Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                ctrlDrivingLicneseInfo1.ClearLicenseInfo(); // if the user searched previously for correct licenseID and then enters invalid on so the user control should be cleard and tell the the new international license ID is invalid to reset the form controls and not to show the previous license info.

                OnLicenseIDSearch?.Invoke(null);
                return;
            }
            
            ctrlDrivingLicneseInfo1.LoadLicenseInfoByLicenseID(licenseID);
            
            OnLicenseIDSearch?.Invoke(ctrlDrivingLicneseInfo1.LicenseLoaded);
        }
        //this method is used in releaseDetain license when opening the form with ready license without needing to search and fire the event
        public void LoadReadyDriverLicense(int licenseID)
        {
            ctrlDrivingLicneseInfo1.LoadLicenseInfoByLicenseID(licenseID);
            disableFilter(licenseID);
        }
    }
}
