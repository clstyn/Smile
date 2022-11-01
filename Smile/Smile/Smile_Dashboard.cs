﻿using System;
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
    public partial class Smile_Dashboard : Form
    {
        public static Form dashboard;
        public Smile_Dashboard()
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
            btnDissapointed.BackColor = Color.FromArgb(192, 76, 58, 89);
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
            startQuest start = new startQuest();
            start.Show();
        }

        private void btnSong_Click(object sender, EventArgs e)
        {
            Smile_Music music = new Smile_Music();
            music.Show();
            this.Hide();
        }

        private void e(object sender, EventArgs e)
        {

        }
    }
}
