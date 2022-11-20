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
    public partial class Smile_Profile : Form
    {
        public static Form dasbor_profil;
        public Smile_Profile()
        {
            InitializeComponent();
            dasbor_profil = this;
            lblMoodStatus.ForeColor = Color.Black;
            lblEditProfile.ForeColor = Color.Cornsilk;
        }

        private void lblMoodStatus_Click(object sender, EventArgs e)
        {
            moodStatus1.Show();
            editProfile1.Hide();
            moodStatus1.BringToFront();
            lblMoodStatus.ForeColor = Color.Black;
            lblEditProfile.ForeColor = Color.Cornsilk;
        }

        private void lblEditProfile_Click(object sender, EventArgs e)
        {
            editProfile1.Show();
            moodStatus1.Hide();
            editProfile1.BringToFront();
            lblEditProfile.ForeColor = Color.Black;
            lblMoodStatus.ForeColor = Color.Cornsilk;
        }
    }
}
