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
    public partial class Smile_Postgree : Form
    {
        public Smile_Postgree()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if(tbUsername.Text!="" && tbPassword.Text != "")
            {
                _connection con = new _connection();
                con.getConn(tbUsername.Text, tbPassword.Text, tbDatabase.Text);
                try
                {
                    _connection.Conn.Open();
                    MessageBox.Show("Koneksi berhasil!");
                    _connection.Conn.Close();
                    this.Hide();
                    Smile_Homepage home = new Smile_Homepage();
                    home.Show();
                }
                catch
                {
                    MessageBox.Show("username atau password postgree salah");
                }

            }
            else
            {
                MessageBox.Show("isi username atau password!");
            }
        }

        private void lbUname_Click(object sender, EventArgs e)
        {
            tbUsername.Select();
        }

        private void fillUname(object sender, EventArgs e)
        {
            if (tbUsername.Text.Length >= 1)
            {
                lbUname.Visible = false;
            }
            else
            {
                lbUname.Visible = true;
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

        private void lbDB_Click(object sender, EventArgs e)
        {
            tbDatabase.Select();
        }

        private void fillDB(object sender, EventArgs e)
        {
            if (tbDatabase.Text.Length >= 1)
            {
                lbDB.Visible = false;
            }
            else
            {
                lbDB.Visible = true;
            }
        }
    }
}
