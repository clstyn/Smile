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
    public partial class Smile_Login : Form
    {
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql;
        private DataGridView dgv;
        private DataGridViewRow r;

        public Smile_Login()
        {
            InitializeComponent();
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text != null && tbPassword.Text != null)
            {
                try
                {
                    var acc = new UserAccount
                    {
                        Username = tbUsername.Text,
                        Password = tbPassword.Text
                    };
                    _connection.Conn.Open();
                    sql = @"select*from signin(:_username, :_pass)";
                    cmd = new NpgsqlCommand(sql, _connection.Conn);
                    cmd.Parameters.AddWithValue("_username", acc.Username);
                    cmd.Parameters.AddWithValue("_pass", acc.Password);
                    object execute = cmd.ExecuteScalar();
                    if (execute.GetType() != typeof(DBNull))
                    {
                        if ((string)execute == acc.Username)
                        {
                            _connection.Conn.Close();
                            getUserData(acc);
                            this.Hide();
                            Smile_Homepage.dashboard.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or Password");
                        _connection.Conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    _connection.Conn.Close();
                }
            }
        }

        private void getUserData(UserAccount acc)
        {
            try
            {
                _connection.Conn.Open();
                sql = @"select * from getUserData(:_username)";
                cmd = new NpgsqlCommand(sql, _connection.Conn);
                cmd.Parameters.AddWithValue("_username", acc.Username);
                dt = new DataTable();
                dgv = new DataGridView();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                if (rd.HasRows)
                {
                    UserAccount.logedUser = new UserAccount
                    {
                        Username = acc.Username,
                        Password = acc.Password,
                        Id = (string)rd[0],
                        Name = (string)rd[1],
                        Gender = (string)rd[2],
                        Birthday = DateTime.Parse((string)rd[3]),
                        Age = Convert.ToInt32((int)rd[4]),
                        islogin = (string)rd[5]
                    };
                    MessageBox.Show("Sign in success", "Welcome " + UserAccount.logedUser.Name + "!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                _connection.Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                _connection.Conn.Close();
            }
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            Smile_SignUp signup = new Smile_SignUp();
            signup.Show();
            this.Dispose();
        }

        private void btnSmile_Click(object sender, EventArgs e)
        {
            Smile_Homepage.dashboard.Show();
            this.Dispose();
        }

        private void Smile_Login_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(192, 76, 58, 89);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Smile_Homepage.dashboard.Show();
            this.Dispose();
        }
    }
}
