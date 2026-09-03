using DVLD.Models;
using DVLD_BusinessLayer;
using Guna.UI2.WinForms;
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
    public partial class frmUpdateTestTypes : Form
    {
        private int _testTypeID = -1;
        private TestType testType;


        public frmUpdateTestTypes(int testTypeID)
        {
            InitializeComponent();
            this._testTypeID = testTypeID;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            testType.TestTypeTitle = tbTestTypeTitle.Text.Trim();
            testType.TestTypeDescription = tbTestDescription.Text.Trim();
            if (decimal.TryParse(tbTestTypeFees.Text, out decimal fee))
            {
                testType.TestTypeFees = fee;
            }
            else
            {
                MessageBox.Show("Please enter a valid number!");
                return;
            }

            if (TestTypeBusiness.updateTestType(testType))
            {
                MessageBox.Show("Test Type updated successfuly");
            }
            else
            {
                MessageBox.Show("Error updating Test Type");
            }
        }

        private void loadTestTypeDetails(int TestTypeID)
        {
            testType = TestTypeBusiness.FindTestType(TestTypeID);
            if (testType != null)
            {
                lbTestTypeID.Text = testType.TestTypeID.ToString();
                tbTestTypeTitle.Text = testType.TestTypeTitle;
                tbTestTypeFees.Text = testType.TestTypeFees.ToString();
                tbTestDescription.Text = testType.TestTypeDescription;
            }
            else
            {
                MessageBox.Show("error");
                this.Close();
                return;
            }
        }

        private void frmUpdateTestTypes_Load(object sender, EventArgs e)
        {
            loadTestTypeDetails(_testTypeID);
        }
        private void stringTextBoxes_Validating(object sender, CancelEventArgs e)
        {
            Guna2TextBox CurrentTextBoxValidating = sender as Guna2TextBox;

            if (string.IsNullOrEmpty(CurrentTextBoxValidating.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(CurrentTextBoxValidating, "Title cannot be empty!");
            }
            else
            {
                errorProvider1.SetError(CurrentTextBoxValidating, "");
            }
        }
        private void tbTestTypeFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbTestTypeFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbTestTypeFees, "Fees cannot be empty!");
                return;
            }
            else
            {
                errorProvider1.SetError(tbTestTypeFees, null);

            }
        }
        private void stringTextBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbTestTypeFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
