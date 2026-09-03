using DVLD.Models;
using DVLD_BusinessLayer;
using DVLD_Project.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Users
{
    public partial class frmShowUserDetails : Form
    {
        private int _userID = -1;
        
        public frmShowUserDetails(int userID)
        {
            InitializeComponent();
            this._userID = userID;
        }

        private void frmShowUserDetails_Load(object sender, EventArgs e)
        {
            User user = UserBusiness.FindUser(_userID);
            userDetails1.loadUserDetails(user);
        }
    }
}
