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
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;
namespace DVLD_Project
{

    public partial class AddEditUserForm : Form
    {
        User user;
        int _userID = -1;
        enum enmode { AddUser = 1, UpdateUser = 2 }
        enmode mode = enmode.AddUser;

        public AddEditUserForm()
        {

            InitializeComponent();

            mode = enmode.AddUser;

        }
        public AddEditUserForm(int userID)
        {
            InitializeComponent();

            _userID = userID;
             mode = enmode.UpdateUser;

        }
        private bool checkIsPersonAUser(int personID)
        {

            bool isPersonAUser = UserBusiness.IsPersonAUser(personID);

            if (isPersonAUser)
            {
                return true;

            }

            return false;

        }
        private void btnNext_Click(object sender, EventArgs e)
        {

            if (mode == enmode.AddUser)
            {

                int personID = personDetailsWithFilter1.personID;

                if (personID == -1)
                {
                    MessageBox.Show("please bind the user to a person to complete.", "choose a Person", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    return;

                }

                if (checkIsPersonAUser(personID))
                {
                    MessageBox.Show("Selected Person is already A user, choose another one.", "Select Another Person", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;

                }
                // the personID is not -1 ( valid ) and the person is not already a user
                btnSave.Enabled = true;
                tcLoginInfo.Enabled = true;
                People person = PeopleBusiness.FindPerson(personID);
                user = new User(personID, person);
                
            }
            else // update mode
            {
                btnSave.Enabled = true;
                tcLoginInfo.Enabled = true;
            }


            tcPersonInfo.SelectedTab = tcLoginInfo;


        }
        private void fillUserWithLoginInfo()
        {
            user.UserName = tbUserName.Text.Trim();
            user.Password = tbConfirmPassword.Text.Trim();
            user.IsActive = cbIsActive.Checked;

        }
        private void changeModeToUpdateMode()
        {
            this.Text = "Update User";
            lbTitle.Text = "Update Users";
            mode = enmode.UpdateUser;

            lbUserID.Text = user.UserID.ToString();

           personDetailsWithFilter1.FilterEnabled = false;

            // check this
            personDetailsWithFilter1.disableAndSetupGPFilerForUpdateMode();


        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            fillUserWithLoginInfo();

            if (UserBusiness.Save(user))
            {

                MessageBox.Show("User Saved Successfuly!");

                changeModeToUpdateMode();

            }

            else
                MessageBox.Show("Error saving the User");

        }
        private void fillFormWithUserDetails()
        {
            user = UserBusiness.FindUser(_userID);

            // ctrlPersonCardWithFilter1.FilterEnabled = false;

            if (user == null)
            {
                MessageBox.Show("No User with ID = " + _userID, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }
            //this code will be executed only if the user is found and the form is in update mode
            lbUserID.Text = user.UserID.ToString();
            tbUserName.Text = user.UserName;
            tbPassword.Text = user.Password;
            tbConfirmPassword.Text = user.Password;
            cbIsActive.Checked = user.IsActive;
            personDetailsWithFilter1.loadPersonDetailsForUpdate(user.Person);

        }
        private void _ResetDefualtValues()
        {
            //this will setup the form with the default values based on the mode (Add or Update)

            if (mode == enmode.AddUser)
            {
                lbTitle.Text = "Add New User";
                this.Text = "Add New User";
               // user = new clsUser();

                tcLoginInfo.Enabled = false;

            }
            else
            {
                lbTitle.Text = "Update User";
                this.Text = "Update User";

                tcLoginInfo.Enabled = true;
                personDetailsWithFilter1.FilterEnabled = false;
                btnSave.Enabled = true;
                

            }

            tbUserName.Text = "";
            tbPassword.Text = "";
            tbConfirmPassword.Text = "";
            cbIsActive.Checked = true;


        }
        private void AddEditUserForm_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (mode == enmode.UpdateUser)
            {

                fillFormWithUserDetails();

            }

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
                e.Cancel= true;
                errorProvider1.SetError(tbConfirmPassword, "Password Confirmation Doesn't match the password");

            }
            else
            {
                errorProvider1.SetError(tbConfirmPassword, "");
            }

        }
        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbPassword, "Password cannot be blank");
            }
            else
            {
                errorProvider1.SetError(tbPassword, "");
            }

            // If they go back and change the first password, force the confirm box to clear

            // so they are forced to re-type it to match.

            if (!string.IsNullOrWhiteSpace(tbConfirmPassword.Text) && tbPassword.Text != tbConfirmPassword.Text)
            {

                tbConfirmPassword.Text = "";

                errorProvider1.SetError(tbConfirmPassword, "Main password was changed. Please re-confirm.");

            }
            

        }
        private void tbUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbUserName, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(tbUserName, null);
            }

            //if (_Mode == enMode.AddNew)
            //{

            //    if (clsUser.isUserExist(txtUserName.Text.Trim()))
            //    {
            //        e.Cancel = true;
            //        errorProvider1.SetError(txtUserName, "username is used by another user");
            //    }
            //    else
            //    {
            //        errorProvider1.SetError(txtUserName, null);
            //    }
            //    ;
            //}
            //else
            //{
            //    //incase update make sure not to use anothers user name
            //    if (_User.UserName != txtUserName.Text.Trim())
            //    {
            //        if (clsUser.isUserExist(txtUserName.Text.Trim()))
            //        {
            //            e.Cancel = true;
            //            errorProvider1.SetError(txtUserName, "username is used by another user");
            //            return;
            //        }
            //        else
            //        {
            //            errorProvider1.SetError(txtUserName, null);
            //        }
                    
            //    }
            //}


        }



    }
}