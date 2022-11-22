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
    public partial class Smile_Questionnaire : Form
    {
        public Smile_Questionnaire()
        {
            InitializeComponent();
            btnPrev.Visible = false;
        }

        private int pagenumber=1;
        private DataTable Questions;
        public List<string> Questionlist;

        private void Smile_Questionnaire_Load(object sender, EventArgs e)
        {
            txtPage.Text = pagenumber.ToString() + "/4";
            pageQuest1.Visible = true;
            pageQuest2.Visible = false;
            pageQuest3.Visible = false;
            pageQuest4.Visible = false;

            loadQuestioner();
        }

        private void btnSmile_Click(object sender, EventArgs e)
        {
            Smile_Homepage.dashboard.Show();
            this.Dispose();
        }

        private void loadQuestioner()
        {
            Questioner Quest = new Questioner();
            Quest.loadQuestionnaire();

            Questions = new DataTable();
            Questions.Columns.Add(new DataColumn("pack", typeof(int)));
            Questions.Columns.Add(new DataColumn("question", typeof(string)));
            Questions.Columns.Add(new DataColumn("qtype", typeof(string)));
            Questions.Columns.Add(new DataColumn("trait", typeof(string)));

            Random rnd = new Random();
            int number = rnd.Next(1, 3);

            foreach (DataRow row in Quest.dt.Rows)
            {
                int temp = (int)row["pack"];
                if (temp == number)
                {
                    Questions.Rows.Add(row.ItemArray);
                }

                string name = row["question"].ToString();
                Console.WriteLine(name);
            }

            Questionlist = new List<string>();
            foreach (DataRow row in Questions.Rows)
            {
                string temp = row["question"].ToString();
                Questionlist.Add(temp);
            }

            pageQuest1.txtQ1.Text = Questionlist[1];
            pageQuest1.txtQ2.Text = Questionlist[1];
            pageQuest1.txtQ3.Text = Questionlist[2];
            pageQuest1.txtQ4.Text = Questionlist[3];
            pageQuest1.txtQ5.Text = Questionlist[4];

            pageQuest2.txtQ1.Text = Questionlist[5];
            pageQuest2.txtQ2.Text = Questionlist[6];
            pageQuest2.txtQ3.Text = Questionlist[7];
            pageQuest2.txtQ4.Text = Questionlist[8];
            pageQuest2.txtQ5.Text = Questionlist[9];

            pageQuest3.txtQ1.Text = Questionlist[10];
            pageQuest3.txtQ2.Text = Questionlist[11];
            pageQuest3.txtQ3.Text = Questionlist[12];
            pageQuest3.txtQ4.Text = Questionlist[13];
            pageQuest3.txtQ5.Text = Questionlist[14];

            pageQuest4.txtQ1.Text = Questionlist[15];
            pageQuest4.txtQ2.Text = Questionlist[16];
            pageQuest4.txtQ3.Text = Questionlist[17];
            pageQuest4.txtQ4.Text = Questionlist[18];
            pageQuest4.txtQ5.Text = Questionlist[19];
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(pagenumber==1)
            {
                pagenumber += 1;
                txtPage.Text = pagenumber.ToString() + "/4";
                pageQuest1.Visible = false;
                pageQuest2.Visible = true;
                btnPrev.Visible = true;
            }
            else if(pagenumber == 2)
            {
                pagenumber += 1;
                txtPage.Text = pagenumber.ToString() + "/4";
                pageQuest2.Visible = false;
                pageQuest3.Visible = true;
            }
            else if (pagenumber == 3)
            {
                pagenumber += 1;
                txtPage.Text = pagenumber.ToString() + "/4";
                pageQuest3.Visible = false;
                pageQuest4.Visible = true;
                btnNext.Visible = false;
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (pagenumber == 2)
            {
                pagenumber -= 1;
                txtPage.Text = pagenumber.ToString() + "/4";
                pageQuest1.Visible = true;
                pageQuest2.Visible = false;
                btnPrev.Visible = false;
            }
            else if (pagenumber == 3)
            {
                pagenumber -= 1;
                txtPage.Text = pagenumber.ToString() + "/4";
                pageQuest2.Visible = true;
                pageQuest3.Visible = false;
            }
            else if (pagenumber == 4)
            {
                pagenumber -= 1;
                txtPage.Text = pagenumber.ToString() + "/4";
                pageQuest3.Visible = true;
                pageQuest4.Visible = false;
                btnNext.Visible = true;
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {

        }
    }
}
