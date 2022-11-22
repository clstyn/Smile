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
    public partial class Smile_Music : Form
    {
        
        public Smile_Music()
        {
            InitializeComponent();
        }

        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql;
        private DataGridViewRow r;

        private void btnSmile_Click(object sender, EventArgs e)
        {
            Smile_Homepage.dashboard.Show();
            this.Hide();
        }

        private void Smile_Music_Load(object sender, EventArgs e)
        {
            loadMusicList();
        }

        private void loadMusicList()
        {
            try
            {
                _connection.Conn.Open();
                dgvMusic.DataSource = null;
                sql = "select * from music_select()";
                cmd = new NpgsqlCommand(sql, _connection.Conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvMusic.DataSource = dt;
                dgvMusic.Columns["ID"].Visible = false;
                dgvMusic.Columns["Genre"].Visible = false;
                dgvMusic.Columns["Year"].Visible = false;

                _connection.Conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Connection Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _connection.Conn.Close();
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {

        }

        private void musicClick(object sender, DataGridViewCellEventArgs e)
        {
            string[] tags = new string[10];
            if (e.RowIndex >= 0)
            {
                r = dgvMusic.Rows[e.RowIndex];
                Music msc = new Music(
                    r.Cells["id"].Value.ToString(),
                    r.Cells["title"].Value.ToString(),
                    r.Cells["artist"].Value.ToString(),
                    tags,
                    Convert.ToInt32(r.Cells["year"].Value.ToString()));

                txtTitle.Text = msc.Title;
                txtArtist.Text = msc.Artist;
            }
        }

        private void searchMusic(object sender, EventArgs e)
        {
            if (tbSearch.Text.Length > 0)
            {
                try
                {
                    _connection.Conn.Open();
                    sql = "select * from music_select()";
                    cmd = new NpgsqlCommand(sql, _connection.Conn);
                    //cmd.Parameters.AddWithValue("_musicTitle", tbSearch.Text);
                    object execute = cmd.ExecuteScalar();
                    if (execute != null)
                    {
                        if (execute.GetType() != typeof(DBNull))
                        {
                            dt = new DataTable();
                            NpgsqlDataReader rd = cmd.ExecuteReader();
                            dt.Load(rd);
                            DataView dv = dt.DefaultView;
                            dv.RowFilter = string.Format("Title like '%{0}%'", tbSearch.Text);
                            dgvMusic.DataSource = dv;
                            dgvMusic.Columns["ID"].Visible = false;
                            dgvMusic.Columns["Genre"].Visible = false;
                            dgvMusic.Columns["Year"].Visible = false;
                        }
                        else
                        {
                            warnLabel.Text = "serach didnt match with any data";
                        }
                    }

                    _connection.Conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error: " + ex.Message);
                    _connection.Conn.Close();
                }
            }
            else
            {
                loadMusicList();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Smile_Homepage.dashboard.Show();
            this.Hide();
        }
    }
}
