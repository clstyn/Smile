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
    public partial class MoodStatus : UserControl
    {
        public MoodStatus()
        {
            InitializeComponent();
        }

        private void MoodStatus_Load(object sender, EventArgs e)
        {
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

                /*pbEmot.Image = Bitmap(Smile.Properties.Resources.happy);*/
            }
        }
    }
}
