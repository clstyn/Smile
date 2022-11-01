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
    public partial class startQuest : Form
    {
        public startQuest()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Smile_Questioner quest = new Smile_Questioner();
            quest.Show();
            Smile_Dashboard.dashboard.Hide();
            this.Hide();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
