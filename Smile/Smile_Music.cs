﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Smile.Properties;
using System.IO;
using System.Reflection;

namespace Smile
{
    public partial class Smile_Music : Form
    {
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        private static string mediaUrl;

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
            player.URL = mediaUrl;
            player.controls.play();
            MessageBox.Show(mediaUrl);
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
                lbSearch.Visible = false;
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
                lbSearch.Visible = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Smile_Homepage.dashboard.Show();
            this.Hide();
        }

        private void lbBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                mediaUrl = dlg.FileName;
                play();
            }
        }
        private void play()
        {
            player.URL = mediaUrl;
            player.controls.play();
        }

        private void lbSearch_Click(object sender, EventArgs e)
        {
            tbSearch.Select();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            
        }
    }
}
