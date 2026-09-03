namespace DVLD_Project.Driving_License
{
    partial class frmManageLocalDrivingLicenseApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageLocalDrivingLicenseApplications));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbIsActiveFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbRecords = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbFilterBy = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbFilterBy = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pbAddUser = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dgvLocalDrivingApplications = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingApplications)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbIsActiveFilter
            // 
            this.cbIsActiveFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbIsActiveFilter.BorderRadius = 10;
            this.cbIsActiveFilter.BorderThickness = 3;
            this.cbIsActiveFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbIsActiveFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsActiveFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbIsActiveFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbIsActiveFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbIsActiveFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbIsActiveFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbIsActiveFilter.HoverState.FillColor = System.Drawing.Color.Silver;
            this.cbIsActiveFilter.ItemHeight = 30;
            this.cbIsActiveFilter.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsActiveFilter.ItemsAppearance.SelectedBackColor = System.Drawing.Color.Red;
            this.cbIsActiveFilter.Location = new System.Drawing.Point(295, 144);
            this.cbIsActiveFilter.Name = "cbIsActiveFilter";
            this.cbIsActiveFilter.Size = new System.Drawing.Size(168, 36);
            this.cbIsActiveFilter.StartIndex = 0;
            this.cbIsActiveFilter.TabIndex = 28;
            this.cbIsActiveFilter.Visible = false;
            // 
            // lbRecords
            // 
            this.lbRecords.BackColor = System.Drawing.Color.Transparent;
            this.lbRecords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecords.Location = new System.Drawing.Point(141, 699);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(21, 30);
            this.lbRecords.TabIndex = 27;
            this.lbRecords.Text = "??";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(32, 699);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(101, 30);
            this.guna2HtmlLabel1.TabIndex = 26;
            this.guna2HtmlLabel1.Text = " # Records:";
            // 
            // tbFilterBy
            // 
            this.tbFilterBy.Animated = true;
            this.tbFilterBy.BorderRadius = 10;
            this.tbFilterBy.BorderThickness = 3;
            this.tbFilterBy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFilterBy.DefaultText = "";
            this.tbFilterBy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbFilterBy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbFilterBy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFilterBy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFilterBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFilterBy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbFilterBy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFilterBy.Location = new System.Drawing.Point(295, 149);
            this.tbFilterBy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbFilterBy.Name = "tbFilterBy";
            this.tbFilterBy.PlaceholderText = "";
            this.tbFilterBy.SelectedText = "";
            this.tbFilterBy.Size = new System.Drawing.Size(230, 31);
            this.tbFilterBy.TabIndex = 25;
            this.tbFilterBy.Visible = false;
            this.tbFilterBy.TextChanged += new System.EventHandler(this.tbFilterBy_TextChanged);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterBy.BorderRadius = 10;
            this.cbFilterBy.BorderThickness = 3;
            this.cbFilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbFilterBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFilterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFilterBy.HoverState.BorderColor = System.Drawing.Color.Lime;
            this.cbFilterBy.HoverState.FillColor = System.Drawing.Color.Silver;
            this.cbFilterBy.ItemHeight = 30;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "L.D.L.AppID",
            "NationalNo",
            "FullName",
            "Status"});
            this.cbFilterBy.ItemsAppearance.SelectedBackColor = System.Drawing.Color.Red;
            this.cbFilterBy.Location = new System.Drawing.Point(102, 149);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(168, 36);
            this.cbFilterBy.StartIndex = 0;
            this.cbFilterBy.TabIndex = 24;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // lbFilterBy
            // 
            this.lbFilterBy.BackColor = System.Drawing.Color.Transparent;
            this.lbFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilterBy.Location = new System.Drawing.Point(22, 153);
            this.lbFilterBy.Name = "lbFilterBy";
            this.lbFilterBy.Size = new System.Drawing.Size(74, 27);
            this.lbFilterBy.TabIndex = 23;
            this.lbFilterBy.Text = "FilterBy:";
            // 
            // pbAddUser
            // 
            this.pbAddUser.BackColor = System.Drawing.Color.Transparent;
            this.pbAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddUser.FillColor = System.Drawing.Color.Transparent;
            this.pbAddUser.Image = ((System.Drawing.Image)(resources.GetObject("pbAddUser.Image")));
            this.pbAddUser.ImageRotate = 0F;
            this.pbAddUser.Location = new System.Drawing.Point(1195, 123);
            this.pbAddUser.Name = "pbAddUser";
            this.pbAddUser.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbAddUser.Size = new System.Drawing.Size(73, 62);
            this.pbAddUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddUser.TabIndex = 22;
            this.pbAddUser.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.BorderRadius = 7;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1253, 699);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(127, 42);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            // 
            // dgvLocalDrivingApplications
            // 
            this.dgvLocalDrivingApplications.AllowUserToAddRows = false;
            this.dgvLocalDrivingApplications.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.dgvLocalDrivingApplications.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLocalDrivingApplications.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLocalDrivingApplications.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLocalDrivingApplications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLocalDrivingApplications.ColumnHeadersHeight = 29;
            this.dgvLocalDrivingApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvLocalDrivingApplications.ContextMenuStrip = this.guna2ContextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLocalDrivingApplications.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLocalDrivingApplications.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dgvLocalDrivingApplications.Location = new System.Drawing.Point(22, 191);
            this.dgvLocalDrivingApplications.MultiSelect = false;
            this.dgvLocalDrivingApplications.Name = "dgvLocalDrivingApplications";
            this.dgvLocalDrivingApplications.ReadOnly = true;
            this.dgvLocalDrivingApplications.RowHeadersVisible = false;
            this.dgvLocalDrivingApplications.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgvLocalDrivingApplications.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLocalDrivingApplications.RowTemplate.Height = 24;
            this.dgvLocalDrivingApplications.Size = new System.Drawing.Size(1246, 426);
            this.dgvLocalDrivingApplications.TabIndex = 20;
            this.dgvLocalDrivingApplications.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightBlue;
            this.dgvLocalDrivingApplications.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.dgvLocalDrivingApplications.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dgvLocalDrivingApplications.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.dgvLocalDrivingApplications.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvLocalDrivingApplications.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLocalDrivingApplications.ThemeStyle.HeaderStyle.Height = 29;
            this.dgvLocalDrivingApplications.ThemeStyle.ReadOnly = true;
            this.dgvLocalDrivingApplications.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.dgvLocalDrivingApplications.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLocalDrivingApplications.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvLocalDrivingApplications.ThemeStyle.RowsStyle.Height = 24;
            this.dgvLocalDrivingApplications.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            this.dgvLocalDrivingApplications.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(155, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1130, 81);
            this.label1.TabIndex = 19;
            this.label1.Text = "Manage Driving License Applications";
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(211, 56);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.editToolStripMenuItem.Text = "edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // frmManageLocalDrivingLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 778);
            this.Controls.Add(this.cbIsActiveFilter);
            this.Controls.Add(this.lbRecords);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.tbFilterBy);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.lbFilterBy);
            this.Controls.Add(this.pbAddUser);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvLocalDrivingApplications);
            this.Controls.Add(this.label1);
            this.Name = "frmManageLocalDrivingLicenseApplications";
            this.Text = "frmManageDrivingLicenseApplication";
            this.Load += new System.EventHandler(this.frmManageDrivingLicenseApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAddUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingApplications)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbIsActiveFilter;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbRecords;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox tbFilterBy;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterBy;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbFilterBy;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbAddUser;
        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
        private Guna.UI2.WinForms.Guna2DataGridView dgvLocalDrivingApplications;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}