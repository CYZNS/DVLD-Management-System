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
using System.Web.Caching;
using System.Windows.Forms;

namespace DVLD_Project.Users
{
    public partial class frmChangePassword : Form
    {
        // to get the userID from the manageUsersForm
        private int userID = -1;
        // helps reducing database visits by passing the whole User object which contains the person object as well 
        User currentUser;
        public frmChangePassword(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }
      
       
        private void tbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbConfirmPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbConfirmPassword, "Confirmation password cannot be blank!");
                return;
            }


            if (tbConfirmPassword.Text.Trim() != tbPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(tbConfirmPassword, "Password Confirmation Doesn't match the password");
              
            }
            else
            {
                errorProvider1.SetError(tbConfirmPassword, "");
            }
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            // If they go back and change the first password, force the confirm box to clear 
            // so they are forced to re-type it to match.
            if (!string.IsNullOrWhiteSpace(tbConfirmPassword.Text) && tbPassword.Text != tbConfirmPassword.Text)
            {
                tbConfirmPassword.Text = "";
                errorProvider1.SetError(tbConfirmPassword, "Main password was changed. Please re-confirm.");

            }
        }
        private void btnSavePassword_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid! Please check the red warning icons.",
              "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
              
            }

            if (UserBusiness.ChangePassword(currentUser.UserID, tbConfirmPassword.Text.Trim()))
            {
                MessageBox.Show("User password is changed successfuly!");
                this.Close();
            }
            else
                MessageBox.Show("Error changing the password");
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
             currentUser = UserBusiness.FindUser(userID);
            userDetails1.loadUserDetails(currentUser);
        }
        
        private void tbCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbCurrentPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbCurrentPassword, "Current Password can't be blank");
                return;
            }

            if (currentUser.Password != tbCurrentPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(tbCurrentPassword, "the current password is incorrect!");
                
            }
            else
            {
                errorProvider1.SetError(tbCurrentPassword, "");
            }
        }
    }
}
