using DVLD.Models;
using DVLD_BusinessLayer;
using DVLD_Project.Users;
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
    public partial class ManageUsersForm : Form
    {
        private DataTable dtUsers;

        public ManageUsersForm()
        {
            InitializeComponent();
        }

        private void refreshForm()
        {
            dtUsers = UserBusiness.getAllUsersWithPersonFullName();
            dgvUsers.DataSource = dtUsers;
            lbRecords.Text = dgvUsers.RowCount.ToString();
            cbFilterBy.SelectedIndex = 0;
        }
        private void ManageUsersForm_Load(object sender, EventArgs e)
        {
            refreshForm();
        }
        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilterBy.Text = "";
            cbIsActiveFilter.SelectedIndex = 0;
            if(cbFilterBy.Text == "None")
            {
                dtUsers.DefaultView.RowFilter = "";
            }
            cbIsActiveFilter.Visible = (cbFilterBy.Text == "IsActive" && cbFilterBy.Text != "None");
            tbFilterBy.Visible = (cbFilterBy.Text != "None" && cbFilterBy.Text!="IsActive");
        }
        private void tbFilterBy_TextChanged(object sender, EventArgs e)
        {
            string filterBy = cbFilterBy.Text.Trim();

            if (string.IsNullOrWhiteSpace(tbFilterBy.Text) || filterBy == "IsActive")
            {
                dtUsers.DefaultView.RowFilter = "";
                return;
            }
            if (filterBy == "UserID" || filterBy == "PersonID")
            {
                dtUsers.DefaultView.RowFilter = $"{filterBy} = {tbFilterBy.Text}";
                return;
            }
            
            // filtering for userName or Full Name
            dtUsers.DefaultView.RowFilter = $"{filterBy} Like '{tbFilterBy.Text}%' ";

        }
        private void tbFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "PersonID" || cbFilterBy.Text == "UserID")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }

            }
            // fullname can't contain digits 
            else if (cbFilterBy.Text == "FullName")
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                {
                    e.Handled = true;
                }
            }
            
               
        }
        private void cbIsActiveFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbIsActiveFilter.Text == "All")
            {
                dtUsers.DefaultView.RowFilter = "";
                return;
            }

            bool? isActiveFilter = null;
                if (cbIsActiveFilter.Text == "Yes")
                    isActiveFilter = true;
                else if (cbIsActiveFilter.Text == "No")
                    isActiveFilter = false;
                
                dtUsers.DefaultView.RowFilter = $"IsActive = {isActiveFilter}";
                return;
            
        }
        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgvUsers.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this User?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int selectedID = (int)dgvUsers.CurrentRow.Cells["UserID"].Value;
                    if (UserBusiness.DeleteUser(selectedID))
                    {
                        MessageBox.Show("user deleted successfuly");
                        refreshForm();
                    }
                    else
                        MessageBox.Show("error deleting the User");
                }
            }
        }
        private void showAddUserForm()
        {
            AddEditUserForm form = new AddEditUserForm();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
            refreshForm();
        }
        private void pbAddUser_Click(object sender, EventArgs e)
        {
            showAddUserForm();
        }
        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to edit this User?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int selectedID = (int)dgvUsers.CurrentRow.Cells["UserID"].Value;
                    AddEditUserForm form = new AddEditUserForm(selectedID);
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
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedUserID = (int)dgvUsers.CurrentRow.Cells["UserID"].Value;

            frmShowUserDetails frm = new frmShowUserDetails(selectedUserID);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedUserID = (int)dgvUsers.CurrentRow.Cells["UserID"].Value;

            frmChangePassword frm = new frmChangePassword(selectedUserID);
            frm.StartPosition =FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showAddUserForm();
        }   

        //private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string filter = cbFilterBy.Text;

        //    // Reset fields when changing filters
        //    tbFilterBy.Text = "";
        //    cbIsActiveFilter.SelectedIndex = 0;

        //    // Clean, non-redundant visibility logic
        //    cbIsActiveFilter.Visible = (filter == "Is Active");
        //    tbFilterBy.Visible = (filter != "None" && filter != "Is Active");

        //    if (filter == "None")
        //    {
        //        dtUsers.DefaultView.RowFilter = "";
        //    }
        //    else if (tbFilterBy.Visible)
        //    {
        //        tbFilterBy.Focus();
        //    }
        //}

        //private void tbFilterBy_TextChanged(object sender, EventArgs e)
        //{
        //    string filterColumn = "";

        //    // Keep the mapping! It is much better for the User Experience.
        //    switch (cbFilterBy.Text)
        //    {
        //        case "User ID": filterColumn = "UserID"; break;
        //        case "UserName": filterColumn = "UserName"; break;
        //        case "Person ID": filterColumn = "PersonID"; break;
        //        case "Full Name": filterColumn = "FullName"; break;
        //        default: filterColumn = "None"; break;
        //    }

        //    string filterValue = tbFilterBy.Text.Trim();

        //    if (string.IsNullOrWhiteSpace(filterValue) || filterColumn == "None")
        //    {
        //        dtUsers.DefaultView.RowFilter = "";
        //        return;
        //    }

        //    // Apply Filters safely using modern string interpolation ($"")
        //    if (filterColumn == "UserID" || filterColumn == "PersonID")
        //    {
        //        // PREVENTS CRASH: Only apply if the user typed numbers
        //        if (int.TryParse(filterValue, out int num))
        //            dtUsers.DefaultView.RowFilter = $"{filterColumn} = {num}";
        //        else
        //            dtUsers.DefaultView.RowFilter = "1 = 0"; // Shows no results if they typed letters
        //    }
        //    else
        //    {
        //        // String filtering
        //        dtUsers.DefaultView.RowFilter = $"{filterColumn} LIKE '{filterValue}%'";
        //    }
        //}
    }
}
