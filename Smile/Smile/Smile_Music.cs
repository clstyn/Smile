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

        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=raven03;Database=dbsmile";

        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql;
        private DataGridViewRow r;

        private void btnSmile_Click(object sender, EventArgs e)
        {
            Smile_Dashboard.dashboard.Show();
            this.Hide();
        }

        private void Smile_Music_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            loadMusicList();
        }
        private void loadMusicList()
        {
            try
            {
                conn.Open();
                dgvMusic.DataSource = null;
                sql = "select * from music_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvMusic.DataSource = dt;
                dgvMusic.Columns["ID"].Visible = false;
                dgvMusic.Columns["Genre"].Visible = false;
                dgvMusic.Columns["Year"].Visible = false;

                conn.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Connection Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    Convert.ToInt32(r.Cells["year"].Value.ToString())
                    );

                txtTitle.Text = msc.Title;
                txtArtist.Text = msc.Artist;
            }
        }
    }
}
