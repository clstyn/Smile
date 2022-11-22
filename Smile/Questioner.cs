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
    public class Questioner
    {
        private int id;
        private string question;
        private string category;
        private int[] point;

        public int ID { get => id; set => id = value; }
        public string Question { get => question; set => question = value; }
        public string Category { get => category; set => category = value; }
        public int[] Point { get => point; set => point = value; }

        public static NpgsqlCommand cmd;
        private string sql;

        public DataTable dt;

        public void loadQuestionnaire()
        {
            try
            {
                _connection.Conn.Open();
                sql = "select * from questionnaire_select()";
                cmd = new NpgsqlCommand(sql, _connection.Conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                _connection.Conn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message, "Connection Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _connection.Conn.Close();
            }
        }
    }
}
