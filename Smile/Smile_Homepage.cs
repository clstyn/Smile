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
    public partial class Smile_Homepage : Form
    {
        public static Form dashboard;
        public Smile_Homepage()
        {
            InitializeComponent();
            dashboard = this;
        }

        private void Smile_Dashboard_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(192, 76, 58, 89);
            label1.BackColor = Color.FromArgb(192, 76, 58, 89);
            btnSmile.BackColor = Color.FromArgb(192, 76, 58, 89);
            btnLogin.BackColor = Color.FromArgb(192, 76, 58, 89);
            btnHappy.BackColor = Color.FromArgb(192, 76, 58, 89);
            btnSad.BackColor = Color.FromArgb(192, 76, 58, 89);
            btnCry.BackColor = Color.FromArgb(192, 76, 58, 89);
            btnAngry.BackColor = Color.FromArgb(192, 76, 58, 89);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Smile_Login login = new Smile_Login();
            login.Show();
            this.Hide();
        }

        private void btnSmile_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btnEmote_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please fill out the questionnaire to check your mood today");
            Smile_Questionnaire questions = new Smile_Questionnaire();
            questions.Show();
            this.Hide();
        }

        private void btnSong_Click(object sender, EventArgs e)
        {
            Smile_Music music = new Smile_Music();
            music.Show();
            this.Hide();
        }

        private void emoteHover(object sender, EventArgs e)
        {

        }

        private void isShow(object sender, EventArgs e)
        {
            if (UserAccount.logedUser != null)
            {
                txtWelcome.Text = UserAccount.logedUser.islogin == "true" ? "Welcome, " + UserAccount.logedUser.Name + "!" : "Welcome!";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
