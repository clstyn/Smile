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
    public partial class Smile_SignUp : Form
    {
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=raven03;Database=dbsmile";

        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql;
        public Smile_SignUp()
        {
            InitializeComponent();
        }

        private void btnSmile_Click(object sender, EventArgs e)
        {
            Smile_Dashboard.dashboard.Show();
            this.Dispose();
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            Smile_Login login = new Smile_Login();
            login.Show();
            this.Dispose();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if(tbUsernama.Text != null && tbName.Text != null && tbPassword.Text != null && tbConfirm.Text != null)
            {
                if(radMale.Checked || radFemale.Checked)
                {
                    if(tbPassword.Text == tbConfirm.Text)
                    {
                        DateTime birthday = dtBirthday.Value;
                        String.Format("{0:dd/mm/yyyy}", birthday);
                        DateTime current = DateTime.Now;
                        TimeSpan diff = current.Subtract(birthday);
                        DateTime _age = DateTime.MinValue + diff;

                        int age = _age.Year - 1;
                        
                        var newAcc = new UserAccount
                        {
                            Username = tbUsernama.Text,
                            Password = tbPassword.Text,
                            Name = tbName.Text,
                            Gender = radMale.Checked ? "Male" : "Female",
                            Birthday = birthday,
                            Age = age
                        };
                        
                        signUpAcc(newAcc);
                    }
                    else
                    {
                        MessageBox.Show("Password didnt match!");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill all data!");
                }
            }
            else
            {
                MessageBox.Show("Please fill all data!");
            }
        }

        private void signUpAcc(UserAccount newAcc)
        {
            try
            {
                
                conn.Open();
                sql = @"select * from signup(:_username, :_pass, :_nama, :_gender, :_birthday, :_age, :_islogin)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_username", newAcc.Username);
                cmd.Parameters.AddWithValue("_pass", newAcc.Password);
                cmd.Parameters.AddWithValue("_nama", newAcc.Name);
                cmd.Parameters.AddWithValue("_gender", newAcc.Gender);
                cmd.Parameters.AddWithValue("_birthday", newAcc.Birthday.ToShortDateString());
                cmd.Parameters.AddWithValue("_age", newAcc.Age);
                cmd.Parameters.AddWithValue("_islogin", "true");
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Sign Up success!");
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }

        private void Smile_SignUp_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(192, 76, 58, 89);

            conn = new NpgsqlConnection(connstring);
        }
    }
}
