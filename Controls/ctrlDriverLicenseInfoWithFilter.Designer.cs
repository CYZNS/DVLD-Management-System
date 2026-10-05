namespace DVLD_Project.Controls
{
    partial class ctrlDriverLicenseInfoWithFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlDriverLicenseInfoWithFilter));
            this.gpFilter = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tbLicenseID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbLicenseID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pbSearch = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ctrlDrivingLicneseInfo1 = new DVLD_Project.Controls.ctrlDrivingLicneseInfo();
            this.gpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // gpFilter
            // 
            this.gpFilter.BorderRadius = 10;
            this.gpFilter.Controls.Add(this.pbSearch);
            this.gpFilter.Controls.Add(this.tbLicenseID);
            this.gpFilter.Controls.Add(this.lbLicenseID);
            this.gpFilter.CustomBorderColor = System.Drawing.Color.DodgerBlue;
            this.gpFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gpFilter.ForeColor = System.Drawing.Color.Black;
            this.gpFilter.Location = new System.Drawing.Point(0, 0);
            this.gpFilter.Name = "gpFilter";
            this.gpFilter.Size = new System.Drawing.Size(1025, 107);
            this.gpFilter.TabIndex = 3;
            this.gpFilter.Text = "Filter";
            // 
            // tbLicenseID
            // 
            this.tbLicenseID.Animated = true;
            this.tbLicenseID.BorderRadius = 10;
            this.tbLicenseID.BorderThickness = 3;
            this.tbLicenseID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLicenseID.DefaultText = "";
            this.tbLicenseID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbLicenseID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbLicenseID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLicenseID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLicenseID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLicenseID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbLicenseID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLicenseID.Location = new System.Drawing.Point(147, 52);
            this.tbLicenseID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbLicenseID.Name = "tbLicenseID";
            this.tbLicenseID.PlaceholderText = "";
            this.tbLicenseID.SelectedText = "";
            this.tbLicenseID.Size = new System.Drawing.Size(230, 31);
            this.tbLicenseID.TabIndex = 17;
            // 
            // lbLicenseID
            // 
            this.lbLicenseID.BackColor = System.Drawing.Color.Transparent;
            this.lbLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicenseID.ForeColor = System.Drawing.Color.Black;
            this.lbLicenseID.Location = new System.Drawing.Point(12, 52);
            this.lbLicenseID.Name = "lbLicenseID";
            this.lbLicenseID.Size = new System.Drawing.Size(96, 27);
            this.lbLicenseID.TabIndex = 15;
            this.lbLicenseID.Text = "LicenseID:";
            // 
            // pbSearch
            // 
            this.pbSearch.BackColor = System.Drawing.Color.Transparent;
            this.pbSearch.BorderRadius = 10;
            this.pbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSearch.Image = ((System.Drawing.Image)(resources.GetObject("pbSearch.Image")));
            this.pbSearch.ImageRotate = 0F;
            this.pbSearch.Location = new System.Drawing.Point(590, 52);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(151, 44);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearch.TabIndex = 18;
            this.pbSearch.TabStop = false;
            this.pbSearch.UseTransparentBackground = true;
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // ctrlDrivingLicneseInfo1
            // 
            this.ctrlDrivingLicneseInfo1.Location = new System.Drawing.Point(-3, 113);
            this.ctrlDrivingLicneseInfo1.Name = "ctrlDrivingLicneseInfo1";
            this.ctrlDrivingLicneseInfo1.Size = new System.Drawing.Size(1371, 328);
            this.ctrlDrivingLicneseInfo1.TabIndex = 0;
            // 
            // ctrlDriverLicenseInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpFilter);
            this.Controls.Add(this.ctrlDrivingLicneseInfo1);
            this.Name = "ctrlDriverLicenseInfoWithFilter";
            this.Size = new System.Drawing.Size(1369, 443);
            this.gpFilter.ResumeLayout(false);
            this.gpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlDrivingLicneseInfo ctrlDrivingLicneseInfo1;
        private Guna.UI2.WinForms.Guna2GroupBox gpFilter;
        private Guna.UI2.WinForms.Guna2PictureBox pbSearch;
        private Guna.UI2.WinForms.Guna2TextBox tbLicenseID;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbLicenseID;
    }
}
