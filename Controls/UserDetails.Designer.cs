namespace DVLD_Project.Controls
{
    partial class UserDetails
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.personDetails1 = new DVLD_Project.PersonDetails();
            this.gpLoginInformation = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lbIsActive = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbUserName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbUserID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gpLoginInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // personDetails1
            // 
            this.personDetails1.Location = new System.Drawing.Point(0, 0);
            this.personDetails1.Name = "personDetails1";
            this.personDetails1.Size = new System.Drawing.Size(1025, 524);
            this.personDetails1.TabIndex = 0;
            // 
            // gpLoginInformation
            // 
            this.gpLoginInformation.Controls.Add(this.lbIsActive);
            this.gpLoginInformation.Controls.Add(this.lbUserName);
            this.gpLoginInformation.Controls.Add(this.guna2HtmlLabel3);
            this.gpLoginInformation.Controls.Add(this.guna2HtmlLabel2);
            this.gpLoginInformation.Controls.Add(this.lbUserID);
            this.gpLoginInformation.Controls.Add(this.guna2HtmlLabel1);
            this.gpLoginInformation.CustomBorderColor = System.Drawing.Color.DodgerBlue;
            this.gpLoginInformation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gpLoginInformation.ForeColor = System.Drawing.Color.Black;
            this.gpLoginInformation.Location = new System.Drawing.Point(3, 530);
            this.gpLoginInformation.Name = "gpLoginInformation";
            this.gpLoginInformation.Size = new System.Drawing.Size(994, 118);
            this.gpLoginInformation.TabIndex = 1;
            this.gpLoginInformation.Text = "Login Information";
            // 
            // lbIsActive
            // 
            this.lbIsActive.BackColor = System.Drawing.Color.Transparent;
            this.lbIsActive.Location = new System.Drawing.Point(738, 72);
            this.lbIsActive.Name = "lbIsActive";
            this.lbIsActive.Size = new System.Drawing.Size(31, 18);
            this.lbIsActive.TabIndex = 5;
            this.lbIsActive.Text = "????";
            // 
            // lbUserName
            // 
            this.lbUserName.BackColor = System.Drawing.Color.Transparent;
            this.lbUserName.Location = new System.Drawing.Point(433, 72);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(31, 18);
            this.lbUserName.TabIndex = 4;
            this.lbUserName.Text = "????";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(617, 72);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(56, 18);
            this.guna2HtmlLabel3.TabIndex = 3;
            this.guna2HtmlLabel3.Text = "Is Active:";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(321, 72);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(72, 18);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "UserName:";
            // 
            // lbUserID
            // 
            this.lbUserID.BackColor = System.Drawing.Color.Transparent;
            this.lbUserID.Location = new System.Drawing.Point(212, 72);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(31, 18);
            this.lbUserID.TabIndex = 1;
            this.lbUserID.Text = "????";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(120, 72);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(48, 18);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "UserID:";
            // 
            // UserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpLoginInformation);
            this.Controls.Add(this.personDetails1);
            this.Name = "UserDetails";
            this.Size = new System.Drawing.Size(1025, 653);
            this.gpLoginInformation.ResumeLayout(false);
            this.gpLoginInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PersonDetails personDetails1;
        private Guna.UI2.WinForms.Guna2GroupBox gpLoginInformation;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbUserID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbIsActive;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbUserName;
    }
}
