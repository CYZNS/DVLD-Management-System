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
    public partial class UserDetails : UserControl
    {
        public UserDetails()
        {
            InitializeComponent();
        }

        public void loadUserDetails(User user)
        {
            
            personDetails1.loadPersonDetails(user.Person);
            lbUserID.Text = user.UserID.ToString();
            lbUserName.Text = user.UserName;
            lbIsActive.Text = (user.IsActive == true) ? "YES" : "NO";
        }

    }
}
