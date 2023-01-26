using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Context;
using Entities.Entity;
using Entities.Enums;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using User = Entities.Entity.User;

namespace UI
{
    public partial class frmUserRegistration : Form
    {
        CalorieTrackingContext context;
        User user;
        public frmUserRegistration()
        {
            InitializeComponent();
        }
        private void UserRegistrationScreenForm_Load(object sender, EventArgs e)
        {
            user = new User();
            context = new CalorieTrackingContext();
            ComboBoxFill();
        }
        private void ComboBoxFill()
        {
            cmbGender.DataSource = Enum.GetNames(typeof(Gender)).ToList();
            cmbGender.SelectedIndex = -1;
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {

            #region Name
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Name field cannot be empty");
                return;
            }
            else
            {
                char[] letters = { 'ç', 'ğ', 'ı', 'ö', 'ş', 'ü', 'İ', 'Ç', 'Ğ', 'Ö', 'Ş', 'Ü' };
                char[] replace = { 'c', 'g', 'i', 'o', 's', 'u', 'i', 'c', 'g', 'o', 's', 'u' };

                for (int i = 0; i < txtName.Text.Length; i++)
                {
                    //harfleri dön
                    for (int j = 0; j < letters.Length; j++)
                    {
                        if (txtName.Text[i] == letters[j])
                        {
                            txtName.Text = txtName.Text.Replace(txtName.Text[i], replace[j]);
                        }
                    }
                }
                txtName.Text = txtName.Text.ToUpper();
                user.UserName = txtName.Text;
            }

            #endregion
            #region Surname
            if (string.IsNullOrEmpty(txtSurname.Text))
            {
                MessageBox.Show("Surname field cannot be empty");
                return;
            }
            else
            {
                char[] letters = { 'ç', 'ğ', 'ı', 'ö', 'ş', 'ü', 'İ', 'Ç', 'Ğ', 'Ö', 'Ş', 'Ü' };
                char[] replace = { 'c', 'g', 'i', 'o', 's', 'u', 'i', 'c', 'g', 'o', 's', 'u' };

                for (int i = 0; i < txtSurname.Text.Length; i++)
                {
                    for (int j = 0; j < letters.Length; j++)
                    {
                        if (txtSurname.Text[i] == letters[j])
                        {
                            txtSurname.Text = txtSurname.Text.Replace(txtSurname.Text[i], replace[j]);
                        }
                    }
                }
                txtSurname.Text = txtSurname.Text.ToUpper();
                user.UserSurname = txtSurname.Text; 
            }
            #endregion
            #region Gender
            if (cmbGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select gender");
                return;
            }
            else
            {
                if ((Entities.Enums.Gender)cmbGender.SelectedIndex == 0)
                {
                    user.UserGender = Gender.Man;
                }
                else if ((Entities.Enums.Gender)cmbGender.SelectedIndex == (Gender)1)
                {
                    user.UserGender = Gender.Women;
                }
                else if ((Entities.Enums.Gender)cmbGender.SelectedIndex == (Gender)2)
                {
                    user.UserGender = Gender.Unspecified;
                }
            }
            #endregion
            #region Mail
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Mail field cannot be empty");
                return;
            }
            else if (Methods.IsValidEmail(txtEmail.Text))
            {
                user.UserMail = txtEmail.Text.Trim();
            }
            else
            {
                MessageBox.Show("Please enter a valid e-mail");
                return;
            }
            #endregion
            #region Password

            if (txtConfirmPassword.Text == txtPassword.Text)
            {
                if (Methods.CheckForUpperCase(txtPassword.Text) && Methods.CheckForLowerCase(txtPassword.Text) && Methods.CheckForSpecialCharacter(txtPassword.Text))
                {
                   user.UserPassword = txtPassword.Text.Trim();
                }
                else
                {
                    MessageBox.Show("Password does not meet the criteria");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match");
                return;
            }
            #endregion
            #region BirthDay
            if (dtpDateofBirth.Value > DateTime.Now)
            {
                MessageBox.Show("Your date of birth cannot be today");
                return;
            }
            else
            {
                user.UserBirthDate = dtpDateofBirth.Value;
            }
            #endregion
            #region Weight
            user.UserWeight = nmrcWeight.Value;
            #endregion
            #region Height
            user.UserHeight = nmrcHeight.Value;
            #endregion
            #region EmailChech

            foreach (var email in context.Users)
            {
                if (email.UserMail == user.UserMail)
                {
                    MessageBox.Show("User Mail Registered.");
                    return;
                }
            }
            #endregion
            #region PhotoControl

            if (user.PhotoPath == null)
            {
                MessageBox.Show("Please add picture");
                return;
            }

            #endregion
            #region DataBaseConnect
            context.Users.Add(user);
            context.SaveChanges();
            MessageBox.Show("User registration successful");
            this.Close();
            #endregion
        }

        #region PictureBoxAdd
        private void btnPictureAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please select a photo";
            ofd.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|All Files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbxUserPhoto.ImageLocation = ofd.FileName;
            }
            else
            {
                MessageBox.Show("No photo selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            string photoPath = pbxUserPhoto.ImageLocation;
            user.PhotoPath = photoPath;
        }
        #endregion
        #region PasswordCheck

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblPassLen.ForeColor = Color.LightGray;
            lblPassLow.ForeColor = Color.LightGray;
            lblPassNum.ForeColor = Color.LightGray;
            lblPassSpec.ForeColor = Color.LightGray;
            lblPassUp.ForeColor = Color.LightGray;

            string password = txtPassword.Text.Trim();
            string numbers = "0123456789";
            string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            string specialCharacters = "!'£^#+$%&/*?\\-_|@~¨´,;.:`";

            if (password.Length < 6 || password.Length > 8)
            {
                lblPassLen.ForeColor = Color.Red;
            }
            else
            {
                lblPassLen.ForeColor = Color.Green;
            }

            foreach (var item in password.Distinct())
            {
                if (lowerCase.Contains(item))
                {
                    lblPassLow.ForeColor = Color.Green;
                }
                else if (upperCase.Contains(item))
                {
                    lblPassUp.ForeColor = Color.Green;
                }
                else if (numbers.Contains(item))
                {
                    lblPassNum.ForeColor = Color.Green;
                }
                else if (specialCharacters.Contains(item))
                {
                    lblPassSpec.ForeColor = Color.Green;
                }
                else
                {
                    lblPassUp.ForeColor = Color.Red;
                    lblPassNum.ForeColor = Color.Red;
                    lblPassLow.ForeColor = Color.Red;
                    lblPassSpec.ForeColor = Color.Red;
                }
            }
        }
        private void txtConfirmPassword_TextChanged_1(object sender, EventArgs e)
        {
            PasswordCheck();
        }
        private void PasswordCheck()
        {
            if (txtPassword.Text == null)
            {
                lblPasswordControl.Visible = false;
            }
            else
            {
                string paswordCheck = txtConfirmPassword.Text.Trim();
                if (txtPassword.Text.Trim() != paswordCheck)
                {
                    lblPasswordControl.ForeColor = Color.Red;
                    lblPasswordControl.Text = "Your password is not matched";
                    lblPasswordControl.Visible = true;
                }
                else
                {
                    lblPasswordControl.ForeColor = Color.Green;
                    lblPasswordControl.Text = "Your password  is matched";
                    lblPasswordControl.Visible = true;
                }
            }
        }
        #endregion
    }
}
