using Quiz_Maker.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Maker
{
    public partial class SignUpScreen : Form
    {
        UserDbContext udb = new UserDbContext();


        public const string MatchEmailPattern =
          @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
   + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
   + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
   + @"([a-zA-Z0-9]+[\w-]+\.)+[a-zA-Z]{1}[a-zA-Z0-9-]{1,23})$";

        Regex rgx = new Regex(MatchEmailPattern);

        public static bool IsEmail(string email)
        {
            if (email != null) return Regex.IsMatch(email, MatchEmailPattern);
            else return false;
        }
        public SignUpScreen()
        {
            InitializeComponent();
            this.Move += delegate { this.Capture = false; };

        }

        private void minimizelbl_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitlbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signupbtn__Click(object sender, EventArgs e)
        {
            User user = new User();
            UserDbContext userDbContext = new UserDbContext();

            bool isExist = false;

            foreach (var User in userDbContext.Users)
            {
                if (User.Email == gmailtxtbox.Text)
                {
                    isExist = true;
                    break;
                }
            }

            if (!IsEmail(gmailtxtbox.Text))
            {
                MessageBox.Show("Email is invalid");
            }
            else if (passtxtbox.Text.Length < 8)
            {
                MessageBox.Show("password must have a minimum of 8 characters");
            }
            else if (isExist)
            {
                MessageBox.Show("This User Already Exist");
            } 
            else
            {
                user.Firstname = fnametxtbox_.Text;
                user.Lastname = lnametxtbox_.Text;
                user.Email = gmailtxtbox.Text;
                user.Password = passtxtbox.Text;

                udb.Users.Add(user);
                udb.SaveChanges();
                MessageBox.Show("Registration completed successfully");
                Close();
            }
            //IsEmail(gmailtxtbox.Text) && passtxtbox.Text.Length >= 8

        }

        private void SignUpScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
