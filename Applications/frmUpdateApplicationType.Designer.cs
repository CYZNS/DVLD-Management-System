namespace DVLD_Project.Applications
{
    partial class frmUpdateApplicationType
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
            this.components = new System.ComponentModel.Container();
            this.lbTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbApplicationTypeID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbApplicationTypeTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbApplicationTypeFees = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lbTitle.Location = new System.Drawing.Point(30, 48);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(472, 56);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Update Application Type";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(28, 147);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(19, 18);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "ID:";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(30, 203);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(32, 18);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "Title:";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(30, 256);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(37, 18);
            this.guna2HtmlLabel3.TabIndex = 3;
            this.guna2HtmlLabel3.Text = "Fees:";
            // 
            // lbApplicationTypeID
            // 
            this.lbApplicationTypeID.BackColor = System.Drawing.Color.Transparent;
            this.lbApplicationTypeID.Location = new System.Drawing.Point(69, 147);
            this.lbApplicationTypeID.Name = "lbApplicationTypeID";
            this.lbApplicationTypeID.Size = new System.Drawing.Size(31, 18);
            this.lbApplicationTypeID.TabIndex = 4;
            this.lbApplicationTypeID.Text = "????";
            // 
            // tbApplicationTypeTitle
            // 
            this.tbApplicationTypeTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbApplicationTypeTitle.DefaultText = "";
            this.tbApplicationTypeTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbApplicationTypeTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbApplicationTypeTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbApplicationTypeTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbApplicationTypeTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbApplicationTypeTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbApplicationTypeTitle.ForeColor = System.Drawing.Color.Black;
            this.tbApplicationTypeTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbApplicationTypeTitle.Location = new System.Drawing.Point(138, 184);
            this.tbApplicationTypeTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbApplicationTypeTitle.Name = "tbApplicationTypeTitle";
            this.tbApplicationTypeTitle.PlaceholderText = "";
            this.tbApplicationTypeTitle.SelectedText = "";
            this.tbApplicationTypeTitle.Size = new System.Drawing.Size(229, 48);
            this.tbApplicationTypeTitle.TabIndex = 5;
            this.tbApplicationTypeTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbApplicationTypeTitle_KeyPress);
            this.tbApplicationTypeTitle.Validating += new System.ComponentModel.CancelEventHandler(this.tbApplicationTypeTitle_Validating);
            // 
            // tbApplicationTypeFees
            // 
            this.tbApplicationTypeFees.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbApplicationTypeFees.DefaultText = "";
            this.tbApplicationTypeFees.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbApplicationTypeFees.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbApplicationTypeFees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbApplicationTypeFees.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbApplicationTypeFees.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbApplicationTypeFees.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbApplicationTypeFees.ForeColor = System.Drawing.Color.Black;
            this.tbApplicationTypeFees.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbApplicationTypeFees.Location = new System.Drawing.Point(138, 240);
            this.tbApplicationTypeFees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbApplicationTypeFees.Name = "tbApplicationTypeFees";
            this.tbApplicationTypeFees.PlaceholderText = "";
            this.tbApplicationTypeFees.SelectedText = "";
            this.tbApplicationTypeFees.Size = new System.Drawing.Size(229, 48);
            this.tbApplicationTypeFees.TabIndex = 6;
            this.tbApplicationTypeFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbApplicationTypeFees_KeyPress);
            this.tbApplicationTypeFees.Validating += new System.ComponentModel.CancelEventHandler(this.tbApplicationTypeFees_Validating);
            // 
            // btnSave
            // 
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(343, 331);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 45);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmUpdateApplicationType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(535, 388);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbApplicationTypeFees);
            this.Controls.Add(this.tbApplicationTypeTitle);
            this.Controls.Add(this.lbApplicationTypeID);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.lbTitle);
            this.Name = "frmUpdateApplicationType";
            this.Text = "frmUpdateApplicationType";
            this.Load += new System.EventHandler(this.frmUpdateApplicationType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lbTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbApplicationTypeID;
        private Guna.UI2.WinForms.Guna2TextBox tbApplicationTypeTitle;
        private Guna.UI2.WinForms.Guna2TextBox tbApplicationTypeFees;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}