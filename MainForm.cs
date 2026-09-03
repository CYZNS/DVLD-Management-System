using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BusinessLayer;
using DVLD_Project.Driving_License;
using DVLD_Project.Tests.TestTypes;
using DVLD_Project.Users;

namespace DVLD_Project
{
    public partial class MainForm : Form
    {
        public bool isSignOut = false;
        public MainForm()
        {
            InitializeComponent();
        }

        private Form activeForm = null;

        private void OpenChildForm(Form childForm)
        {
            // If a form is already open inside the panel, close it first
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;

            // Configure the child form so it behaves like a control inside the panel
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Add the child form to the panel and display it
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void peopleToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new ManagePeopleForm());
        }
        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManageUsersForm());
        }
        private void currentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmShowUserDetails frm = new frmShowUserDetails(clsGlobalSettings.currentUser.UserID);
            frm.StartPosition=FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(clsGlobalSettings.currentUser.UserID);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog(); 
        }
        private void signToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobalSettings.currentUser = null;
            isSignOut = true;
            this.Close();
        }
        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmManageApplicationTypes());
        }
        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmManageTestTypes());
        }
        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenChildForm(new frmNewLocalDrivingLicenseApplication());

        }

       

        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmManageLocalDrivingLicenseApplications());

        }
    }
}
