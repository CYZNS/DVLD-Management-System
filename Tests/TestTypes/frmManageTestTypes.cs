using DVLD_BusinessLayer;
using DVLD_Project.Applications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Tests.TestTypes
{
    public partial class frmManageTestTypes : Form
    {
        public frmManageTestTypes()
        {
            InitializeComponent();
        }

        private void refreshForm()
        {
            dgvTestTypes.DataSource = TestTypeBusiness.getAllTestTypes();
            lbRecords.Text = dgvTestTypes.RowCount.ToString();
        }
        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {
            refreshForm();
        }

        private void showDetailsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int selectedID = (int)dgvTestTypes.CurrentRow.Cells["TestTypeID"].Value;

            frmUpdateTestTypes form = new frmUpdateTestTypes(selectedID);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
            refreshForm();
        }
    }
}
