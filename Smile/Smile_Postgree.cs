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
                con.getConn(tbUsername.Text, tbPassword.Text);
                try
                {
                    _connection.Conn.Open();
                    MessageBox.Show("Koneksi berhasil!");
                    _connection.Conn.Close();
                    Smile_Homepage home = new Smile_Homepage();
                    home.Show();
                    this.Dispose();
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
    }
}
