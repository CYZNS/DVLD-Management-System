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
    public partial class frmPersonDetails : Form
    {
        int personID = -1;
        // event to tell the managePeopleForm to  refresh the grid whenever we edit the person inside the showPersonDetails
        // note: we can do the same thing by putting a boolean here to check if the userControl updated ( by the control event)
        // then in the managePeople we can check if the boolean is true we refresh , otherwise we don't
        public delegate void PersonUpdatedEventHandler();
        public event PersonUpdatedEventHandler OnPersonUpdated;
        public frmPersonDetails(int personID)
        {
            InitializeComponent();
            this.personID=personID;
            personDetails1.OnPersonUpdated += ControlUpdated;
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPersonDetails_Load(object sender, EventArgs e)
        {

            People person = PeopleBusiness.FindPerson(personID);
            if (person != null)
            {
                personDetails1.loadPersonDetails(person);
            }
        }

        
        private void ControlUpdated()
        {
            OnPersonUpdated?.Invoke();
        }
    }
}
