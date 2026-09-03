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
    public partial class frmManageLocalDrivingLicenseApplications : Form
    {
        private DataTable dtDrivingLicenseApplications = LocalDrivingLicenseAppBusiness.GetAllLocalDrivingApplications();

        public frmManageLocalDrivingLicenseApplications()
        {
            InitializeComponent();
        }
        private void refreshForm()
        {
            dtDrivingLicenseApplications = LocalDrivingLicenseAppBusiness.GetAllLocalDrivingApplications();
            dgvLocalDrivingApplications.DataSource = dtDrivingLicenseApplications;

            dgvLocalDrivingApplications.Columns["LocalDrivingLicenseApplicationID"].HeaderText = "L.D.L.AppID";
            dgvLocalDrivingApplications.Columns["ClassName"].HeaderText = "Driving Class";
            dgvLocalDrivingApplications.Columns["PassedTestCount"].HeaderText = "Passed Tests";
            dgvLocalDrivingApplications.Columns["FullName"].HeaderText = "Full Name";

            lbRecords.Text = dgvLocalDrivingApplications.RowCount.ToString();
        }
        private void frmManageDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            refreshForm();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilterBy.Text = "";
            if (cbFilterBy.Text == "None")
            {
                dtDrivingLicenseApplications.DefaultView.RowFilter = "";
            }
            tbFilterBy.Visible = (cbFilterBy.Text != "None");
        }

        private void tbFilterBy_TextChanged(object sender, EventArgs e)
        {
            string filterBy = cbFilterBy.Text;

            if (string.IsNullOrWhiteSpace(tbFilterBy.Text))
            {
                dtDrivingLicenseApplications.DefaultView.RowFilter = "";
                return;
            }
            if (filterBy == "L.D.L.AppID")
            {

                dtDrivingLicenseApplications.DefaultView.RowFilter = $"LocalDrivingLicenseApplicationID = {tbFilterBy.Text}";
                return;
            }
            dtDrivingLicenseApplications.DefaultView.RowFilter = $"{filterBy} Like '{tbFilterBy.Text}%' ";

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLocalDrivingApplications.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to edit this User?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int selectedID = (int)dgvLocalDrivingApplications.CurrentRow.Cells["L.D.L.AppID"].Value;
                    frmNewLocalDrivingLicenseApplication form = new frmNewLocalDrivingLicenseApplication(selectedID);
                    form.StartPosition = FormStartPosition.CenterScreen;
                    form.ShowDialog();
                    refreshForm();
                }

            }
            else
            {
                MessageBox.Show("Error couldn't update person.");
            }
        }
    }
}
