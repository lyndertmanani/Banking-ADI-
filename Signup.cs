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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }
        
        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=retailbankdb");
        private void Logincbtn_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand();
            try
            {
 

                if (Savingbtn.Checked == true)
                {

                    MySqlCommand cmd = new MySqlCommand("select username from savings_handles where username='" + Username.Text + "'", connection);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (Username.Text == "" || Password.Text == "")
                    {
                        Savingbtn.Checked = false;
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
                        command.CommandText = "INSERT INTO savings_handles VALUES ('" + "" + "', '" + Username.Text + "','" + Password.Text + "','" +"" + "' )";
                        command.ExecuteNonQuery();

                        MessageBox.Show("You have created your account successfully.\nNow you can login", "Registered successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Username.Clear();
                        Password.Clear();
                        Savingbtn.Checked = false;
                    }
                }
                else if(Currentbtn.Checked == true)
                {

                    MySqlCommand cmd = new MySqlCommand("select username from current_handles where username='" + Username.Text + "'", connection);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (Username.Text == "" || Password.Text == "")
                    {
                        Currentbtn.Checked = false;
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
                        command.CommandText = "INSERT INTO  current_handles VALUES ('" + "" + "', '" + Username.Text + "','" + Password.Text + "','" + "" + "' )";
                        command.ExecuteNonQuery();

                        MessageBox.Show("You have created your account successfully.\nNow you can login", "Registered successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Username.Clear();
                        Password.Clear();
                        Currentbtn.Checked = false;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
      

        }
        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Savings_login sgnl = new Savings_login();
            this.Hide();
            sgnl.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            admin ad = new admin();
            this.Hide();
            ad.Show();
 
        }

      
    }
}
