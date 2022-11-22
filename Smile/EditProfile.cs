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
    public partial class EditProfile : UserControl
    {
        public static NpgsqlCommand cmd;
        private string sql;

        private void fillUname(object sender, EventArgs e)
        {
            if (tbUsername.Text.Length >= 1)
            {
                lbConfirm.Visible = false;
            }
            else
            {
                lbConfirm.Visible = true;
            }
        }

        public EditProfile()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove your account?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    _connection.Conn.Open();
                    sql = @"select deleteuser(:id)";
                    cmd = new NpgsqlCommand(sql, _connection.Conn);
                    cmd.Parameters.AddWithValue("id", UserAccount.logedUser.Id.ToString());
                    if ((bool)cmd.ExecuteScalar() == true)
                    {
                        MessageBox.Show("Account Deleted!");
                    }
                    _connection.Conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    _connection.Conn.Close();
                }
            }
        }

        public void FillForm(UserAccount acc)
        {
            tbUsername.Text = acc.Username;
            tbName.Text = acc.Name;
            tbPassword.Text = acc.Password;
            dtBirthday.Value = acc.Birthday;
            if (acc.Gender == "Male")
            {
                radMale.Checked = true;
            }
            else
            {
                radFemale.Checked = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DateTime birthday = dtBirthday.Value;
            String.Format("{0:dd/mm/yyyy}", birthday);

            var changesAcc = new UserAccount
            {
                Username = tbUsername.Text,
                Password = tbPassword.Text,
                Name = tbName.Text,
                Gender = radMale.Checked ? "Male" : "Female",
                Birthday = birthday
            };

            EditAcc(changesAcc);
        }

        private void EditAcc(UserAccount acc)
        {
            try
            {
                _connection.Conn.Open();
                sql = @"select updateuser(:_id, :_username, :_pass, :_nama, :_gender, :_birthday)";
                cmd = new NpgsqlCommand(sql, _connection.Conn);
                cmd.Parameters.AddWithValue("_id", UserAccount.logedUser.Id);
                cmd.Parameters.AddWithValue("_username", acc.Username);
                cmd.Parameters.AddWithValue("_pass", acc.Password);
                cmd.Parameters.AddWithValue("_nama", acc.Name);
                cmd.Parameters.AddWithValue("_gender", acc.Gender);
                cmd.Parameters.AddWithValue("_birthday", acc.Birthday.ToShortDateString());
                if ((bool)cmd.ExecuteScalar() == true)
                {

                    MessageBox.Show("Profile Edited!");

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
                _connection.Conn.Close();
            }
        }
    }
}
