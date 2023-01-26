namespace UI
{
    partial class frmUserRegistration
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
            this.grpbUserRegistration = new System.Windows.Forms.GroupBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnPictureAdd = new System.Windows.Forms.Button();
            this.pbxUserPhoto = new System.Windows.Forms.PictureBox();
            this.lblPasswordControl = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.dtpDateofBirth = new System.Windows.Forms.DateTimePicker();
            this.nmrcWeight = new System.Windows.Forms.NumericUpDown();
            this.nmrcHeight = new System.Windows.Forms.NumericUpDown();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblPassLow = new System.Windows.Forms.Label();
            this.lblPassUp = new System.Windows.Forms.Label();
            this.lblPassSpec = new System.Windows.Forms.Label();
            this.lblPassNum = new System.Windows.Forms.Label();
            this.lblPassLen = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.grpbUserRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbUserRegistration
            // 
            this.grpbUserRegistration.BackColor = System.Drawing.SystemColors.Control;
            this.grpbUserRegistration.Controls.Add(this.btnSignUp);
            this.grpbUserRegistration.Controls.Add(this.btnPictureAdd);
            this.grpbUserRegistration.Controls.Add(this.pbxUserPhoto);
            this.grpbUserRegistration.Controls.Add(this.lblPasswordControl);
            this.grpbUserRegistration.Controls.Add(this.lblHeight);
            this.grpbUserRegistration.Controls.Add(this.lblWeight);
            this.grpbUserRegistration.Controls.Add(this.dtpDateofBirth);
            this.grpbUserRegistration.Controls.Add(this.nmrcWeight);
            this.grpbUserRegistration.Controls.Add(this.nmrcHeight);
            this.grpbUserRegistration.Controls.Add(this.lblDateOfBirth);
            this.grpbUserRegistration.Controls.Add(this.txtConfirmPassword);
            this.grpbUserRegistration.Controls.Add(this.lblConfirmPassword);
            this.grpbUserRegistration.Controls.Add(this.lblPassLow);
            this.grpbUserRegistration.Controls.Add(this.lblPassUp);
            this.grpbUserRegistration.Controls.Add(this.lblPassSpec);
            this.grpbUserRegistration.Controls.Add(this.lblPassNum);
            this.grpbUserRegistration.Controls.Add(this.lblPassLen);
            this.grpbUserRegistration.Controls.Add(this.txtPassword);
            this.grpbUserRegistration.Controls.Add(this.lblPassword);
            this.grpbUserRegistration.Controls.Add(this.txtEmail);
            this.grpbUserRegistration.Controls.Add(this.lblEmail);
            this.grpbUserRegistration.Controls.Add(this.cmbGender);
            this.grpbUserRegistration.Controls.Add(this.lblGender);
            this.grpbUserRegistration.Controls.Add(this.txtSurname);
            this.grpbUserRegistration.Controls.Add(this.lblSurname);
            this.grpbUserRegistration.Controls.Add(this.txtName);
            this.grpbUserRegistration.Controls.Add(this.lblName);
            this.grpbUserRegistration.Location = new System.Drawing.Point(10, 9);
            this.grpbUserRegistration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbUserRegistration.Name = "grpbUserRegistration";
            this.grpbUserRegistration.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbUserRegistration.Size = new System.Drawing.Size(531, 475);
            this.grpbUserRegistration.TabIndex = 0;
            this.grpbUserRegistration.TabStop = false;
            this.grpbUserRegistration.Text = "User Registration";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(368, 351);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(150, 106);
            this.btnSignUp.TabIndex = 1;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnPictureAdd
            // 
            this.btnPictureAdd.Location = new System.Drawing.Point(368, 147);
            this.btnPictureAdd.Name = "btnPictureAdd";
            this.btnPictureAdd.Size = new System.Drawing.Size(157, 23);
            this.btnPictureAdd.TabIndex = 19;
            this.btnPictureAdd.Text = "Picture Add";
            this.btnPictureAdd.UseVisualStyleBackColor = true;
            this.btnPictureAdd.Click += new System.EventHandler(this.btnPictureAdd_Click);
            // 
            // pbxUserPhoto
            // 
            this.pbxUserPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxUserPhoto.Location = new System.Drawing.Point(368, 21);
            this.pbxUserPhoto.Name = "pbxUserPhoto";
            this.pbxUserPhoto.Size = new System.Drawing.Size(157, 120);
            this.pbxUserPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxUserPhoto.TabIndex = 18;
            this.pbxUserPhoto.TabStop = false;
            // 
            // lblPasswordControl
            // 
            this.lblPasswordControl.AutoSize = true;
            this.lblPasswordControl.Location = new System.Drawing.Point(137, 335);
            this.lblPasswordControl.Name = "lblPasswordControl";
            this.lblPasswordControl.Size = new System.Drawing.Size(0, 15);
            this.lblPasswordControl.TabIndex = 17;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeight.Location = new System.Drawing.Point(76, 435);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(51, 15);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Height :";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWeight.Location = new System.Drawing.Point(73, 394);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(54, 15);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "Weight :";
            // 
            // dtpDateofBirth
            // 
            this.dtpDateofBirth.Location = new System.Drawing.Point(137, 351);
            this.dtpDateofBirth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDateofBirth.Name = "dtpDateofBirth";
            this.dtpDateofBirth.Size = new System.Drawing.Size(207, 23);
            this.dtpDateofBirth.TabIndex = 1;
            // 
            // nmrcWeight
            // 
            this.nmrcWeight.Location = new System.Drawing.Point(137, 393);
            this.nmrcWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmrcWeight.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nmrcWeight.Name = "nmrcWeight";
            this.nmrcWeight.Size = new System.Drawing.Size(206, 23);
            this.nmrcWeight.TabIndex = 1;
            // 
            // nmrcHeight
            // 
            this.nmrcHeight.Location = new System.Drawing.Point(137, 434);
            this.nmrcHeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmrcHeight.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nmrcHeight.Name = "nmrcHeight";
            this.nmrcHeight.Size = new System.Drawing.Size(206, 23);
            this.nmrcHeight.TabIndex = 1;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDateOfBirth.Location = new System.Drawing.Point(38, 355);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(86, 15);
            this.lblDateOfBirth.TabIndex = 1;
            this.lblDateOfBirth.Text = "Date of Birth :";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(137, 310);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(207, 23);
            this.txtConfirmPassword.TabIndex = 16;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged_1);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConfirmPassword.Location = new System.Drawing.Point(5, 313);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(113, 15);
            this.lblConfirmPassword.TabIndex = 15;
            this.lblConfirmPassword.Text = "Confirm Password :";
            // 
            // lblPassLow
            // 
            this.lblPassLow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassLow.ForeColor = System.Drawing.Color.LightGray;
            this.lblPassLow.Location = new System.Drawing.Point(63, 282);
            this.lblPassLow.Name = "lblPassLow";
            this.lblPassLow.Size = new System.Drawing.Size(277, 19);
            this.lblPassLow.TabIndex = 14;
            this.lblPassLow.Text = "The password must have at least 1 lover case letter";
            // 
            // lblPassUp
            // 
            this.lblPassUp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassUp.ForeColor = System.Drawing.Color.LightGray;
            this.lblPassUp.Location = new System.Drawing.Point(63, 263);
            this.lblPassUp.Name = "lblPassUp";
            this.lblPassUp.Size = new System.Drawing.Size(277, 19);
            this.lblPassUp.TabIndex = 13;
            this.lblPassUp.Text = "The password must have at least 1 upper case letter";
            // 
            // lblPassSpec
            // 
            this.lblPassSpec.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassSpec.ForeColor = System.Drawing.Color.LightGray;
            this.lblPassSpec.Location = new System.Drawing.Point(63, 244);
            this.lblPassSpec.Name = "lblPassSpec";
            this.lblPassSpec.Size = new System.Drawing.Size(277, 19);
            this.lblPassSpec.TabIndex = 12;
            this.lblPassSpec.Text = "The password must have at least 1 special character";
            // 
            // lblPassNum
            // 
            this.lblPassNum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassNum.ForeColor = System.Drawing.Color.LightGray;
            this.lblPassNum.Location = new System.Drawing.Point(63, 226);
            this.lblPassNum.Name = "lblPassNum";
            this.lblPassNum.Size = new System.Drawing.Size(277, 19);
            this.lblPassNum.TabIndex = 11;
            this.lblPassNum.Text = "The password must have at least 1 number";
            // 
            // lblPassLen
            // 
            this.lblPassLen.BackColor = System.Drawing.Color.Transparent;
            this.lblPassLen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassLen.ForeColor = System.Drawing.Color.LightGray;
            this.lblPassLen.Location = new System.Drawing.Point(63, 207);
            this.lblPassLen.Name = "lblPassLen";
            this.lblPassLen.Size = new System.Drawing.Size(277, 19);
            this.lblPassLen.TabIndex = 10;
            this.lblPassLen.Text = "The password must have at least 6 characters";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(137, 178);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(207, 23);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(59, 180);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(65, 15);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(137, 140);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(207, 23);
            this.txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(84, 142);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 15);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email :";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(137, 100);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(207, 23);
            this.cmbGender.TabIndex = 5;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGender.Location = new System.Drawing.Point(73, 102);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(55, 15);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender :";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(137, 60);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(207, 23);
            this.txtSurname.TabIndex = 3;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSurname.Location = new System.Drawing.Point(63, 62);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(63, 15);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(137, 20);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(207, 23);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(80, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name :";
            // 
            // UserRegistrationScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 537);
            this.Controls.Add(this.grpbUserRegistration);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserRegistrationScreenForm";
            this.Text = "UserRegistrationScreenForm";
            this.Load += new System.EventHandler(this.UserRegistrationScreenForm_Load);
            this.grpbUserRegistration.ResumeLayout(false);
            this.grpbUserRegistration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcHeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpbUserRegistration;
        private Label lblName;
        private TextBox txtSurname;
        private Label lblSurname;
        private TextBox txtName;
        private Label lblGender;
        private DateTimePicker dtpDateofBirth;
        private NumericUpDown nmrcWeight;
        private NumericUpDown nmrcHeight;
        private Label lblDateOfBirth;
        private TextBox txtConfirmPassword;
        private Label lblConfirmPassword;
        private Label lblPassLow;
        private Label lblPassUp;
        private Label lblPassSpec;
        private Label lblPassNum;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtEmail;
        private Label lblEmail;
        private ComboBox cmbGender;
        private Label lblHeight;
        private Label lblWeight;
        private Button btnSignUp;
        private Label lblPasswordControl;
        private Button btnPictureAdd;
        private PictureBox pbxUserPhoto;
        private Label lblPassLen;
    }
}