using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_BusinessLayer;
using System.Windows.Forms;
using DVLD_Project.Users;
using DVLD_Project.Applications;

namespace DVLD_Project
{
    public partial class frmManageApplicationTypes : Form
    {
        public frmManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void refreshForm()
        {
            dgvApplicationTypes.DataSource = ApplicationTypeBusiness.getAllApplicationTypes();
            lbRecords.Text = dgvApplicationTypes.RowCount.ToString();
        }

        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            refreshForm();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedID = (int)dgvApplicationTypes.CurrentRow.Cells["ApplicationTypeID"].Value;

            frmUpdateApplicationType form = new frmUpdateApplicationType(selectedID);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
            refreshForm();
        }
    }
}
