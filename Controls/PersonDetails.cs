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

namespace DVLD_Project
{
    public partial class PersonDetails : UserControl
    {

        public int personID { get; private set; } = -1;
        People currentPerson;
        // event to tell the frmPersonDetails that I edited a person here so we will not refresh the grid everytime we enter 
        //the showPersonDetails , even if we don't edited
        public delegate void PersonUpdatedEventHandler();
        public event PersonUpdatedEventHandler OnPersonUpdated;
        public PersonDetails()
        {
            InitializeComponent();
        }

        //public void loadPersonDetails(int personID)
        //{
        //    People person = PeopleBusiness.FindPerson(personID);

        //    if (person != null)
        //    {
        //        loadPersonDetails(person);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Person doesn't exist");
        //    }

        //}


        private void loadPersonImage()
        {
            if (currentPerson.Gender == 0)
            {
                lbGender.Text = "Male";
                pbProfilePicture.Image = Properties.Resources.gender_male;
            }
            else
            {
                lbGender.Text = "Female";
                pbProfilePicture.Image = Properties.Resources.gender_Female;

            }

            pbProfilePicture.ImageLocation = null;

            if (!string.IsNullOrWhiteSpace(currentPerson.ImagePath))
            {
                pbProfilePicture.ImageLocation = currentPerson.ImagePath;
            }
        }
        private void fillUserControlWithPersonDetails(People person)
        {
            this.personID = person.PersonID;
            lbName.Text = $"{person.FirstName} {person.SecondName} {person.LastName}";
            lbPersonID.Text = person.PersonID.ToString();
            lbNationalID.Text = person.NationalID;
            lbDateOfBirth.Text = person.DateOfBirth.ToString();
            lbEmail.Text = person.Email;
            lbPhone.Text = person.Phone;
            string countryName = CountriesBusiness.findCountry(person.NationalityCountryID).CountryName;
            lbCountry.Text = countryName;
            lbAddress.Text = person.Address;

            loadPersonImage();



        }
        public void loadPersonDetails(People person)
        {
            
            if (person != null)
            {
                currentPerson = person;
                fillUserControlWithPersonDetails(currentPerson);
            }
            else
            {
                MessageBox.Show("Person doesn't exist");
            }

        }
        private void showAddEditPersonFormForEdit(int personID)
        {
            AddEditPersonForm form = new AddEditPersonForm(personID);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.OnPersonAdded += loadPersonDetails;
            form.ShowDialog();
        }
        
        private void lkEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.personID != -1)
            {
               showAddEditPersonFormForEdit(this.personID);
                //loadPersonDetails(currentPerson); 
                OnPersonUpdated?.Invoke();
            }
            else
                MessageBox.Show("please load a person first");
           
        }
        public void resetPersonInfo()
        {
            personID = -1;
            lbName.Text = "????";
            lbPersonID.Text = "????";
            lbNationalID.Text = "????";
            lbGender.Text = "????";
            lbDateOfBirth.Text = "????";
            lbEmail.Text = "????";
            lbPhone.Text = "????";
            lbCountry.Text = "????";
            lbAddress.Text = "????";
            pbProfilePicture.Image = Properties.Resources.anonymous_man;
        }

        
    }
}
