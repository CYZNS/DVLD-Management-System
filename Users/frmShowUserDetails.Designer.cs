namespace DVLD_Project.Users
{
    partial class frmShowUserDetails
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
            this.userDetails1 = new DVLD_Project.Controls.UserDetails();
            this.SuspendLayout();
            // 
            // userDetails1
            // 
            this.userDetails1.Location = new System.Drawing.Point(-2, -2);
            this.userDetails1.Name = "userDetails1";
            this.userDetails1.Size = new System.Drawing.Size(1028, 653);
            this.userDetails1.TabIndex = 0;
            // 
            // frmShowUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 698);
            this.Controls.Add(this.userDetails1);
            this.Name = "frmShowUserDetails";
            this.Text = "fromShowUserDetails";
            this.Load += new System.EventHandler(this.frmShowUserDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UserDetails userDetails1;
    }
}