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
using System.Web.Security;
using System.Windows.Forms;

namespace DVLD_Project.Detain_License
{
    public partial class frmManageDetainedLicenses : Form
    {
        DataTable dtDetainedLicenses;
        public frmManageDetainedLicenses()
        {
            InitializeComponent();
        }
        private void RefreshForm()
        {
            dtDetainedLicenses = DetainedLicenseBusiness.GetAllDetainedLicenses();
            dgvDetainedLicenses.DataSource = dtDetainedLicenses;
        }
        private void frmManageDetainedLicenses_Load(object sender, EventArgs e)
        {
            RefreshForm();

            dgvDetainedLicenses.Columns["ReleaseApplicationID"].HeaderText = "Release App.ID";

        }

        private void lkDetainLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDetainLicense form = new frmDetainLicense();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
            RefreshForm();
        }

        private void lkReleaseDetainedLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmReleaseDetainedLicense form = new frmReleaseDetainedLicense();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
            RefreshForm();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedNationalNo = dgvDetainedLicenses.CurrentRow.Cells["NationalNo"].Value.ToString();
            int personID = PeopleBusiness.getPersonIDByNationalNo(selectedNationalNo);
            frmPersonDetails form = new frmPersonDetails(personID);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.OnPersonUpdated += RefreshForm;
            form.ShowDialog();
            
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int licenseID = Convert.ToInt32(dgvDetainedLicenses.CurrentRow.Cells["LicenseID"].Value);
            frmShowLicense form = new frmShowLicense(licenseID,true);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedNationalNo = dgvDetainedLicenses.CurrentRow.Cells["NationalNo"].Value.ToString();
            frmShowLicenseHistory form = new frmShowLicenseHistory(selectedNationalNo);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int detainID = Convert.ToInt32(dgvDetainedLicenses.CurrentRow.Cells["DetainID"].Value);

            frmReleaseDetainedLicense form = new frmReleaseDetainedLicense(detainID);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
            RefreshForm();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            bool isReleased = (bool)dgvDetainedLicenses.CurrentRow.Cells["IsReleased"].Value;
            if (isReleased == false)
                releaseDetainedLicenseToolStripMenuItem.Enabled = true;
            else
                releaseDetainedLicenseToolStripMenuItem.Enabled = false;
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilterBy.Text = "";
            if (cbFilterBy.Text == "None")
            {
                dtDetainedLicenses.DefaultView.RowFilter = "";
            }
            tbFilterBy.Visible = (cbFilterBy.Text != "None");

        }

        private void tbFilterBy_TextChanged(object sender, EventArgs e)
        {

            string filterBy = cbFilterBy.Text;

            if (string.IsNullOrWhiteSpace(tbFilterBy.Text))
            {
                dtDetainedLicenses.DefaultView.RowFilter = "";
                return;
            }
            if (filterBy == "DetainID"|| filterBy =="ReleaseApplicationID")
            {

                dtDetainedLicenses.DefaultView.RowFilter = $"{filterBy} = {tbFilterBy.Text}";
                return;
            }
            dtDetainedLicenses.DefaultView.RowFilter = $"{filterBy} Like '{tbFilterBy.Text}%' ";

        }
    }
}
