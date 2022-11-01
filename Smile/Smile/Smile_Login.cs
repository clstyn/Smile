using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smile
{
    public partial class Smile_Login : Form
    {
        public Smile_Login()
        {
            InitializeComponent();
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            UserAccount userAcc = new UserAccount(tbUsername.Text, tbPassword.Text);
            userAcc.credentialCheck();
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            Smile_SignUp signup = new Smile_SignUp();
            signup.Show();
            this.Dispose();
        }

        private void btnSmile_Click(object sender, EventArgs e)
        {
            Smile_Dashboard.dashboard.Show();
            this.Dispose();
        }

        private void Smile_Login_Load(object sender, EventArgs e)
        {
            tbUsername.PlaceholderText = "username here...";
            tbPassword.PlaceholderText = "password here...";
            panel1.BackColor = Color.FromArgb(192, 76, 58, 89);
        }
    }
}
