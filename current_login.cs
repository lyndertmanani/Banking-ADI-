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
    public partial class current_login : Form
    {
        public current_login()
        {
            InitializeComponent();
        }
        public static string uName;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup sgn = new Signup();
            this.Hide();
            sgn.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            admin ad = new admin();
            this.Hide();
            ad.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Savings_login sgnl = new Savings_login();
            this.Hide();
            sgnl.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void Logincbtn_Click(object sender, EventArgs e)
        {
            string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=retailbankdb";
            MySqlConnection connection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand command = new MySqlCommand();

            try
            {

                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM current_handles WHERE Username = '" + Usernamec.Text + "' and Password = '" + Passwordc.Text + "'";
                MySqlDataReader rd = command.ExecuteReader();
                uName = Usernamec.Text;
                int count = 0;
                while (rd.Read())
                {
                    count = count + 1;

                }

                if (Usernamec.Text == "" || Passwordc.Text == "")
                {
                    MessageBox.Show("Unable to Login.. the text fields cannot be left empty", "Error on Login", MessageBoxButtons.OK);
                }
                else if (count == 1)
                {
                    Current cm = new Current();
                    this.Hide();
                    cm.Show();
                }
                else
                {
                    MessageBox.Show("Unable to Login.. Please check your login credentials", "Error on Login", MessageBoxButtons.OK);
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
    }
}
