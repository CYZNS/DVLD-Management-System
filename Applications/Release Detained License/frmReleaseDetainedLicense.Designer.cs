namespace DVLD_Project.Detain_License
{
    partial class frmReleaseDetainedLicense
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
            this.btnRelease = new Guna.UI2.WinForms.Guna2Button();
            this.lkLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.lkShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.gbApplicationLicenseReplacement = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lbTotalFees = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbApplicationID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbFineFees = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbLicenseID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbUserID = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDetainDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbDetainID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ctrlDriverLicenseInfoWithFilter1 = new DVLD_Project.Controls.ctrlDriverLicenseInfoWithFilter();
            this.gbApplicationLicenseReplacement.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRelease
            // 
            this.btnRelease.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRelease.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRelease.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRelease.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRelease.Enabled = false;
            this.btnRelease.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRelease.ForeColor = System.Drawing.Color.White;
            this.btnRelease.Location = new System.Drawing.Point(1137, 674);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(180, 45);
            this.btnRelease.TabIndex = 235;
            this.btnRelease.Text = "Release";
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // lkLicenseHistory
            // 
            this.lkLicenseHistory.AutoSize = true;
            this.lkLicenseHistory.Enabled = false;
            this.lkLicenseHistory.Location = new System.Drawing.Point(42, 703);
            this.lkLicenseHistory.Name = "lkLicenseHistory";
            this.lkLicenseHistory.Size = new System.Drawing.Size(135, 16);
            this.lkLicenseHistory.TabIndex = 234;
            this.lkLicenseHistory.TabStop = true;
            this.lkLicenseHistory.Text = "Show License History";
            this.lkLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkLicenseHistory_LinkClicked);
            // 
            // lkShowLicenseInfo
            // 
            this.lkShowLicenseInfo.AutoSize = true;
            this.lkShowLicenseInfo.Enabled = false;
            this.lkShowLicenseInfo.Location = new System.Drawing.Point(237, 703);
            this.lkShowLicenseInfo.Name = "lkShowLicenseInfo";
            this.lkShowLicenseInfo.Size = new System.Drawing.Size(144, 16);
            this.lkShowLicenseInfo.TabIndex = 233;
            this.lkShowLicenseInfo.TabStop = true;
            this.lkShowLicenseInfo.Text = "Show New License Info";
            this.lkShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkShowLicenseInfo_LinkClicked);
            // 
            // gbApplicationLicenseReplacement
            // 
            this.gbApplicationLicenseReplacement.BorderRadius = 10;
            this.gbApplicationLicenseReplacement.Controls.Add(this.lbTotalFees);
            this.gbApplicationLicenseReplacement.Controls.Add(this.label8);
            this.gbApplicationLicenseReplacement.Controls.Add(this.lbApplicationID);
            this.gbApplicationLicenseReplacement.Controls.Add(this.label6);
            this.gbApplicationLicenseReplacement.Controls.Add(this.lbFineFees);
            this.gbApplicationLicenseReplacement.Controls.Add(this.label12);
            this.gbApplicationLicenseReplacement.Controls.Add(this.lbLicenseID);
            this.gbApplicationLicenseReplacement.Controls.Add(this.label10);
            this.gbApplicationLicenseReplacement.Controls.Add(this.label2);
            this.gbApplicationLicenseReplacement.Controls.Add(this.lbUserID);
            this.gbApplicationLicenseReplacement.Controls.Add(this.lblApplicationFees);
            this.gbApplicationLicenseReplacement.Controls.Add(this.label3);
            this.gbApplicationLicenseReplacement.Controls.Add(this.lbDetainDate);
            this.gbApplicationLicenseReplacement.Controls.Add(this.label5);
            this.gbApplicationLicenseReplacement.Controls.Add(this.lbDetainID);
            this.gbApplicationLicenseReplacement.Controls.Add(this.label4);
            this.gbApplicationLicenseReplacement.CustomBorderColor = System.Drawing.Color.DodgerBlue;
            this.gbApplicationLicenseReplacement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbApplicationLicenseReplacement.ForeColor = System.Drawing.Color.Black;
            this.gbApplicationLicenseReplacement.Location = new System.Drawing.Point(10, 515);
            this.gbApplicationLicenseReplacement.Name = "gbApplicationLicenseReplacement";
            this.gbApplicationLicenseReplacement.Size = new System.Drawing.Size(1019, 165);
            this.gbApplicationLicenseReplacement.TabIndex = 232;
            this.gbApplicationLicenseReplacement.Text = "Detain Info";
            // 
            // lbTotalFees
            // 
            this.lbTotalFees.AutoSize = true;
            this.lbTotalFees.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalFees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalFees.Location = new System.Drawing.Point(575, 121);
            this.lbTotalFees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotalFees.Name = "lbTotalFees";
            this.lbTotalFees.Size = new System.Drawing.Size(53, 28);
            this.lbTotalFees.TabIndex = 238;
            this.lbTotalFees.Text = "[???]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(366, 121);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 28);
            this.label8.TabIndex = 237;
            this.label8.Text = "Total Fees:";
            // 
            // lbApplicationID
            // 
            this.lbApplicationID.AutoSize = true;
            this.lbApplicationID.BackColor = System.Drawing.Color.Transparent;
            this.lbApplicationID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationID.Location = new System.Drawing.Point(227, 121);
            this.lbApplicationID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbApplicationID.Name = "lbApplicationID";
            this.lbApplicationID.Size = new System.Drawing.Size(53, 28);
            this.lbApplicationID.TabIndex = 236;
            this.lbApplicationID.Text = "[???]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 121);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 28);
            this.label6.TabIndex = 235;
            this.label6.Text = "Application ID:";
            // 
            // lbFineFees
            // 
            this.lbFineFees.AutoSize = true;
            this.lbFineFees.BackColor = System.Drawing.Color.Transparent;
            this.lbFineFees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFineFees.Location = new System.Drawing.Point(847, 83);
            this.lbFineFees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFineFees.Name = "lbFineFees";
            this.lbFineFees.Size = new System.Drawing.Size(53, 28);
            this.lbFineFees.TabIndex = 234;
            this.lbFineFees.Text = "[???]";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(654, 83);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 28);
            this.label12.TabIndex = 233;
            this.label12.Text = "Fine Fees:";
            // 
            // lbLicenseID
            // 
            this.lbLicenseID.AutoSize = true;
            this.lbLicenseID.BackColor = System.Drawing.Color.Transparent;
            this.lbLicenseID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicenseID.Location = new System.Drawing.Point(575, 51);
            this.lbLicenseID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLicenseID.Name = "lbLicenseID";
            this.lbLicenseID.Size = new System.Drawing.Size(53, 28);
            this.lbLicenseID.TabIndex = 232;
            this.lbLicenseID.Text = "[???]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(366, 51);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 28);
            this.label10.TabIndex = 231;
            this.label10.Text = "LicenseID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(366, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 28);
            this.label2.TabIndex = 230;
            this.label2.Text = "Created By:";
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.BackColor = System.Drawing.Color.Transparent;
            this.lbUserID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserID.Location = new System.Drawing.Point(575, 83);
            this.lbUserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(62, 28);
            this.lbUserID.TabIndex = 229;
            this.lbUserID.Text = "[????]";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationFees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.Location = new System.Drawing.Point(838, 51);
            this.lblApplicationFees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(62, 28);
            this.lblApplicationFees.TabIndex = 228;
            this.lblApplicationFees.Text = "[$$$]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(657, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 28);
            this.label3.TabIndex = 227;
            this.label3.Text = "Application Fees:";
            // 
            // lbDetainDate
            // 
            this.lbDetainDate.AutoSize = true;
            this.lbDetainDate.BackColor = System.Drawing.Color.Transparent;
            this.lbDetainDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetainDate.Location = new System.Drawing.Point(227, 83);
            this.lbDetainDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDetainDate.Name = "lbDetainDate";
            this.lbDetainDate.Size = new System.Drawing.Size(116, 28);
            this.lbDetainDate.TabIndex = 226;
            this.lbDetainDate.Text = "[??/??/????]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 28);
            this.label5.TabIndex = 225;
            this.label5.Text = "Detain Date:";
            // 
            // lbDetainID
            // 
            this.lbDetainID.AutoSize = true;
            this.lbDetainID.BackColor = System.Drawing.Color.Transparent;
            this.lbDetainID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetainID.Location = new System.Drawing.Point(227, 51);
            this.lbDetainID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDetainID.Name = "lbDetainID";
            this.lbDetainID.Size = new System.Drawing.Size(53, 28);
            this.lbDetainID.TabIndex = 224;
            this.lbDetainID.Text = "[???]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 28);
            this.label4.TabIndex = 223;
            this.label4.Text = "Detain ID:";
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            this.ctrlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(10, 56);
            this.ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            this.ctrlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(1369, 443);
            this.ctrlDriverLicenseInfoWithFilter1.TabIndex = 231;
            // 
            // frmReleaseDetainedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 775);
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.lkLicenseHistory);
            this.Controls.Add(this.lkShowLicenseInfo);
            this.Controls.Add(this.gbApplicationLicenseReplacement);
            this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
            this.Name = "frmReleaseDetainedLicense";
            this.Text = "frmReleaseDetainedLicense";
            this.Load += new System.EventHandler(this.frmReleaseDetainedLicense_Load);
            this.gbApplicationLicenseReplacement.ResumeLayout(false);
            this.gbApplicationLicenseReplacement.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnRelease;
        private System.Windows.Forms.LinkLabel lkLicenseHistory;
        private System.Windows.Forms.LinkLabel lkShowLicenseInfo;
        private Guna.UI2.WinForms.Guna2GroupBox gbApplicationLicenseReplacement;
        private Controls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private System.Windows.Forms.Label lbTotalFees;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbApplicationID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbFineFees;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbLicenseID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbDetainDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbDetainID;
        private System.Windows.Forms.Label label4;
    }
}