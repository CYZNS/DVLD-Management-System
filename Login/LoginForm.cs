using DVLD.Models;
using DVLD_BusinessLayer;
using System;
using System.IO;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private static string GetFilePath()
        {
            return Path.Combine(Directory.GetCurrentDirectory(), "data.txt");
        }
        private void RememberUsernameAndPassword(string username, string password)
        {
            string filePath = GetFilePath();

            // If username is empty, they unchecked the box. Delete the file.
            if (string.IsNullOrWhiteSpace(username) && File.Exists(filePath))
            {
                File.Delete(filePath);
                return;
            }

            // Otherwise, save the credentials
            string dataToSave = $"{username}#//#{password}";
            File.WriteAllText(filePath, dataToSave);
        }


        private bool GetStoredCredential(ref string username, ref string password)
        {
            string filePath = GetFilePath();

            if (File.Exists(filePath))
            {
                string line = File.ReadAllText(filePath);
                string[] result = line.Split(new string[] { "#//#" }, StringSplitOptions.None);

                if (result.Length == 2)
                {
                    username = result[0];
                    password = result[1];
                    return true;
                }
            }
            return false;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string userName = tbUserName.Text.Trim();
            string password = tbPassword.Text.Trim(); 

            User user =UserBusiness.FindUser(userName, password);
            if (user != null)
            {
                
                if(chkRememberMe.Checked)
                {
                    RememberUsernameAndPassword(userName, password);
                }
                else
                {
                    RememberUsernameAndPassword("", "");
                }

                if(!user.IsActive)
                {
                    tbUserName.Focus();
                    MessageBox.Show("Your accound is not Active, Contact Admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                clsGlobalSettings.currentUser = user;

                MainForm form = new MainForm();
                form.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                form.ShowDialog();
                if(form.isSignOut)
                {
                    this.Show();
                    tbPassword.Clear();
                    tbUserName.Clear();
                    tbUserName.Focus();
                }
                else
                    System.Windows.Forms.Application.Exit();
                
                
            }
            else
            {
                tbUserName.Focus();
                MessageBox.Show("Invalid Username/Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            string savedUsername = "";
            string savedPassword = "";

            if (GetStoredCredential(ref savedUsername, ref savedPassword))
            {
                tbUserName.Text = savedUsername;
                tbPassword.Text = savedPassword;
                chkRememberMe.Checked = true; 
            }
            else
            {
                chkRememberMe.Checked = false;
            }
        }
    }
}
