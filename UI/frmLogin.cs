using System.Diagnostics;
using DAL.Context;
using Entities.Entity;

namespace UI;

public partial class frmLogin : Form
{
    CalorieTrackingContext context;
    frmInfo _frmInfo;
    
    public frmLogin()
    {
        InitializeComponent();
        _frmInfo = new frmInfo();
    }

    private void LoginForm_Load(object sender, EventArgs e)
    {
        context = new CalorieTrackingContext(); 
    }
    private void btnLogIn_Click(object sender, EventArgs e)
    {
        User user = context.Users.FirstOrDefault(u => u.UserMail == txtEmail.Text && u.UserPassword == txtPassword.Text);
        if (user == null)
        {
            MessageBox.Show("Username or password is incorrect");
            txtEmail.Clear();
            txtPassword.Clear();
            return;
        }
        else
        {
            frmUserProfile frm = new frmUserProfile(user);
            this.Hide();
            frm.Show();
        }

    }
    private void btnSignUp_Click(object sender, EventArgs e)
    {
        frmUserRegistration userRegistrationScreenForm = new frmUserRegistration();
        userRegistrationScreenForm.ShowDialog();
    }

    private void chkbShowPasword_CheckedChanged(object sender, EventArgs e)
    {
        if (chkbShowPasword.Checked)
        {
            txtPassword.PasswordChar = '\0';
        }
        else
        {
            txtPassword.PasswordChar = '*';
        }
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        //this.Hide();
        _frmInfo.ShowDialog();

    }
}
