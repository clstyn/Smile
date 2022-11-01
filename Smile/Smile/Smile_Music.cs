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
    public partial class Smile_Music : Form
    {
        public Smile_Music()
        {
            InitializeComponent();
        }

        private void btnSmile_Click(object sender, EventArgs e)
        {
            Smile_Dashboard.dashboard.Show();
            this.Hide();
        }
    }
}
