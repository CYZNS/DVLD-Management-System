namespace DVLD_Project.Users
{
    partial class frmChangePassword
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
            this.tbCurrentPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSavePassword = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.userDetails1 = new DVLD_Project.Controls.UserDetails();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCurrentPassword
            // 
            this.tbCurrentPassword.BorderColor = System.Drawing.Color.Black;
            this.tbCurrentPassword.BorderRadius = 5;
            this.tbCurrentPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCurrentPassword.DefaultText = "";
            this.tbCurrentPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCurrentPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCurrentPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCurrentPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCurrentPassword.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbCurrentPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbCurrentPassword.ForeColor = System.Drawing.Color.Black;
            this.tbCurrentPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCurrentPassword.Location = new System.Drawing.Point(302, 656);
            this.tbCurrentPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCurrentPassword.Name = "tbCurrentPassword";
            this.tbCurrentPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbCurrentPassword.PlaceholderText = "Enter your current Password:";
            this.tbCurrentPassword.SelectedText = "";
            this.tbCurrentPassword.Size = new System.Drawing.Size(195, 25);
            this.tbCurrentPassword.TabIndex = 14;
            this.tbCurrentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbCurrentPassword_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 758);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Confirm Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 662);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Current Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 710);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "New Password:";
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.BorderColor = System.Drawing.Color.Black;
            this.tbConfirmPassword.BorderRadius = 5;
            this.tbConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbConfirmPassword.DefaultText = "";
            this.tbConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbConfirmPassword.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbConfirmPassword.ForeColor = System.Drawing.Color.Black;
            this.tbConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbConfirmPassword.Location = new System.Drawing.Point(302, 758);
            this.tbConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbConfirmPassword.PlaceholderText = "Enter your current Password:";
            this.tbConfirmPassword.SelectedText = "";
            this.tbConfirmPassword.Size = new System.Drawing.Size(195, 25);
            this.tbConfirmPassword.TabIndex = 15;
            this.tbConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbConfirmPassword_Validating);
            // 
            // tbPassword
            // 
            this.tbPassword.BorderColor = System.Drawing.Color.Black;
            this.tbPassword.BorderRadius = 5;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.DefaultText = "";
            this.tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPassword.ForeColor = System.Drawing.Color.Black;
            this.tbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.Location = new System.Drawing.Point(302, 707);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbPassword.PlaceholderText = "Enter your current Password:";
            this.tbPassword.SelectedText = "";
            this.tbPassword.Size = new System.Drawing.Size(195, 25);
            this.tbPassword.TabIndex = 16;
            this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbPassword_Validating);
            // 
            // btnSavePassword
            // 
            this.btnSavePassword.Animated = true;
            this.btnSavePassword.BorderRadius = 5;
            this.btnSavePassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSavePassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSavePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSavePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSavePassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSavePassword.ForeColor = System.Drawing.Color.White;
            this.btnSavePassword.Location = new System.Drawing.Point(828, 752);
            this.btnSavePassword.Name = "btnSavePassword";
            this.btnSavePassword.Size = new System.Drawing.Size(146, 45);
            this.btnSavePassword.TabIndex = 17;
            this.btnSavePassword.Text = "Save";
            this.btnSavePassword.Click += new System.EventHandler(this.btnSavePassword_Click);
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.BorderRadius = 5;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(648, 752);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(146, 45);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // userDetails1
            // 
            this.userDetails1.Location = new System.Drawing.Point(-3, -3);
            this.userDetails1.Name = "userDetails1";
            this.userDetails1.Size = new System.Drawing.Size(1025, 653);
            this.userDetails1.TabIndex = 0;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1020, 809);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSavePassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbConfirmPassword);
            this.Controls.Add(this.tbCurrentPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userDetails1);
            this.Name = "frmChangePassword";
            this.Text = "frmChangePassword";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.UserDetails userDetails1;
        private Guna.UI2.WinForms.Guna2TextBox tbCurrentPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tbConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox tbPassword;
        private Guna.UI2.WinForms.Guna2Button btnSavePassword;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}