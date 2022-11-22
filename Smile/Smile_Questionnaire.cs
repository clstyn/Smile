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

        private MoodOverall mOverall;
        private MoodFrequency mFrequency;
        private MoodIntensity mIntensity;
        private MoodPersistence mPersistence;

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
            }

            pageQuest1.txtQ1.Text = Questions.Rows[0]["question"].ToString();
            pageQuest1.txtQ2.Text = Questions.Rows[1]["question"].ToString();
            pageQuest1.txtQ3.Text = Questions.Rows[2]["question"].ToString();
            pageQuest1.txtQ4.Text = Questions.Rows[3]["question"].ToString();
            pageQuest1.txtQ5.Text = Questions.Rows[4]["question"].ToString();

            pageQuest2.txtQ1.Text = Questions.Rows[5]["question"].ToString();
            pageQuest2.txtQ2.Text = Questions.Rows[6]["question"].ToString();
            pageQuest2.txtQ3.Text = Questions.Rows[7]["question"].ToString();
            pageQuest2.txtQ4.Text = Questions.Rows[8]["question"].ToString();
            pageQuest2.txtQ5.Text = Questions.Rows[9]["question"].ToString();

            pageQuest3.txtQ1.Text = Questions.Rows[10]["question"].ToString();
            pageQuest3.txtQ2.Text = Questions.Rows[11]["question"].ToString();
            pageQuest3.txtQ3.Text = Questions.Rows[12]["question"].ToString();
            pageQuest3.txtQ4.Text = Questions.Rows[13]["question"].ToString();
            pageQuest3.txtQ5.Text = Questions.Rows[14]["question"].ToString();

            pageQuest4.txtQ1.Text = Questions.Rows[15]["question"].ToString();
            pageQuest4.txtQ2.Text = Questions.Rows[16]["question"].ToString();
            pageQuest4.txtQ3.Text = Questions.Rows[17]["question"].ToString();
            pageQuest4.txtQ4.Text = Questions.Rows[18]["question"].ToString();
            pageQuest4.txtQ5.Text = Questions.Rows[19]["question"].ToString();
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
            int check = CheckInput();

            if(check == 0)
            {
                mOverall = new MoodOverall();
                mFrequency = new MoodFrequency();
                mIntensity = new MoodIntensity();
                mPersistence = new MoodPersistence();

                confirmFinish();

                MessageBox.Show("your point list :" + " Happy = " + mOverall.Happy.ToString() + " Depressed = " + mOverall.Depressed.ToString() +
                    " Excited = " + mFrequency.Excited.ToString() + " Sad = " + mFrequency.Sad.ToString() + " Enthusiastic = " + mIntensity.Enthusiastic.ToString() +
                    " Afraid = " + mIntensity.Afraid.ToString() + " Proud = " + mPersistence.Proud.ToString() + " Angry = " + mPersistence.Angry.ToString());
            }
        }

        private int CheckInput()
        {
            List<string> notAnswered = new List<string>();

            //page1
            if(pageQuest1.radioButton1.Checked || pageQuest1.radioButton2.Checked || pageQuest1.radioButton3.Checked || pageQuest1.radioButton4.Checked || pageQuest1.radioButton5.Checked == true)
            {} else
            {
                notAnswered.Add("1");
            }
            if (pageQuest1.radioButton6.Checked || pageQuest1.radioButton7.Checked || pageQuest1.radioButton8.Checked || pageQuest1.radioButton9.Checked || pageQuest1.radioButton10.Checked == true)
            { }
            else
            {
                notAnswered.Add("2");
            }
            if (pageQuest1.radioButton11.Checked || pageQuest1.radioButton12.Checked || pageQuest1.radioButton13.Checked || pageQuest1.radioButton14.Checked || pageQuest1.radioButton15.Checked == true)
            { }
            else
            {
                notAnswered.Add("3");
            }
            if (pageQuest1.radioButton16.Checked || pageQuest1.radioButton17.Checked || pageQuest1.radioButton18.Checked || pageQuest1.radioButton19.Checked || pageQuest1.radioButton20.Checked == true)
            { }
            else
            {
                notAnswered.Add("4");
            }
            if (pageQuest1.radioButton21.Checked || pageQuest1.radioButton22.Checked || pageQuest1.radioButton23.Checked || pageQuest1.radioButton24.Checked || pageQuest1.radioButton25.Checked == true)
            { }
            else
            {
                notAnswered.Add("5");
            }

            //page2
            if (pageQuest2.radioButton1.Checked || pageQuest2.radioButton2.Checked || pageQuest2.radioButton3.Checked || pageQuest2.radioButton4.Checked || pageQuest2.radioButton5.Checked == true)
            { }
            else
            {
                notAnswered.Add("6");
            }
            if (pageQuest2.radioButton6.Checked || pageQuest2.radioButton7.Checked || pageQuest2.radioButton8.Checked || pageQuest2.radioButton9.Checked || pageQuest2.radioButton10.Checked == true)
            { }
            else
            {
                notAnswered.Add("7");
            }
            if (pageQuest2.radioButton11.Checked || pageQuest2.radioButton12.Checked || pageQuest2.radioButton13.Checked || pageQuest2.radioButton14.Checked || pageQuest2.radioButton15.Checked == true)
            { }
            else
            {
                notAnswered.Add("8");
            }
            if (pageQuest2.radioButton16.Checked || pageQuest2.radioButton17.Checked || pageQuest2.radioButton18.Checked || pageQuest2.radioButton19.Checked || pageQuest2.radioButton20.Checked == true)
            { }
            else
            {
                notAnswered.Add("9");
            }
            if (pageQuest2.radioButton21.Checked || pageQuest2.radioButton22.Checked || pageQuest2.radioButton23.Checked || pageQuest2.radioButton24.Checked || pageQuest2.radioButton25.Checked == true)
            { }
            else
            {
                notAnswered.Add("10");
            }

            //page3
            if (pageQuest3.radioButton1.Checked || pageQuest3.radioButton2.Checked || pageQuest3.radioButton3.Checked || pageQuest3.radioButton4.Checked || pageQuest3.radioButton5.Checked == true)
            { }
            else
            {
                notAnswered.Add("11");
            }
            if (pageQuest3.radioButton6.Checked || pageQuest3.radioButton7.Checked || pageQuest3.radioButton8.Checked || pageQuest3.radioButton9.Checked || pageQuest3.radioButton10.Checked == true)
            { }
            else
            {
                notAnswered.Add("12");
            }
            if (pageQuest3.radioButton11.Checked || pageQuest3.radioButton12.Checked || pageQuest3.radioButton13.Checked || pageQuest3.radioButton14.Checked || pageQuest3.radioButton15.Checked == true)
            { }
            else
            {
                notAnswered.Add("13");
            }
            if (pageQuest3.radioButton16.Checked || pageQuest3.radioButton17.Checked || pageQuest3.radioButton18.Checked || pageQuest3.radioButton19.Checked || pageQuest3.radioButton20.Checked == true)
            { }
            else
            {
                notAnswered.Add("14");
            }
            if (pageQuest3.radioButton21.Checked || pageQuest3.radioButton22.Checked || pageQuest3.radioButton23.Checked || pageQuest3.radioButton24.Checked || pageQuest3.radioButton25.Checked == true)
            { }
            else
            {
                notAnswered.Add("15");
            }

            //page4
            if (pageQuest4.radioButton1.Checked || pageQuest4.radioButton2.Checked || pageQuest4.radioButton3.Checked || pageQuest4.radioButton4.Checked || pageQuest4.radioButton5.Checked == true)
            { }
            else
            {
                notAnswered.Add("16");
            }
            if (pageQuest4.radioButton6.Checked || pageQuest4.radioButton7.Checked || pageQuest4.radioButton8.Checked || pageQuest4.radioButton9.Checked || pageQuest4.radioButton10.Checked == true)
            { }
            else
            {
                notAnswered.Add("17");
            }
            if (pageQuest4.radioButton11.Checked || pageQuest4.radioButton12.Checked || pageQuest4.radioButton13.Checked || pageQuest4.radioButton14.Checked || pageQuest4.radioButton15.Checked == true)
            { }
            else
            {
                notAnswered.Add("18");
            }
            if (pageQuest4.radioButton16.Checked || pageQuest4.radioButton17.Checked || pageQuest4.radioButton18.Checked || pageQuest4.radioButton19.Checked || pageQuest4.radioButton20.Checked == true)
            { }
            else
            {
                notAnswered.Add("19");
            }
            if (pageQuest4.radioButton21.Checked || pageQuest4.radioButton22.Checked || pageQuest4.radioButton23.Checked || pageQuest4.radioButton24.Checked || pageQuest4.radioButton25.Checked == true)
            { }
            else
            {
                notAnswered.Add("20");
            }

            if(notAnswered.Count != 0)
            {
                string txtNotAnswered = "You haven't answer question number ";
                for (int i = 0; i<notAnswered.Count; i++)
                {
                    txtNotAnswered += notAnswered[i];
                    if (i!=notAnswered.Count-1)
                    {
                        txtNotAnswered += ", ";
                    }
                }
                txtNotAnswered += " !!!";
                MessageBox.Show(txtNotAnswered);
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void confirmFinish()
        {
            int degree=0;

            //page 1
            //q1
            if (pageQuest1.radioButton1.Checked == true)
            {
                degree = 1;
            }
            else if (pageQuest1.radioButton2.Checked == true)
            {
                degree = 2;
            }
            else if (pageQuest1.radioButton3.Checked == true)
            {
                degree = 3;
            }
            else if (pageQuest1.radioButton4.Checked == true)
            {
                degree = 4;
            }
            else if (pageQuest1.radioButton5.Checked == true)
            {
                degree = 5;
            }
            commitPoint(degree, Questions.Rows[0]["qtype"].ToString(), Questions.Rows[0]["trait"].ToString());

            //q2
            if (pageQuest1.radioButton6.Checked == true)
            {
                degree = 1;
            }
            else if (pageQuest1.radioButton7.Checked == true)
            {
                degree = 2;
            }
            else if (pageQuest1.radioButton8.Checked == true)
            {
                degree = 3;
            }
            else if (pageQuest1.radioButton9.Checked == true)
            {
                degree = 4;
            }
            else if (pageQuest1.radioButton10.Checked == true)
            {
                degree = 5;
            }
            commitPoint(degree, Questions.Rows[1]["qtype"].ToString(), Questions.Rows[1]["trait"].ToString());

            //q3
            if (pageQuest1.radioButton11.Checked == true)
            {
                degree = 1;
            }
            else if (pageQuest1.radioButton12.Checked == true)
            {
                degree = 2;
            }
            else if (pageQuest1.radioButton13.Checked == true)
            {
                degree = 3;
            }
            else if (pageQuest1.radioButton14.Checked == true)
            {
                degree = 4;
            }
            else if (pageQuest1.radioButton15.Checked == true)
            {
                degree = 5;
            }
            commitPoint(degree, Questions.Rows[2]["qtype"].ToString(), Questions.Rows[2]["trait"].ToString());

            //q4
            if (pageQuest1.radioButton16.Checked == true)
            {
                degree = 1;
            }
            else if (pageQuest1.radioButton17.Checked == true)
            {
                degree = 2;
            }
            else if (pageQuest1.radioButton18.Checked == true)
            {
                degree = 3;
            }
            else if (pageQuest1.radioButton19.Checked == true)
            {
                degree = 4;
            }
            else if (pageQuest1.radioButton20.Checked == true)
            {
                degree = 5;
            }
            commitPoint(degree, Questions.Rows[3]["qtype"].ToString(), Questions.Rows[3]["trait"].ToString());

            //q5
            if (pageQuest1.radioButton21.Checked == true)
            {
                degree = 1;
            }
            else if (pageQuest1.radioButton22.Checked == true)
            {
                degree = 2;
            }
            else if (pageQuest1.radioButton23.Checked == true)
            {
                degree = 3;
            }
            else if (pageQuest1.radioButton24.Checked == true)
            {
                degree = 4;
            }
            else if (pageQuest1.radioButton25.Checked == true)
            {
                degree = 5;
            }
            commitPoint(degree, Questions.Rows[4]["qtype"].ToString(), Questions.Rows[4]["trait"].ToString());


            //page 2
            //q6
            if (pageQuest2.radioButton1.Checked == true)
            {
                degree = 1;
            }
            else if (pageQuest2.radioButton2.Checked == true)
            {
                degree = 2;
            }
            else if (pageQuest2.radioButton3.Checked == true)
            {
                degree = 3;
            }
            else if (pageQuest2.radioButton4.Checked == true)
            {
                degree = 4;
            }
            else if (pageQuest2.radioButton5.Checked == true)
            {
                degree = 5;
            }
            commitPoint(degree, Questions.Rows[5]["qtype"].ToString(), Questions.Rows[5]["trait"].ToString());

            //q7
            if (pageQuest2.radioButton6.Checked == true)
            {
                degree = 1;
            }
            else if (pageQuest2.radioButton7.Checked == true)
            {
                degree = 2;
            }
            else if (pageQuest2.radioButton8.Checked == true)
            {
                degree = 3;
            }
            else if (pageQuest2.radioButton9.Checked == true)
            {
                degree = 4;
            }
            else if (pageQuest2.radioButton10.Checked == true)
            {
                degree = 5;
            }
            commitPoint(degree, Questions.Rows[6]["qtype"].ToString(), Questions.Rows[6]["trait"].ToString());

            //q8
            if (pageQuest2.radioButton11.Checked == true)
            {
                degree = 1;
            }
            else if (pageQuest2.radioButton12.Checked == true)
            {
                degree = 2;
            }
            else if (pageQuest2.radioButton13.Checked == true)
            {
                degree = 3;
            }
            else if (pageQuest2.radioButton14.Checked == true)
            {
                degree = 4;
            }
            else if (pageQuest2.radioButton15.Checked == true)
            {
                degree = 5;
            }
            commitPoint(degree, Questions.Rows[7]["qtype"].ToString(), Questions.Rows[7]["trait"].ToString());

            //q9
            if (pageQuest2.radioButton16.Checked == true)
            {
                degree = 1;
            }
            else if (pageQuest2.radioButton17.Checked == true)
            {
                degree = 2;
            }
            else if (pageQuest2.radioButton18.Checked == true)
            {
                degree = 3;
            }
            else if (pageQuest2.radioButton19.Checked == true)
            {
                degree = 4;
            }
            else if (pageQuest2.radioButton20.Checked == true)
            {
                degree = 5;
            }
            commitPoint(degree, Questions.Rows[8]["qtype"].ToString(), Questions.Rows[8]["trait"].ToString());

            //q10
            if (pageQuest2.radioButton21.Checked == true)
            {
                degree = 1;
            }
            else if (pageQuest2.radioButton22.Checked == true)
            {
                degree = 2;
            }
            else if (pageQuest2.radioButton23.Checked == true)
            {
                degree = 3;
            }
            else if (pageQuest2.radioButton24.Checked == true)
            {
                degree = 4;
            }
            else if (pageQuest2.radioButton25.Checked == true)
            {
                degree = 5;
            }
            commitPoint(degree, Questions.Rows[9]["qtype"].ToString(), Questions.Rows[9]["trait"].ToString());

            //page 3
            //q11
            if (pageQuest3.radioButton1.Checked == true)
            {
                degree = 1;
            }
            else if (pageQuest3.radioButton2.Checked == true)
            {
                degree = 2;
            }
            else if (pageQuest3.radioButton3.Checked == true)
            {
                degree = 3;
            }
            else if (pageQuest3.radioButton4.Checked == true)
            {
                degree = 4;
            }
            else if (pageQuest3.radioButton5.Checked == true)
            {
                degree = 5;
            }
            commitPoint(degree, Questions.Rows[10]["qtype"].ToString(), Questions.Rows[10]["trait"].ToString());

            //q12
            if (pageQuest3.radioButton6.Checked == true)
            {
                degree = 1;
            }
            else if (pageQuest3.radioButton7.Checked == true)
            {
                degree = 2;
            }
            else if (pageQuest3.radioButton8.Checked == true)
            {
                degree = 3;
            }
            else if (pageQuest3.radioButton9.Checked == true)
            {
                degree = 4;
            }
            else if (pageQuest3.radioButton10.Checked == true)
            {
                degree = 5;
            }
            commitPoint(degree, Questions.Rows[11]["qtype"].ToString(), Questions.Rows[11]["trait"].ToString());

            //q13
            if (pageQuest3.radioButton11.Checked == true)
            {
                degree = 1;
            }
            else if (pageQuest3.radioButton12.Checked == true)
            {
                degree = 2;
            }
            else if (pageQuest3.radioButton13.Checked == true)
            {
                degree = 3;
            }
            else if (pageQuest3.radioButton14.Checked == true)
            {
                degree = 4;
            }
            else if (pageQuest3.radioButton15.Checked == true)
            {
                degree = 5;
            }
            commitPoint(degree, Questions.Rows[12]["qtype"].ToString(), Questions.Rows[12]["trait"].ToString());

            //q14
            if (pageQuest3.radioButton16.Checked == true)
            {
                degree = 1;
            }
            else if (pageQuest3.radioButton17.Checked == true)
            {
                degree = 2;
            }
            else if (pageQuest3.radioButton18.Checked == true)
            {
                degree = 3;
            }
            else if (pageQuest3.radioButton19.Checked == true)
            {
                degree = 4;
            }
            else if (pageQuest3.radioButton20.Checked == true)
            {
                degree = 5;
            }
            commitPoint(degree, Questions.Rows[13]["qtype"].ToString(), Questions.Rows[13]["trait"].ToString());

            //q15
            if (pageQuest3.radioButton21.Checked == true)
            {
                degree = 1;
            }
            else if (pageQuest3.radioButton22.Checked == true)
            {
                degree = 2;
            }
            else if (pageQuest3.radioButton23.Checked == true)
            {
                degree = 3;
            }
            else if (pageQuest3.radioButton24.Checked == true)
            {
                degree = 4;
            }
            else if (pageQuest3.radioButton25.Checked == true)
            {
                degree = 5;
            }
            commitPoint(degree, Questions.Rows[14]["qtype"].ToString(), Questions.Rows[14]["trait"].ToString());


            //page 4
            //q16
            if (pageQuest4.radioButton1.Checked == true)
            {
                degree = 1;
            }
            else if (pageQuest4.radioButton2.Checked == true)
            {
                degree = 2;
            }
            else if (pageQuest4.radioButton3.Checked == true)
            {
                degree = 3;
            }
            else if (pageQuest4.radioButton4.Checked == true)
            {
                degree = 4;
            }
            else if (pageQuest4.radioButton5.Checked == true)
            {
                degree = 5;
            }
            commitPoint(degree, Questions.Rows[15]["qtype"].ToString(), Questions.Rows[15]["trait"].ToString());

            //q17
            if (pageQuest4.radioButton6.Checked == true)
            {
                degree = 1;
            }
            else if (pageQuest4.radioButton7.Checked == true)
            {
                degree = 2;
            }
            else if (pageQuest4.radioButton8.Checked == true)
            {
                degree = 3;
            }
            else if (pageQuest4.radioButton9.Checked == true)
            {
                degree = 4;
            }
            else if (pageQuest4.radioButton10.Checked == true)
            {
                degree = 5;
            }
            commitPoint(degree, Questions.Rows[16]["qtype"].ToString(), Questions.Rows[16]["trait"].ToString());

            //q18
            if (pageQuest4.radioButton11.Checked == true)
            {
                degree = 1;
            }
            else if (pageQuest4.radioButton12.Checked == true)
            {
                degree = 2;
            }
            else if (pageQuest4.radioButton13.Checked == true)
            {
                degree = 3;
            }
            else if (pageQuest4.radioButton14.Checked == true)
            {
                degree = 4;
            }
            else if (pageQuest4.radioButton15.Checked == true)
            {
                degree = 5;
            }
            commitPoint(degree, Questions.Rows[17]["qtype"].ToString(), Questions.Rows[17]["trait"].ToString());

            //q19
            if (pageQuest4.radioButton16.Checked == true)
            {
                degree = 1;
            }
            else if (pageQuest4.radioButton17.Checked == true)
            {
                degree = 2;
            }
            else if (pageQuest4.radioButton18.Checked == true)
            {
                degree = 3;
            }
            else if (pageQuest4.radioButton19.Checked == true)
            {
                degree = 4;
            }
            else if (pageQuest4.radioButton20.Checked == true)
            {
                degree = 5;
            }
            commitPoint(degree, Questions.Rows[18]["qtype"].ToString(), Questions.Rows[18]["trait"].ToString());

            //q20
            if (pageQuest4.radioButton21.Checked == true)
            {
                degree = 1;
            }
            else if (pageQuest4.radioButton22.Checked == true)
            {
                degree = 2;
            }
            else if (pageQuest4.radioButton23.Checked == true)
            {
                degree = 3;
            }
            else if (pageQuest4.radioButton24.Checked == true)
            {
                degree = 4;
            }
            else if (pageQuest4.radioButton25.Checked == true)
            {
                degree = 5;
            }
            commitPoint(degree, Questions.Rows[19]["qtype"].ToString(), Questions.Rows[19]["trait"].ToString());
        }
        
        private void commitPoint(int deg, string qtype, string trait)
        {
            if(qtype == "Overall" || qtype == "Overall ")
            {
                mOverall.addPoint(deg, trait);
            }
            else if(qtype == "Frequency" || qtype == "Frequency ")
            {
                mFrequency.addPoint(deg, trait);
            }
            else  if(qtype == "Intensity" || qtype == "Intensity ")
            {
                mIntensity.addPoint(deg, trait);
            }
            else if(qtype == "Persistence" || qtype == "Persistence ")
            {
                mPersistence.addPoint(deg, trait);
            }
        }
    }
}
