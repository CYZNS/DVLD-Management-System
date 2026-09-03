namespace DVLD_Project.Driving_License
{
    partial class frmNewLocalDrivingLicenseApplication
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcApplicationInfo = new System.Windows.Forms.TabPage();
            this.lbApplicationDate = new System.Windows.Forms.Label();
            this.lbApplicationFees = new System.Windows.Forms.Label();
            this.cbLicenseClasses = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbApplicationID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tcPersonalInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new Guna.UI2.WinForms.Guna2GradientButton();
            this.personDetailsWithFilter1 = new DVLD_Project.Controls.PersonDetailsWithFilter();
            this.tbcDrivingLicenseApplicationIfno = new Guna.UI2.WinForms.Guna2TabControl();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tcApplicationInfo.SuspendLayout();
            this.tcPersonalInfo.SuspendLayout();
            this.tbcDrivingLicenseApplicationIfno.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcApplicationInfo
            // 
            this.tcApplicationInfo.Controls.Add(this.lbApplicationDate);
            this.tcApplicationInfo.Controls.Add(this.lbApplicationFees);
            this.tcApplicationInfo.Controls.Add(this.cbLicenseClasses);
            this.tcApplicationInfo.Controls.Add(this.lbUser);
            this.tcApplicationInfo.Controls.Add(this.label4);
            this.tcApplicationInfo.Controls.Add(this.label6);
            this.tcApplicationInfo.Controls.Add(this.lbApplicationID);
            this.tcApplicationInfo.Controls.Add(this.label5);
            this.tcApplicationInfo.Controls.Add(this.label3);
            this.tcApplicationInfo.Controls.Add(this.label1);
            this.tcApplicationInfo.Location = new System.Drawing.Point(4, 44);
            this.tcApplicationInfo.Name = "tcApplicationInfo";
            this.tcApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tcApplicationInfo.Size = new System.Drawing.Size(1049, 715);
            this.tcApplicationInfo.TabIndex = 1;
            this.tcApplicationInfo.Text = "Application Info";
            this.tcApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // lbApplicationDate
            // 
            this.lbApplicationDate.AutoSize = true;
            this.lbApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationDate.Location = new System.Drawing.Point(320, 158);
            this.lbApplicationDate.Name = "lbApplicationDate";
            this.lbApplicationDate.Size = new System.Drawing.Size(56, 25);
            this.lbApplicationDate.TabIndex = 23;
            this.lbApplicationDate.Text = "????";
            // 
            // lbApplicationFees
            // 
            this.lbApplicationFees.AutoSize = true;
            this.lbApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationFees.Location = new System.Drawing.Point(309, 259);
            this.lbApplicationFees.Name = "lbApplicationFees";
            this.lbApplicationFees.Size = new System.Drawing.Size(56, 25);
            this.lbApplicationFees.TabIndex = 22;
            this.lbApplicationFees.Text = "????";
            // 
            // cbLicenseClasses
            // 
            this.cbLicenseClasses.BackColor = System.Drawing.Color.Transparent;
            this.cbLicenseClasses.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLicenseClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLicenseClasses.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLicenseClasses.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLicenseClasses.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLicenseClasses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbLicenseClasses.ItemHeight = 30;
            this.cbLicenseClasses.Location = new System.Drawing.Point(314, 199);
            this.cbLicenseClasses.Name = "cbLicenseClasses";
            this.cbLicenseClasses.Size = new System.Drawing.Size(293, 36);
            this.cbLicenseClasses.TabIndex = 21;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(297, 311);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(56, 25);
            this.lbUser.TabIndex = 20;
            this.lbUser.Text = "????";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Created By:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "ApplicationFees:";
            // 
            // lbApplicationID
            // 
            this.lbApplicationID.AutoSize = true;
            this.lbApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationID.Location = new System.Drawing.Point(320, 97);
            this.lbApplicationID.Name = "lbApplicationID";
            this.lbApplicationID.Size = new System.Drawing.Size(56, 25);
            this.lbApplicationID.TabIndex = 14;
            this.lbApplicationID.Text = "????";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Application Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "License Class:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "L.D.ApplicationID:";
            // 
            // tcPersonalInfo
            // 
            this.tcPersonalInfo.Controls.Add(this.btnNext);
            this.tcPersonalInfo.Controls.Add(this.personDetailsWithFilter1);
            this.tcPersonalInfo.Location = new System.Drawing.Point(4, 44);
            this.tcPersonalInfo.Name = "tcPersonalInfo";
            this.tcPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tcPersonalInfo.Size = new System.Drawing.Size(1049, 715);
            this.tcPersonalInfo.TabIndex = 0;
            this.tcPersonalInfo.Text = "Personal Info";
            this.tcPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(839, 672);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(170, 37);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            // 
            // personDetailsWithFilter1
            // 
            this.personDetailsWithFilter1.FilterEnabled = true;
            this.personDetailsWithFilter1.Location = new System.Drawing.Point(3, 3);
            this.personDetailsWithFilter1.Name = "personDetailsWithFilter1";
            this.personDetailsWithFilter1.Size = new System.Drawing.Size(1033, 631);
            this.personDetailsWithFilter1.TabIndex = 1;
            // 
            // tbcDrivingLicenseApplicationIfno
            // 
            this.tbcDrivingLicenseApplicationIfno.Controls.Add(this.tcPersonalInfo);
            this.tbcDrivingLicenseApplicationIfno.Controls.Add(this.tcApplicationInfo);
            this.tbcDrivingLicenseApplicationIfno.ItemSize = new System.Drawing.Size(180, 40);
            this.tbcDrivingLicenseApplicationIfno.Location = new System.Drawing.Point(12, 3);
            this.tbcDrivingLicenseApplicationIfno.Name = "tbcDrivingLicenseApplicationIfno";
            this.tbcDrivingLicenseApplicationIfno.SelectedIndex = 0;
            this.tbcDrivingLicenseApplicationIfno.Size = new System.Drawing.Size(1057, 763);
            this.tbcDrivingLicenseApplicationIfno.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tbcDrivingLicenseApplicationIfno.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tbcDrivingLicenseApplicationIfno.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tbcDrivingLicenseApplicationIfno.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tbcDrivingLicenseApplicationIfno.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tbcDrivingLicenseApplicationIfno.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tbcDrivingLicenseApplicationIfno.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tbcDrivingLicenseApplicationIfno.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tbcDrivingLicenseApplicationIfno.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tbcDrivingLicenseApplicationIfno.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tbcDrivingLicenseApplicationIfno.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tbcDrivingLicenseApplicationIfno.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tbcDrivingLicenseApplicationIfno.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tbcDrivingLicenseApplicationIfno.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tbcDrivingLicenseApplicationIfno.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tbcDrivingLicenseApplicationIfno.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tbcDrivingLicenseApplicationIfno.TabIndex = 0;
            this.tbcDrivingLicenseApplicationIfno.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tbcDrivingLicenseApplicationIfno.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // btnSave
            // 
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(865, 772);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(170, 37);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            // 
            // btnClose
            // 
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(673, 772);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(170, 37);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            // 
            // frmNewLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 846);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbcDrivingLicenseApplicationIfno);
            this.Name = "frmNewLocalDrivingLicenseApplication";
            this.Text = "frmNewLocalDrivingLicenseApplication";
            this.tcApplicationInfo.ResumeLayout(false);
            this.tcApplicationInfo.PerformLayout();
            this.tcPersonalInfo.ResumeLayout(false);
            this.tbcDrivingLicenseApplicationIfno.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tcApplicationInfo;
        private System.Windows.Forms.TabPage tcPersonalInfo;
        private Guna.UI2.WinForms.Guna2GradientButton btnNext;
        private Controls.PersonDetailsWithFilter personDetailsWithFilter1;
        private Guna.UI2.WinForms.Guna2TabControl tbcDrivingLicenseApplicationIfno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbApplicationID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbLicenseClasses;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbApplicationDate;
        private System.Windows.Forms.Label lbApplicationFees;
        private Guna.UI2.WinForms.Guna2GradientButton btnSave;
        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
    }
}