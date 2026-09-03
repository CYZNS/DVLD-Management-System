using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Models;
using DVLD_BusinessLayer;


namespace DVLD_Project.Applications
{
    public partial class frmUpdateApplicationType : Form
    {
        private int _ApplicationTypeID = -1;

        private ApplicationType ApplicationType;
        public frmUpdateApplicationType(int ApplicationTypeID)
        {
            InitializeComponent();
            _ApplicationTypeID = ApplicationTypeID; 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            ApplicationType.ApplicationTitle = tbApplicationTypeTitle.Text.Trim();
            if (decimal.TryParse(tbApplicationTypeFees.Text, out decimal fee))
            {
                ApplicationType.ApplicationFees = fee;
            }
            else
            {
                MessageBox.Show("Please enter a valid number!");
                return;
            }

            if(ApplicationTypeBusiness.UpdateApplicationType(ApplicationType))
            {
                MessageBox.Show("Application Type updated successfuly");
            }    
            else
            {
                MessageBox.Show("Error updating Application Type");
            }
        }
        private void loadApplicationTypeDetails(int applicationTypeID)
        {
            ApplicationType = ApplicationTypeBusiness.FindApplicationType(applicationTypeID);
            if (ApplicationType != null)
            {
                lbApplicationTypeID.Text = ApplicationType.ApplicationID.ToString();
                tbApplicationTypeTitle.Text = ApplicationType.ApplicationTitle;
                tbApplicationTypeFees.Text = ApplicationType.ApplicationFees.ToString();
            }
            else
            {
                MessageBox.Show("error");
                this.Close();
                return;
            }
        }
        private void frmUpdateApplicationType_Load(object sender, EventArgs e)
        {
           loadApplicationTypeDetails(_ApplicationTypeID);
        }

        private void tbApplicationTypeTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbApplicationTypeTitle.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbApplicationTypeTitle, "Title cannot be empty!");
            }
            else
            {
                errorProvider1.SetError(tbApplicationTypeTitle, "");
            }
            
        }

        private void tbApplicationTypeFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbApplicationTypeFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbApplicationTypeFees, "Fees cannot be empty!");
                return;
            }
            else
            {
                errorProvider1.SetError(tbApplicationTypeFees, null);

            }
            
        }

        private void tbApplicationTypeTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbApplicationTypeFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
