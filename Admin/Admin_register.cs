using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ADIbanking
{
    public partial class Admin_register : UserControl
    {
        public Admin_register()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=retailbankdb");
        private void Logincbtn_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand();
            try
            {


                if (RadioSavings.Checked == true)
                {

                    MySqlCommand cmd = new MySqlCommand("select username from savings_handles where username='" + Usernames.Text + "'", connection);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (Usernames.Text == "" || Passwords.Text == "")
                    {
                        RadioSavings.Checked = false;
                        MessageBox.Show("Unable to sign up.. the text fields cannot be left empty", "Error on sign up", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("user already exist in the  server\nPlease add a different username");
                    }
                    else
                    {
                        connection.Open();
                        command.Connection = connection;
                        command.CommandText = "INSERT INTO savings_handles VALUES ('" + "" + "', '" + Usernames.Text + "','" + Passwords.Text + "','" + "" + "' )";
                        command.ExecuteNonQuery();

                        MessageBox.Show("You have created your account successfully.\nNow you can login", "Registered successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Usernames.Clear();
                        Passwords.Clear();
                        RadioSavings.Checked = false;
                    }
                }
                else if (Radiocurrent.Checked == true)
                {

                    MySqlCommand cmd = new MySqlCommand("select username from current_handles where username='" + Usernames.Text + "'", connection);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (Usernames.Text == "" || Passwords.Text == "")
                    {
                        RadioSavings.Checked = false;
                        MessageBox.Show("Unable to sign up.. the text fields cannot be left empty", "Error on sign up", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("user already exist in the  server\nPlease add a different username");
                    }
                    else
                    {
                        connection.Open();
                        command.Connection = connection;
                        command.CommandText = "INSERT INTO  current_handles VALUES ('" + "" + "', '" + Usernames.Text + "','" + Passwords.Text + "','" + "" + "' )";
                        command.ExecuteNonQuery();

                        MessageBox.Show("You have created your account successfully.\nNow you can login", "Registered successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Usernames.Clear();
                        Passwords.Clear();
                        RadioSavings.Checked = false;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
