using DVLD.Models;
using DVLD_BusinessLayer;
using DVLD_Project.InternationalLicense;
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
    public partial class frmShowLicenseHistory : Form
    {
        string _nationalNumber = "";   
        public frmShowLicenseHistory(string nationalNumber)
        {
            InitializeComponent();
            this._nationalNumber = nationalNumber;
        }

        private void frmShowLicenseHistory_Load(object sender, EventArgs e)
        {
            People person = PeopleBusiness.FindPerson(_nationalNumber);
            personDetails1.loadPersonDetails(person);

            
            dgvLocalLicenses.DataSource = LicenseBusiness.GetAllLicensesForPersonID(person.PersonID);
            dgvLocalLicenses.Columns["LicenseID"].HeaderText = "Lic.ID";
            dgvLocalLicenses.Columns["ApplicationID"].HeaderText = "App.ID";
            dgvLocalLicenses.Columns["ClassName"].HeaderText = "Class Name";
            dgvLocalLicenses.Columns["IssueDate"].HeaderText = "Issue Date";
            dgvLocalLicenses.Columns["ExpirationDate"].HeaderText = "Expiration Date";
            dgvLocalLicenses.Columns["IsActive"].HeaderText = "Is Active";

            dgvInternationLicenses.DataSource = InternationalLicenseBusiness.GetAllInternationalLicensesForPersonID(person.PersonID);
            dgvInternationLicenses.Columns["InternationalLicenseID"].HeaderText = "Int.Lic.ID";
        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedLicenseID = Convert.ToInt32(dgvLocalLicenses.CurrentRow.Cells["LicenseID"].Value);
            frmShowLicense showLicenseForm = new frmShowLicense(selectedLicenseID, true);
            showLicenseForm.StartPosition = FormStartPosition.CenterScreen;
            showLicenseForm.ShowDialog();
        }

        private void showLicenseInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int selectedLicenseID = Convert.ToInt32(dgvInternationLicenses.CurrentRow.Cells["InternationalLicenseID"].Value);
            frmShowInternationalLicenseInfo showLicenseForm = new frmShowInternationalLicenseInfo(selectedLicenseID);
            showLicenseForm.StartPosition = FormStartPosition.CenterScreen;
            showLicenseForm.ShowDialog();
        }
    }
}
