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
    public partial class frmShowDrivers : Form
    {
        DataTable dtDrivers;
        public frmShowDrivers()
        {
            InitializeComponent();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilterBy.Text = "";
            if (cbFilterBy.Text == "None")
            {
                dtDrivers.DefaultView.RowFilter = "";
            }
            tbFilterBy.Visible = (cbFilterBy.Text != "None");
        }

        private void frmShowDrivers_Load(object sender, EventArgs e)
        {
            dtDrivers = DriverBusiness.GetAllDrivers();
            dgvDrivers.DataSource = dtDrivers;
        }

        private void tbFilterBy_TextChanged(object sender, EventArgs e)
        {
            string filterBy = cbFilterBy.Text;

            if (string.IsNullOrWhiteSpace(tbFilterBy.Text))
            {
                dtDrivers.DefaultView.RowFilter = "";
                return;
            }
            if (filterBy == "DriverID"||filterBy =="PersonID")
            {

                dtDrivers.DefaultView.RowFilter = $"{filterBy} = {tbFilterBy.Text}";
                return;
            }
            dtDrivers.DefaultView.RowFilter = $"{filterBy} Like '{tbFilterBy.Text}%' ";
        }

        private void tbFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "PersonID" || cbFilterBy.Text == "DriverID")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }

            }
        }
    }
}
