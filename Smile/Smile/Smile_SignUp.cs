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
    public partial class Smile_SignUp : Form
    {
        public Smile_SignUp()
        {
            InitializeComponent();
        }

        private void btnSmile_Click(object sender, EventArgs e)
        {
            Smile_Dashboard.dashboard.Show();
            this.Dispose();
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            Smile_Login login = new Smile_Login();
            login.Show();
            this.Dispose();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if(tbUsernama.Text != null)
            {

            }
        }
    }
}
