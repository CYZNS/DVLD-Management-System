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
    public partial class ManagePeopleForm : Form
    {
        private DataTable dtPeople = PeopleBusiness.getAllPeople();
        public ManagePeopleForm()
        {
            InitializeComponent();
        }
        private void refreshForm()
        {
            dtPeople = PeopleBusiness.getAllPeople();
            dgvPeople.DataSource = dtPeople;
            lbRecords.Text = dgvPeople.RowCount.ToString();
        }
        private void ManagePeopleForm_Load(object sender, EventArgs e)
        {
            refreshForm();
        }
        private void showAddPersonForm()
        {
            AddEditPersonForm form = new AddEditPersonForm(-1);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
            refreshForm();
        }
        private void pbAddPerson_Click(object sender, EventArgs e)
        {
            showAddPersonForm();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showAddPersonForm();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgvPeople.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this person?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    int selectedID = (int)dgvPeople.CurrentRow.Cells["PersonID"].Value;
                    if (PeopleBusiness.deletePerson(selectedID))
                    {
                        MessageBox.Show("person delete successfuly");
                        refreshForm();
                    }
                    else
                        MessageBox.Show("error deleting the person");
                }

            }
            else
            {
                MessageBox.Show("Error couldn't delete person.");
            }
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPeople.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to edit this person?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int selectedID = (int)dgvPeople.CurrentRow.Cells["PersonID"].Value;
                    AddEditPersonForm form = new AddEditPersonForm(selectedID);
                    form.StartPosition = FormStartPosition.CenterScreen;
                    form.ShowDialog();
                    refreshForm();
                }

            }
            else
            {
                MessageBox.Show("Error couldn't update person.");
            }
        }
        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilterBy.Text = "";
            if (cbFilterBy.Text == "None")
            {
                dtPeople.DefaultView.RowFilter = "";
            }
            tbFilterBy.Visible = (cbFilterBy.Text != "None");
        }
        private void tbFilterBy_TextChanged(object sender, EventArgs e)
        {
            string filterBy = cbFilterBy.Text;

            if (string.IsNullOrWhiteSpace(tbFilterBy.Text))
            {
                dtPeople.DefaultView.RowFilter = "";
                return;
            }
            if (filterBy == "PersonID")
            {
                
                dtPeople.DefaultView.RowFilter = $"PersonID = {tbFilterBy.Text}";
                return;
            }
            
            if(filterBy == "Gender")
            {
                dtPeople.DefaultView.RowFilter = $"Gendor ={tbFilterBy.Text}";
                return;
            }

            dtPeople.DefaultView.RowFilter = $"{filterBy} Like '{tbFilterBy.Text}%' ";
            
        }
        private void tbFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilterBy.Text == "PersonID" || cbFilterBy.Text =="Gender")
            {
                if(!char.IsDigit(e.KeyChar)&& !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
               
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedID = (int)dgvPeople.CurrentRow.Cells["PersonID"].Value;
            frmPersonDetails form = new frmPersonDetails(selectedID);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.OnPersonUpdated += refreshForm;
            form.ShowDialog();
        }
    }
}
