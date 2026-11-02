namespace DVLD_Project.Controls
{
    partial class PersonDetailsWithFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonDetailsWithFilter));
            this.gpFilter = new Guna.UI2.WinForms.Guna2GroupBox();
            this.pbAddPerson = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbSearch = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tbFindBy = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbFilterBy = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.personDetails1 = new DVLD_Project.PersonDetails();
            this.gpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // gpFilter
            // 
            this.gpFilter.BorderRadius = 10;
            this.gpFilter.Controls.Add(this.pbAddPerson);
            this.gpFilter.Controls.Add(this.pbSearch);
            this.gpFilter.Controls.Add(this.tbFindBy);
            this.gpFilter.Controls.Add(this.cbFilterBy);
            this.gpFilter.Controls.Add(this.lbFilterBy);
            this.gpFilter.CustomBorderColor = System.Drawing.Color.DodgerBlue;
            this.gpFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gpFilter.ForeColor = System.Drawing.Color.Black;
            this.gpFilter.Location = new System.Drawing.Point(0, 0);
            this.gpFilter.Name = "gpFilter";
            this.gpFilter.Size = new System.Drawing.Size(1025, 107);
            this.gpFilter.TabIndex = 2;
            this.gpFilter.Text = "Filter";
            // 
            // pbAddPerson
            // 
            this.pbAddPerson.BackColor = System.Drawing.Color.Transparent;
            this.pbAddPerson.BorderRadius = 10;
            this.pbAddPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAddPerson.Image = ((System.Drawing.Image)(resources.GetObject("pbAddPerson.Image")));
            this.pbAddPerson.ImageRotate = 0F;
            this.pbAddPerson.Location = new System.Drawing.Point(836, 52);
            this.pbAddPerson.Name = "pbAddPerson";
            this.pbAddPerson.Size = new System.Drawing.Size(46, 44);
            this.pbAddPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddPerson.TabIndex = 19;
            this.pbAddPerson.TabStop = false;
            this.pbAddPerson.UseTransparentBackground = true;
            this.pbAddPerson.Click += new System.EventHandler(this.pbAddPerson_Click);
            // 
            // pbSearch
            // 
            this.pbSearch.BackColor = System.Drawing.Color.Transparent;
            this.pbSearch.BorderRadius = 10;
            this.pbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSearch.Image = ((System.Drawing.Image)(resources.GetObject("pbSearch.Image")));
            this.pbSearch.ImageRotate = 0F;
            this.pbSearch.Location = new System.Drawing.Point(760, 52);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(46, 44);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearch.TabIndex = 18;
            this.pbSearch.TabStop = false;
            this.pbSearch.UseTransparentBackground = true;
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // tbFindBy
            // 
            this.tbFindBy.Animated = true;
            this.tbFindBy.BorderRadius = 10;
            this.tbFindBy.BorderThickness = 3;
            this.tbFindBy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFindBy.DefaultText = "";
            this.tbFindBy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbFindBy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbFindBy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFindBy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFindBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFindBy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbFindBy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFindBy.Location = new System.Drawing.Point(267, 54);
            this.tbFindBy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbFindBy.Name = "tbFindBy";
            this.tbFindBy.PlaceholderText = "";
            this.tbFindBy.SelectedText = "";
            this.tbFindBy.Size = new System.Drawing.Size(230, 31);
            this.tbFindBy.TabIndex = 17;
            this.tbFindBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFindBy_KeyPress);
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
            "PersonID",
            "National No"});
            this.cbFilterBy.ItemsAppearance.SelectedBackColor = System.Drawing.Color.Red;
            this.cbFilterBy.Location = new System.Drawing.Point(93, 52);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(168, 36);
            this.cbFilterBy.StartIndex = 0;
            this.cbFilterBy.TabIndex = 16;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // lbFilterBy
            // 
            this.lbFilterBy.BackColor = System.Drawing.Color.Transparent;
            this.lbFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilterBy.ForeColor = System.Drawing.Color.Black;
            this.lbFilterBy.Location = new System.Drawing.Point(12, 52);
            this.lbFilterBy.Name = "lbFilterBy";
            this.lbFilterBy.Size = new System.Drawing.Size(75, 27);
            this.lbFilterBy.TabIndex = 15;
            this.lbFilterBy.Text = "Find By:";
            // 
            // personDetails1
            // 
            this.personDetails1.Location = new System.Drawing.Point(0, 113);
            this.personDetails1.Name = "personDetails1";
            this.personDetails1.Size = new System.Drawing.Size(1025, 524);
            this.personDetails1.TabIndex = 0;
            // 
            // PersonDetailsWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpFilter);
            this.Controls.Add(this.personDetails1);
            this.Name = "PersonDetailsWithFilter";
            this.Size = new System.Drawing.Size(1027, 633);
            this.gpFilter.ResumeLayout(false);
            this.gpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PersonDetails personDetails1;
        private Guna.UI2.WinForms.Guna2GroupBox gpFilter;
        private Guna.UI2.WinForms.Guna2PictureBox pbSearch;
        private Guna.UI2.WinForms.Guna2TextBox tbFindBy;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterBy;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbFilterBy;
        private Guna.UI2.WinForms.Guna2PictureBox pbAddPerson;
    }
}
