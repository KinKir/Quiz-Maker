using Quiz_Maker.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Maker
{
    public partial class Loginscreen : Form
    {
        public Loginscreen()
        {
            InitializeComponent();
            this.Move += delegate { this.Capture = false; };
        }

        private void exitlbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizelbl_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            SignUpScreen signUpScreen = new SignUpScreen();
            signUpScreen.ShowDialog();
        }

        private void Loginscreen_Load(object sender, EventArgs e)
        {

        }

        private void loginsbtn__Click(object sender, EventArgs e)
        {

            UserDbContext userDbContext = new UserDbContext();

            bool isValidMail = false;
            bool isCorrectPassword = false;
            

            foreach (var user in userDbContext.Users)
            {
                if (user.Email == emailtxtbox.Text)
                {
                    isValidMail = true;

                    if (user.Password == passwordtxtbox.Text)
                    {
                        isCorrectPassword = true;
                    }
                    else
                    {
                        isCorrectPassword = false;
                    }
                }
            }

            if (!isValidMail)
            {
                MessageBox.Show("Email not found");
            }
            else if (!isCorrectPassword)
            {
                MessageBox.Show("Password is not Correct");
            }
            else
            {

                //var User = userDbContext.Users.SingleOrDefault(x => (x.Email == emailtxtbox.Text || x.Firstname == emailtxtbox.Text) && x.Password == passwordtxtbox.Text);
                //if (User != null)
                //{
                //    MainMenu menu = new MainMenu(User.Firstname + " " + User.Lastname);
                //    menu.ShowDialog();

                //}
                MainMenu mainMenu = new MainMenu(emailtxtbox.Text, passwordtxtbox.Text);
                mainMenu.ShowDialog();
            } 

        }

        private void passwordtxtbox_OnValueChanged(object sender, EventArgs e)
        {
            passwordtxtbox.Text = "";
        }

        private void emailtxtbox_MouseDown(object sender, MouseEventArgs e)
        {
            emailtxtbox.Text = "";
        }

        private void passwordtxtbox_MouseDown(object sender, MouseEventArgs e)
        {
            passwordtxtbox.Text = "";
        }
    }
}
