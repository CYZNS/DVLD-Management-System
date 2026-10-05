using DVLD.Models;
using DVLD_BusinessLayer;
using DVLD_Project.Appointments;
using DVLD_Project.Controls;
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
            ShowLicenseStripMenuItem2.Enabled = false;
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
        private void editLocalDrivingApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLocalDrivingApplications.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to edit this User?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int selectedID = Convert.ToInt32(dgvLocalDrivingApplications.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value);
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
        private void showAddLocalDrivingLicenseApplicationForm()
        {
            frmNewLocalDrivingLicenseApplication form = new frmNewLocalDrivingLicenseApplication();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
            if(form.DialogResult == DialogResult.OK)
            {
                refreshForm();
            }
        }
        private void btnAddLocalDrivingApplication_Click(object sender, EventArgs e)
        {
            showAddLocalDrivingLicenseApplicationForm();
        }
        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt32(dgvLocalDrivingApplications.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value);

            
                DialogResult result = MessageBox.Show("Are you sure you want to cancel this Local Driving License Application?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (LocalDrivingLicenseAppBusiness.Cancel(selectedID))
                    {
                        MessageBox.Show("Local Driving License Application canceled successfully");
                        refreshForm();
                    }
                    else
                        MessageBox.Show("Error canceling the Local Driving License Application");
                }
           
        }
        private void DeleteStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLocalDrivingApplications.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this Local Driving License Application?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int selectedID = Convert.ToInt32(dgvLocalDrivingApplications.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value);
                    if (LocalDrivingLicenseAppBusiness.DeleteLocalDrivingLicenseApplication(selectedID))
                    {
                        MessageBox.Show("Local Driving License Application deleted successfully");
                        refreshForm();
                    }
                    else
                        MessageBox.Show("Error deleting the Local Driving License Application");
                }
            }

        }
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt32(dgvLocalDrivingApplications.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value);
            int passedTests = Convert.ToInt32(dgvLocalDrivingApplications.CurrentRow.Cells["PassedTestCount"].Value);
            frmLDAppDetails form = new frmLDAppDetails(selectedID, passedTests);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();

        }
        private void DisableEnableTestsInContextMenuStrip(int passedTests)
        {
            ShowLicenseStripMenuItem2.Enabled = false;

            switch (passedTests)
            {
                case 1:
                    ScheduleTestStripMenuItem1.Enabled = true;
                    VisionTestStripMenuItem1.Enabled = false;
                    WritttentTestStripMenuItem2.Enabled = true;
                    PracticalStripMenuItem3.Enabled = false;
                    IssueDLStripMenuItem1.Enabled = false;


                    break;
                case 2:
                    ScheduleTestStripMenuItem1.Enabled = true;
                    VisionTestStripMenuItem1.Enabled = false;
                    WritttentTestStripMenuItem2.Enabled = false;
                    PracticalStripMenuItem3.Enabled = true;
                    IssueDLStripMenuItem1.Enabled = false;

                    break;
                case 3:
                    ScheduleTestStripMenuItem1.Enabled = false;
                    VisionTestStripMenuItem1.Enabled = false;
                    WritttentTestStripMenuItem2.Enabled = false;
                    PracticalStripMenuItem3.Enabled = false;
                    IssueDLStripMenuItem1.Enabled = true;
                    break;
                default:
                    ScheduleTestStripMenuItem1.Enabled = true;
                    VisionTestStripMenuItem1.Enabled = true;
                    WritttentTestStripMenuItem2.Enabled = false;
                    PracticalStripMenuItem3.Enabled = false;
                    IssueDLStripMenuItem1.Enabled = false;

                    break;

            }
        }
        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            int passedTests = Convert.ToInt32(dgvLocalDrivingApplications.CurrentRow.Cells["PassedTestCount"].Value);
            string applicationStatus = dgvLocalDrivingApplications.CurrentRow.Cells["Status"].Value.ToString();
            DisableEnableTestsInContextMenuStrip(passedTests);
            if(applicationStatus =="Completed")
            {
                editLocalDrivingApplicationToolStripMenuItem.Enabled = false;
                DeleteStripMenuItem.Enabled = false;
                cancelToolStripMenuItem.Enabled = false;
                IssueDLStripMenuItem1.Enabled = false;
                ShowLicenseStripMenuItem2.Enabled = true;
            }
        }
        private void showListTestAppointments(int testType)
        {
            int selectedID = Convert.ToInt32(dgvLocalDrivingApplications.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value);
            int passedTests = Convert.ToInt32(dgvLocalDrivingApplications.CurrentRow.Cells["PassedTestCount"].Value);
            frmListTestsAppointments frmVisionTest = new frmListTestsAppointments(selectedID, passedTests, testType);
            frmVisionTest.StartPosition = FormStartPosition.CenterScreen;
            frmVisionTest.ShowDialog();
            refreshForm();
        }
        private void VisionTestStripMenuItem1_Click(object sender, EventArgs e)
        {
            showListTestAppointments(1);
        }
        private void WritttentTestStripMenuItem2_Click(object sender, EventArgs e)
        {
            showListTestAppointments(2);
        }
        private void PracticalStripMenuItem3_Click(object sender, EventArgs e)
        {
            showListTestAppointments(3);
        }
        private void IssueDLStripMenuItem1_Click(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt32(dgvLocalDrivingApplications.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value);
            int passedTests = Convert.ToInt32(dgvLocalDrivingApplications.CurrentRow.Cells["PassedTestCount"].Value);

            frmIssueDrivingLicense issueDrivingLicense = new frmIssueDrivingLicense(selectedID,passedTests);
            issueDrivingLicense.StartPosition = FormStartPosition.CenterScreen;
            issueDrivingLicense.ShowDialog();
            refreshForm();
        }
        private void ShowLicenseStripMenuItem2_Click(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt32(dgvLocalDrivingApplications.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value);

            frmShowLicense ShowLicense = new frmShowLicense(selectedID);
            ShowLicense.StartPosition = FormStartPosition.CenterScreen;
            ShowLicense.ShowDialog();
        }
        private void showPersonLicenseHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NationalNo = dgvLocalDrivingApplications.CurrentRow.Cells["NationalNo"].Value.ToString();
            frmShowLicenseHistory ShowLicenseHistory = new frmShowLicenseHistory(NationalNo);
            ShowLicenseHistory.StartPosition = FormStartPosition.CenterScreen;
            ShowLicenseHistory.ShowDialog();
        }
    }
}
