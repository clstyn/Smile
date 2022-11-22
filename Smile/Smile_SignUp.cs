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
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql;
        public Smile_SignUp()
        {
            InitializeComponent();
        }

        private void btnSmile_Click(object sender, EventArgs e)
        {
            Smile_Homepage.dashboard.Show();
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
            if (tbName.Text != null && tbUsernama.Text != null && tbPassword.Text != null && tbConfirm.Text != null)
            {
                if (radMale.Checked || radFemale.Checked)
                {
                    if (tbPassword.Text == tbConfirm.Text)
                    {
                        DateTime birthday = dtBirthday.Value;
                        String.Format("{0:dd/mm/yyyy}", birthday);
                        DateTime current = DateTime.Now;
                        TimeSpan diff = current.Subtract(birthday);
                        DateTime _age = DateTime.MinValue + diff;

                        int age = _age.Year - 1;

                        var newAcc = new UserAccount
                        {
                            Username = tbName.Text,
                            Password = tbPassword.Text,
                            Name = tbUsernama.Text,
                            Gender = radMale.Checked ? "Male" : "Female",
                            Birthday = birthday,
                            Age = age
                        };
                        checkUsername(newAcc);
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

        private void checkUsername(UserAccount newAcc)
        {
            try
            {
                _connection.Conn.Open();
                sql = @"select * from checkUsername(:_username)";
                cmd = new NpgsqlCommand(sql, _connection.Conn);
                cmd.Parameters.AddWithValue("_username", newAcc.Username);
                object execute = cmd.ExecuteScalar();
                if (execute.GetType() != typeof(DBNull))
                {
                    if ((string)cmd.ExecuteScalar() == newAcc.Username)
                    {
                        MessageBox.Show("Username has been used");
                        _connection.Conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("1");
                    signUpAcc(newAcc);
                    _connection.Conn.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
                _connection.Conn.Close();
            }
        }

        private void signUpAcc(UserAccount newAcc)
        {
            try
            {
                _connection.Conn.Open();
                sql = @"select * from signup(:_username, :_pass, :_nama, :_gender, :_birthday, :_age, :_islogin)";
                cmd = new NpgsqlCommand(sql, _connection.Conn);
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
                    _connection.Conn.Close();
                    this.Hide();
                    Smile_Login login = new Smile_Login();
                    login.Show();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
                _connection.Conn.Close();
            }
        }

        private void Smile_SignUp_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(192, 76, 58, 89);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Smile_Homepage.dashboard.Show();
            this.Dispose();
        }

        private void lbUsername_Click(object sender, EventArgs e)
        {
            tbUsernama.Select();
        }

        private void fillUsername(object sender, EventArgs e)
        {
            if (tbUsernama.Text.Length >= 1)
            {
                lbUsername.Visible = false;
            }
            else
            {
                lbUsername.Visible = true;
            }
        }

        private void lbName_Click(object sender, EventArgs e)
        {
            tbName.Select();
        }

        private void fillName(object sender, EventArgs e)
        {
            if (tbName.Text.Length >= 1)
            {
                lbName.Visible = false;
            }
            else
            {
                lbName.Visible = true;
            }
        }

        private void lbPass_Click(object sender, EventArgs e)
        {
            tbPassword.Select();
        }

        private void fillPass(object sender, EventArgs e)
        {
            if (tbPassword.Text.Length >= 1)
            {
                lbPass.Visible = false;
            }
            else
            {
                lbPass.Visible = true;
            }
        }

        private void lbConfirmPass_Click(object sender, EventArgs e)
        {
            tbConfirm.Select();
        }

        private void fillConfirm(object sender, EventArgs e)
        {
            if (tbConfirm.Text.Length >= 1)
            {
                lbConfirmPass.Visible = false;
            }
            else
            {
                lbConfirmPass.Visible = true;
            }
        }
    }
}
