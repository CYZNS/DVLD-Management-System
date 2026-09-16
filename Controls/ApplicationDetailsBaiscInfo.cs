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

namespace DVLD_Project.Controls
{

    public partial class ApplicationDetailsBaiscInfo : UserControl
    {
        int _PersonID = -1;
        public ApplicationDetailsBaiscInfo()
        {
            InitializeComponent();
        }
        public void LoadApplicationDetails(ApplicationModel application)
        {
            if (application != null)
            {
                lbApplicationID.Text = application.ApplicationID.ToString();
                lbStatus.Text = application.ApplicationStatus.ToString();
                lbFees.Text = application.PaidFees.ToString("C");
                lbType.Text = application.applicationType.ApplicationTitle;
                lbApplicant.Text = application.Person.FullName;
                lbDateCreated.Text = application.ApplicationDate.ToString("dd/MM/yyyy");
                lbStatusDate.Text = application.LastStatusDate.ToString("dd/MM/yyyy");
                User user = UserBusiness.FindUser(application.UserID);
                lbUser.Text = user != null ? user.Person.FullName : "Unknown User";

                _PersonID = application.PersonID;
            }
            else
            {
                MessageBox.Show("Application details not found.");
            }
            

        }

        private void lkPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonDetails personDetailsForm = new frmPersonDetails(_PersonID);
            personDetailsForm.StartPosition = FormStartPosition.CenterScreen;
            personDetailsForm.ShowDialog();
        }
    }
}
