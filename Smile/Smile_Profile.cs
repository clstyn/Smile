using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Smile
{
    public partial class Smile_Profile : Form
    {
        public static Form dashboard;
        public Smile_Profile()
        {
            InitializeComponent();
            dashboard = this;
            lblMoodStatus.ForeColor = Color.Black;
            lblEditProfile.ForeColor = Color.FromArgb(50, 255, 230, 238);
        }

        private void lblMoodStatus_Click(object sender, EventArgs e)
        {
            moodStatus2.Show();
            editProfile1.Hide();
            moodStatus2.BringToFront();
            lblMoodStatus.ForeColor = Color.Black;
            lblEditProfile.ForeColor = Color.FromArgb(50, 255, 230, 238);
        }

        private void lblEditProfile_Click(object sender, EventArgs e)
        {
            editProfile1.Show();
            moodStatus2.Hide();
            editProfile1.BringToFront();
            lblEditProfile.ForeColor = Color.Black;
            lblMoodStatus.ForeColor = Color.FromArgb(50, 255, 230, 238);

            if (UserAccount.logedUser != null)
            {
                editProfile1.FillForm(UserAccount.logedUser);
            }

        }

        private void Smile_Profile_Load(object sender, EventArgs e)
        {
            if (UserAccount.logedUser != null)
            {
                lblName.Text = UserAccount.logedUser.islogin == "true" ? UserAccount.logedUser.Name + "!" : "Name";
            }
        }
    }
}
