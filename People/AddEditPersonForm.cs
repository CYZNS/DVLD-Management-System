using DVLD.Models;
using DVLD_BusinessLayer;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class AddEditPersonForm : Form
    {
        int personID = -1;
        People person;
        string selectedImagePath = "";
        enum enmode {addPerson =1 , updatePerson=2};
        enmode mode = enmode.addPerson;
        public event Action<People> OnPersonAdded;

        public AddEditPersonForm(int personID)
        {
            InitializeComponent();
            this.personID = personID;
            if(this.personID == -1)
                mode = enmode.addPerson;
            else
                mode = enmode.updatePerson;
        }
        private Guna2RadioButton getCheckedRadioButton()
        {
            if (rbMale.Checked)
                return rbMale;
            else
                return rbFemale;
        }
        private void fillCountriesInComboBox()
        {
            DataTable dtCountries = CountriesBusiness.getAllCountries();
            cbCountries.DataSource = dtCountries;
            cbCountries.DisplayMember = "CountryName";
            cbCountries.ValueMember = "CountryID";
            cbCountries.SelectedValue = 150; // 150 --> saudi arabia
        }
        private void checkRadioButtonBasedonGenderID(byte gender)
        {
            if(gender == 0)
                rbMale.Checked = true;
            else 
                rbFemale.Checked = true;
        }
        private void setUpFormForUpdateMode()
        {
            person = PeopleBusiness.FindPerson(personID);
            if(person == null)
            {
                MessageBox.Show("this form will be closed because No person with this ID");
                this.Close();
                return;
            }
            lbTitle.Text = "Update Person";
            lbPersonID.Text = personID.ToString();
            tbFirstName.Text = person.FirstName;
            tbSecondName.Text = person.SecondName;
            tbThirdName.Text = person.ThirdName;
            tbLastName.Text = person.LastName;
            tbNationalNo.Text = person.NationalID;
            dtmDateOfBirth.Value = person.DateOfBirth;
            checkRadioButtonBasedonGenderID(person.Gender);
            tbPhone.Text = person.Phone;
            tbEmail.Text = person.Email;
            tbAddress.Text = person.Address;
            cbCountries.SelectedValue = person.NationalityCountryID;
            if(person.ImagePath !="")
            {
                selectedImagePath = person.ImagePath;
                pbImage.Load(selectedImagePath);
                lkRemoveImage.Visible = true;
            }
            else
            {
                setDefaultImage();
            }
            

        }
        private void setDefaultImage()
        {
            if (string.IsNullOrEmpty(selectedImagePath))
            {
                if (rbMale.Checked)
                    pbImage.Image = Properties.Resources.anonymous_man;
                else
                    pbImage.Image = Properties.Resources.anonymous_woman;

                pbImage.ImageLocation = null;
            }
        }
        private void setupForm()
        {
           
            if(mode == enmode.updatePerson)
            {
                setUpFormForUpdateMode();
                return;
            }
            //add mode
            lbTitle.Text = "Add Person";
            person = new People();
            
            setDefaultImage();
        }
        private void fillPersonWithFormDetails()
        {
            person.FirstName = tbFirstName.Text;
            person.SecondName = tbSecondName.Text;
            person.ThirdName = tbThirdName.Text;
            person.LastName = tbLastName.Text;
            person.NationalID = tbNationalNo.Text;
            person.Phone = tbPhone.Text;
            person.Email = tbEmail.Text.Trim();
            person.Address = tbAddress.Text;
            person.Gender = Convert.ToByte(getCheckedRadioButton().Tag);
            person.DateOfBirth = dtmDateOfBirth.Value;
            person.NationalityCountryID = (int)cbCountries.SelectedValue;
            person.ImagePath = selectedImagePath;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            fillPersonWithFormDetails();
            if(PeopleBusiness.savePerson(person))
            {
                if(personID==-1)
                MessageBox.Show("person added successfuly");
                else
                    MessageBox.Show("person updated successfuly");

                OnPersonAdded?.Invoke(person);
            }

           
             this.personID = person.PersonID;
             mode = enmode.updatePerson;
             lbPersonID.Text = personID.ToString();
             lbTitle.Text = "Update Person";
         
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEditForm_Load(object sender, EventArgs e)
        {
            fillCountriesInComboBox();
            dtmDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            setupForm();
        }

        private void lkSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;

                pbImage.Load(selectedFilePath);
                lkRemoveImage.Visible = true;
                selectedImagePath = selectedFilePath;
            }
        }

        private void lkRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbImage.ImageLocation = null;
            pbImage.Image = null;
            selectedImagePath = "";
            lkRemoveImage.Visible = false;
            setDefaultImage();
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            setDefaultImage();
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            setDefaultImage();
        }

        private void tbTextBox_Validating(object sender, CancelEventArgs e)
        {
            Guna2TextBox textBox = sender as Guna2TextBox;
            

            if (textBox == tbNationalNo)
            {
                if (PeopleBusiness.isPersonExistsByNationalNo(tbNationalNo.Text.Trim()))
                {
                    e.Cancel = true;
                    btnSave.Enabled = false;
                    errorProvider1.SetError(tbNationalNo, "National number is used for another person");
                }
            }
            else if(textBox == tbEmail)
            {
                if(!string.IsNullOrWhiteSpace(tbEmail.Text))
                {
                    if (!tbEmail.Text.Contains("@gmail.com"))
                    {
                        e.Cancel = true;
                        btnSave.Enabled = false;
                        errorProvider1.SetError(tbEmail, "email address should be in this format: person@gmail.com");
                    }
                }
               
            }


            
            
        }

        private void tbTextBox_Validated(object sender, EventArgs e)
        {

            Guna2TextBox textBox = sender as Guna2TextBox;
            if(textBox!=null)
            {
                errorProvider1.SetError(textBox,"");
            }

            btnSave.Enabled = true;
            

        }

    }
}
