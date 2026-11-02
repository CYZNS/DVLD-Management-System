using DVLD.Models;
using DVLD_BusinessLayer;
using DVLD_Project.License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.InternationalLicense
{
    public partial class frmManageInternationalLicenses : Form
    {
        DataTable dtInternationalLicenses;
        public frmManageInternationalLicenses()
        {
            InitializeComponent();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilterBy.Text = "";
            if (cbFilterBy.Text == "None")
            {
                dtInternationalLicenses.DefaultView.RowFilter = "";
            }
            tbFilterBy.Visible = (cbFilterBy.Text != "None");
        }

        private void tbFilterBy_TextChanged(object sender, EventArgs e)
        {
            if(dtInternationalLicenses == null)
            {
                return;
            }   

            string filterBy = cbFilterBy.Text;
            string input = tbFilterBy.Text.Trim();
            if (string.IsNullOrWhiteSpace(input)||filterBy == "None")
            {
                dtInternationalLicenses.DefaultView.RowFilter = "";
                return;
            }

                dtInternationalLicenses.DefaultView.RowFilter = $"{filterBy} = {input}";
            
        }
        private void refreshGrid()
        {
            dtInternationalLicenses = InternationalLicenseBusiness.GetAllInternationalLicenses();
            dgvInternationalicense.DataSource = dtInternationalLicenses;
        }
        private void frmManageInternationalLicenses_Load(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = (int)dgvInternationalicense.CurrentRow.Cells["DriverID"].Value;
            Driver driver = DriverBusiness.FindDriverByDriverID(DriverID);

            frmPersonDetails form = new frmPersonDetails(driver.PersonID);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int InternationalLicenseID = (int)dgvInternationalicense.CurrentRow.Cells["InternationalLicenseID"].Value;
            frmShowInternationalLicenseInfo form = new frmShowInternationalLicenseInfo(InternationalLicenseID);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();

        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = (int)dgvInternationalicense.CurrentRow.Cells["DriverID"].Value;
            Driver driver = DriverBusiness.FindDriverByDriverID(DriverID);
            frmShowLicenseHistory form = new frmShowLicenseHistory(driver.personInfo.NationalID);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        private void btnAddLocalDrivingApplication_Click(object sender, EventArgs e)
        {
            frmNewInternationalLicense form = new frmNewInternationalLicense();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
            refreshGrid();
        }
    }
}
