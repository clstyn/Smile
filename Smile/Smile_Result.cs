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
    public partial class Smile_Result : Form
    {
        public Smile_Result()
        {
            InitializeComponent();
            if (QResult.result != null)
            {
                lbPositive.Text = QResult.result.TotalPositive.ToString() + "/100";
                lbNegative.Text = QResult.result.TotalNegative.ToString() + "/100";

                progPersistence.Maximum = progOverall.Maximum = progIntensity.Maximum = progFrequency.Maximum = 100;
                progOverall.Value = QResult.result.Overall.Happy;
                progFrequency.Value = QResult.result.Frequency.Excited;
                progIntensity.Value = QResult.result.Intensity.Enthusiastic;
                progPersistence.Value = QResult.result.Persistence.Proud;

                lbSuggest.Text = QResult.result.Suggest;

            }
        }

        private void btnSmile_Click(object sender, EventArgs e)
        {
            Smile_Homepage.dashboard.Show();
            this.Dispose();
        }
    }
}
