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
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=raven03;Database=dbsmile";

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
                        Username=tbUsername.Text,
                        Password=tbPassword.Text
                    };
                    conn.Open();
                    sql = @"select*from signin(:_username, :_pass)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_username", acc.Username);
                    cmd.Parameters.AddWithValue("_pass", acc.Password);
                    if ((string)cmd.ExecuteScalar() == acc.Username)
                    {
                        MessageBox.Show("Sign in success","Welcome "+acc.Name+"!",MessageBoxButtons.OK,MessageBoxIcon.Information);

                        conn.Close();
                        getUserData(acc);

                        this.Hide();
                        Smile_Profile.dasbor_profil.Show();
                    }
                    else if((int)cmd.ExecuteScalar()==0)
                    {
                        MessageBox.Show("Wrong Username or Password");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: "+ex.Message);
                    conn.Close();
                }
            }
        }

        private void getUserData(UserAccount acc)
        {
            try
            {
                conn.Open();
                sql = @"select * from getUserData(:_username)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_username", acc.Username);
                dt = new DataTable();
                dgv = new DataGridView();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                MessageBox.Show(dt.Rows.Count.ToString());
                dgv.DataSource = dt;
                MessageBox.Show(dgv.Rows.Count.ToString());
                r = dgv.Rows[0];

                UserAccount.logedUser = new UserAccount
                {
                    Username = acc.Username,
                    Password = acc.Password,
                    Id=r.Cells["idusr"].Value.ToString(),
                    Name = r.Cells["nama"].Value.ToString(),
                    Gender = r.Cells["gender"].Value.ToString(),
                    Birthday = DateTime.Parse(r.Cells["birthday"].Value.ToString()),
                    Age = Convert.ToInt32(r.Cells["age"].Value.ToString()),
                    islogin = r.Cells["islogin"].Value.ToString()
                };
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                conn.Close();
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
            Smile_Dashboard.dashboard.Show();
            this.Dispose();
        }

        private void Smile_Login_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(192, 76, 58, 89);
            conn = new NpgsqlConnection(connstring);
        }
    }
}
