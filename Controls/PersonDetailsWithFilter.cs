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
    public partial class PersonDetailsWithFilter : UserControl
    {
        public int personID { get; private set; } = -1;

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                gpFilter.Enabled = _FilterEnabled;
            }
        }
        public PersonDetailsWithFilter()
        {
            InitializeComponent();
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(tbFindBy.Text))
            {
                People person;

                if(cbFilterBy.Text =="National No")
                     person = PeopleBusiness.FindPerson(tbFindBy.Text.ToUpper());
                else
                    person = PeopleBusiness.FindPerson(int.Parse(tbFindBy.Text));

                if (person != null)
                {
                    personDetails1.loadPersonDetails(person);
                    this.personID = personDetails1.personID;

                }
                else
                {
                    MessageBox.Show($"No Person with National No. = {tbFindBy.Text} exists");
                    personID = -1;
                    personDetails1.resetPersonInfo();
                }
            }
        }
        public void disableAndSetupGPFilerForUpdateMode()
        {
            this.personID = personDetails1.personID;
            tbFindBy.Text = personID.ToString();
        }
        public void loadPersonDetailsForUpdate(People person)
        {
            personDetails1.loadPersonDetails(person);
            disableAndSetupGPFilerForUpdateMode();
        }
        private void showAddEditPersonFormForEdit()
        {
            AddEditPersonForm form = new AddEditPersonForm(-1);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.OnPersonAdded += loadPersonDetailsForUpdate;
            form.ShowDialog();
        }
        private void pbAddPerson_Click(object sender, EventArgs e)
        {
            showAddEditPersonFormForEdit();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFindBy.Text = "";
        }

        private void tbFindBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilterBy.Text == "PersonID")
            {
                if(!char.IsDigit(e.KeyChar)&& !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
