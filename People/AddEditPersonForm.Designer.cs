namespace DVLD_Project
{
    partial class AddEditPersonForm
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lbID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rbFemale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbMale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.lbPersonID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbPersonIDLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lkRemoveImage = new System.Windows.Forms.LinkLabel();
            this.lkSetImage = new System.Windows.Forms.LinkLabel();
            this.pbImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbNationalNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbThirdName = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtmDateOfBirth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbCountries = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tbAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbSecondName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbFirstName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold);
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(366, 25);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(530, 81);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Add New Person";
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.Blue;
            this.btnSave.FillColor2 = System.Drawing.Color.Silver;
            this.btnSave.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(850, 648);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 45);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.AutoRoundedCorners = true;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Silver;
            this.btnClose.FillColor2 = System.Drawing.Color.Gray;
            this.btnClose.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(660, 648);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 45);
            this.btnClose.TabIndex = 40;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbID
            // 
            this.lbID.BackColor = System.Drawing.Color.Transparent;
            this.lbID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(167, 68);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(3, 2);
            this.lbID.TabIndex = 31;
            this.lbID.Text = null;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.rbFemale);
            this.guna2GroupBox1.Controls.Add(this.rbMale);
            this.guna2GroupBox1.Controls.Add(this.lbPersonID);
            this.guna2GroupBox1.Controls.Add(this.lbPersonIDLabel);
            this.guna2GroupBox1.Controls.Add(this.lkRemoveImage);
            this.guna2GroupBox1.Controls.Add(this.lkSetImage);
            this.guna2GroupBox1.Controls.Add(this.pbImage);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2GroupBox1.Controls.Add(this.tbNationalNo);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GroupBox1.Controls.Add(this.tbLastName);
            this.guna2GroupBox1.Controls.Add(this.tbThirdName);
            this.guna2GroupBox1.Controls.Add(this.dtmDateOfBirth);
            this.guna2GroupBox1.Controls.Add(this.cbCountries);
            this.guna2GroupBox1.Controls.Add(this.tbAddress);
            this.guna2GroupBox1.Controls.Add(this.tbPhone);
            this.guna2GroupBox1.Controls.Add(this.tbEmail);
            this.guna2GroupBox1.Controls.Add(this.tbSecondName);
            this.guna2GroupBox1.Controls.Add(this.tbFirstName);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel8);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel7);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel5);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2GroupBox1.Controls.Add(this.lbFirstName);
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 45, 0, 0);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 146);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1268, 487);
            this.guna2GroupBox1.TabIndex = 56;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.BackColor = System.Drawing.Color.Transparent;
            this.rbFemale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbFemale.CheckedState.BorderThickness = 0;
            this.rbFemale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbFemale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbFemale.CheckedState.InnerOffset = -4;
            this.rbFemale.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.ForeColor = System.Drawing.Color.Black;
            this.rbFemale.Location = new System.Drawing.Point(307, 198);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(89, 29);
            this.rbFemale.TabIndex = 86;
            this.rbFemale.Tag = "1";
            this.rbFemale.Text = "Female";
            this.rbFemale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbFemale.UncheckedState.BorderThickness = 2;
            this.rbFemale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbFemale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbFemale.UseVisualStyleBackColor = false;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.rbFemale_CheckedChanged);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.BackColor = System.Drawing.Color.Transparent;
            this.rbMale.Checked = true;
            this.rbMale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbMale.CheckedState.BorderThickness = 0;
            this.rbMale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbMale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbMale.CheckedState.InnerOffset = -4;
            this.rbMale.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.rbMale.ForeColor = System.Drawing.Color.Black;
            this.rbMale.Location = new System.Drawing.Point(199, 198);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(71, 29);
            this.rbMale.TabIndex = 85;
            this.rbMale.TabStop = true;
            this.rbMale.Tag = "0";
            this.rbMale.Text = "Male";
            this.rbMale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbMale.UncheckedState.BorderThickness = 2;
            this.rbMale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbMale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbMale.UseVisualStyleBackColor = false;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // lbPersonID
            // 
            this.lbPersonID.AutoSize = false;
            this.lbPersonID.BackColor = System.Drawing.Color.Transparent;
            this.lbPersonID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonID.ForeColor = System.Drawing.Color.Black;
            this.lbPersonID.Location = new System.Drawing.Point(166, 5);
            this.lbPersonID.Name = "lbPersonID";
            this.lbPersonID.Size = new System.Drawing.Size(109, 33);
            this.lbPersonID.TabIndex = 82;
            this.lbPersonID.Text = "N/A";
            // 
            // lbPersonIDLabel
            // 
            this.lbPersonIDLabel.AutoSize = false;
            this.lbPersonIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.lbPersonIDLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonIDLabel.ForeColor = System.Drawing.Color.Black;
            this.lbPersonIDLabel.Location = new System.Drawing.Point(18, 5);
            this.lbPersonIDLabel.Name = "lbPersonIDLabel";
            this.lbPersonIDLabel.Size = new System.Drawing.Size(109, 33);
            this.lbPersonIDLabel.TabIndex = 81;
            this.lbPersonIDLabel.Text = "PersonID:";
            // 
            // lkRemoveImage
            // 
            this.lkRemoveImage.AutoSize = true;
            this.lkRemoveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkRemoveImage.Location = new System.Drawing.Point(1108, 354);
            this.lkRemoveImage.Name = "lkRemoveImage";
            this.lkRemoveImage.Size = new System.Drawing.Size(143, 25);
            this.lkRemoveImage.TabIndex = 80;
            this.lkRemoveImage.TabStop = true;
            this.lkRemoveImage.Text = "Remove Image";
            this.lkRemoveImage.Visible = false;
            this.lkRemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkRemoveImage_LinkClicked);
            // 
            // lkSetImage
            // 
            this.lkSetImage.AutoSize = true;
            this.lkSetImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkSetImage.Location = new System.Drawing.Point(994, 354);
            this.lkSetImage.Name = "lkSetImage";
            this.lkSetImage.Size = new System.Drawing.Size(101, 25);
            this.lkSetImage.TabIndex = 79;
            this.lkSetImage.TabStop = true;
            this.lkSetImage.Text = "Set Image";
            this.lkSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkSetImage_LinkClicked);
            // 
            // pbImage
            // 
            this.pbImage.ErrorImage = null;
            this.pbImage.FillColor = System.Drawing.Color.Transparent;
            this.pbImage.Image = global::DVLD_Project.Properties.Resources.anonymous_man;
            this.pbImage.ImageRotate = 0F;
            this.pbImage.Location = new System.Drawing.Point(973, 125);
            this.pbImage.Name = "pbImage";
            this.pbImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbImage.Size = new System.Drawing.Size(243, 212);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 78;
            this.pbImage.TabStop = false;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(18, 189);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(88, 33);
            this.guna2HtmlLabel2.TabIndex = 73;
            this.guna2HtmlLabel2.Text = "Gender:";
            // 
            // tbNationalNo
            // 
            this.tbNationalNo.Animated = true;
            this.tbNationalNo.BorderColor = System.Drawing.Color.Black;
            this.tbNationalNo.BorderRadius = 8;
            this.tbNationalNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNationalNo.DefaultText = "";
            this.tbNationalNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNationalNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNationalNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNationalNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNationalNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNationalNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbNationalNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNationalNo.Location = new System.Drawing.Point(199, 125);
            this.tbNationalNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNationalNo.Name = "tbNationalNo";
            this.tbNationalNo.PlaceholderText = "ادخل رقم الاقامة او الهوية";
            this.tbNationalNo.SelectedText = "";
            this.tbNationalNo.Size = new System.Drawing.Size(201, 32);
            this.tbNationalNo.TabIndex = 72;
            this.tbNationalNo.Validating += new System.ComponentModel.CancelEventHandler(this.tbTextBox_Validating);
            this.tbNationalNo.Validated += new System.EventHandler(this.tbTextBox_Validated);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(18, 125);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(147, 33);
            this.guna2HtmlLabel1.TabIndex = 71;
            this.guna2HtmlLabel1.Text = "National No:";
            // 
            // tbLastName
            // 
            this.tbLastName.Animated = true;
            this.tbLastName.BorderColor = System.Drawing.Color.Black;
            this.tbLastName.BorderRadius = 8;
            this.tbLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLastName.DefaultText = "";
            this.tbLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLastName.Location = new System.Drawing.Point(973, 62);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.PlaceholderText = "Enter Your Last Name";
            this.tbLastName.SelectedText = "";
            this.tbLastName.Size = new System.Drawing.Size(201, 32);
            this.tbLastName.TabIndex = 70;
            // 
            // tbThirdName
            // 
            this.tbThirdName.Animated = true;
            this.tbThirdName.BorderColor = System.Drawing.Color.Black;
            this.tbThirdName.BorderRadius = 8;
            this.tbThirdName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbThirdName.DefaultText = "";
            this.tbThirdName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbThirdName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbThirdName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbThirdName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbThirdName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbThirdName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbThirdName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbThirdName.Location = new System.Drawing.Point(715, 62);
            this.tbThirdName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbThirdName.Name = "tbThirdName";
            this.tbThirdName.PlaceholderText = "Enter Your Third Name";
            this.tbThirdName.SelectedText = "";
            this.tbThirdName.Size = new System.Drawing.Size(201, 32);
            this.tbThirdName.TabIndex = 69;
            // 
            // dtmDateOfBirth
            // 
            this.dtmDateOfBirth.BorderRadius = 8;
            this.dtmDateOfBirth.Checked = true;
            this.dtmDateOfBirth.FillColor = System.Drawing.Color.White;
            this.dtmDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtmDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtmDateOfBirth.Location = new System.Drawing.Point(686, 123);
            this.dtmDateOfBirth.MaxDate = new System.DateTime(2008, 10, 31, 0, 0, 0, 0);
            this.dtmDateOfBirth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtmDateOfBirth.Name = "dtmDateOfBirth";
            this.dtmDateOfBirth.Size = new System.Drawing.Size(235, 36);
            this.dtmDateOfBirth.TabIndex = 68;
            this.dtmDateOfBirth.Value = new System.DateTime(2008, 10, 31, 0, 0, 0, 0);
            // 
            // cbCountries
            // 
            this.cbCountries.BackColor = System.Drawing.Color.Transparent;
            this.cbCountries.BorderColor = System.Drawing.Color.Black;
            this.cbCountries.BorderRadius = 8;
            this.cbCountries.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountries.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCountries.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCountries.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCountries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCountries.ItemHeight = 30;
            this.cbCountries.Location = new System.Drawing.Point(686, 251);
            this.cbCountries.Name = "cbCountries";
            this.cbCountries.Size = new System.Drawing.Size(243, 36);
            this.cbCountries.TabIndex = 67;
            // 
            // tbAddress
            // 
            this.tbAddress.Animated = true;
            this.tbAddress.BorderColor = System.Drawing.Color.Black;
            this.tbAddress.BorderRadius = 8;
            this.tbAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAddress.DefaultText = "";
            this.tbAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAddress.Location = new System.Drawing.Point(199, 306);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.PlaceholderText = "e.g Alwisham District , Abad Bin Sahl Street";
            this.tbAddress.SelectedText = "";
            this.tbAddress.Size = new System.Drawing.Size(736, 121);
            this.tbAddress.TabIndex = 66;
            // 
            // tbPhone
            // 
            this.tbPhone.Animated = true;
            this.tbPhone.BorderColor = System.Drawing.Color.Black;
            this.tbPhone.BorderRadius = 8;
            this.tbPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhone.DefaultText = "";
            this.tbPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPhone.Location = new System.Drawing.Point(686, 189);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.PlaceholderText = "should start with 56";
            this.tbPhone.SelectedText = "";
            this.tbPhone.Size = new System.Drawing.Size(235, 32);
            this.tbPhone.TabIndex = 65;
            // 
            // tbEmail
            // 
            this.tbEmail.Animated = true;
            this.tbEmail.BorderColor = System.Drawing.Color.Black;
            this.tbEmail.BorderRadius = 8;
            this.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.DefaultText = "";
            this.tbEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmail.Location = new System.Drawing.Point(199, 253);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PlaceholderText = "e.g Person@gmail.com";
            this.tbEmail.SelectedText = "";
            this.tbEmail.Size = new System.Drawing.Size(211, 32);
            this.tbEmail.TabIndex = 64;
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbTextBox_Validating);
            this.tbEmail.Validated += new System.EventHandler(this.tbTextBox_Validated);
            // 
            // tbSecondName
            // 
            this.tbSecondName.Animated = true;
            this.tbSecondName.BorderColor = System.Drawing.Color.Black;
            this.tbSecondName.BorderRadius = 8;
            this.tbSecondName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSecondName.DefaultText = "";
            this.tbSecondName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSecondName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSecondName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSecondName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSecondName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSecondName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSecondName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSecondName.Location = new System.Drawing.Point(457, 62);
            this.tbSecondName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSecondName.Name = "tbSecondName";
            this.tbSecondName.PlaceholderText = "Enter Your Second Name";
            this.tbSecondName.SelectedText = "";
            this.tbSecondName.Size = new System.Drawing.Size(201, 32);
            this.tbSecondName.TabIndex = 63;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Animated = true;
            this.tbFirstName.BorderColor = System.Drawing.Color.Black;
            this.tbFirstName.BorderRadius = 8;
            this.tbFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFirstName.DefaultText = "";
            this.tbFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFirstName.Location = new System.Drawing.Point(199, 62);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.PlaceholderText = "Enter Your FirstName";
            this.tbFirstName.SelectedText = "";
            this.tbFirstName.Size = new System.Drawing.Size(201, 32);
            this.tbFirstName.TabIndex = 62;
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.AutoSize = false;
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(544, 253);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(99, 33);
            this.guna2HtmlLabel8.TabIndex = 61;
            this.guna2HtmlLabel8.Text = "Country:";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.AutoSize = false;
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(18, 317);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(109, 33);
            this.guna2HtmlLabel7.TabIndex = 60;
            this.guna2HtmlLabel7.Text = "Address:";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(18, 253);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(88, 33);
            this.guna2HtmlLabel5.TabIndex = 59;
            this.guna2HtmlLabel5.Text = "Email:";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(562, 189);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(81, 33);
            this.guna2HtmlLabel4.TabIndex = 58;
            this.guna2HtmlLabel4.Text = "Phone:";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(499, 125);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(144, 33);
            this.guna2HtmlLabel3.TabIndex = 57;
            this.guna2HtmlLabel3.Text = "DateOfBirth:";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = false;
            this.lbFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lbFirstName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstName.Location = new System.Drawing.Point(18, 61);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(82, 33);
            this.lbFirstName.TabIndex = 56;
            this.lbFirstName.Text = "Name:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 714);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbTitle);
            this.Name = "AddEditForm";
            this.Text = "AddEditForm";
            this.Load += new System.EventHandler(this.AddEditForm_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private Guna.UI2.WinForms.Guna2GradientButton btnSave;
        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbID;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbPersonIDLabel;
        private System.Windows.Forms.LinkLabel lkRemoveImage;
        private System.Windows.Forms.LinkLabel lkSetImage;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbImage;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox tbNationalNo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox tbLastName;
        private Guna.UI2.WinForms.Guna2TextBox tbThirdName;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtmDateOfBirth;
        private Guna.UI2.WinForms.Guna2ComboBox cbCountries;
        private Guna.UI2.WinForms.Guna2TextBox tbAddress;
        private Guna.UI2.WinForms.Guna2TextBox tbPhone;
        private Guna.UI2.WinForms.Guna2TextBox tbEmail;
        private Guna.UI2.WinForms.Guna2TextBox tbSecondName;
        private Guna.UI2.WinForms.Guna2TextBox tbFirstName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbFirstName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbPersonID;
        private Guna.UI2.WinForms.Guna2RadioButton rbFemale;
        private Guna.UI2.WinForms.Guna2RadioButton rbMale;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}