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
    public partial class Savings_login : Form
    {
        public Savings_login()
        {
            InitializeComponent();
        }
        public static string uName;
       
        private void Savings_login_Load(object sender, EventArgs e)
        {

        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=retailbankdb";
            MySqlConnection connection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand command = new MySqlCommand();

            try
            {

                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM savings_handles WHERE Username = '" +Username.Text + "' and Password = '" + Password.Text + "'";
                MySqlDataReader rd = command.ExecuteReader();
                uName = Username.Text;
                int count = 0;
                while (rd.Read())
                {
                    count = count + 1;

                }
               
               if (Username.Text == "" || Password.Text == "")
                { 
                    MessageBox.Show("Unable to Login.. the text fields cannot be left empty", "Error on Login", MessageBoxButtons.OK );
                }
                else if(count == 1)
                {
                    Savings.Savings_Main sm = new Savings.Savings_Main();
                    this.Hide();
                    sm.Show();
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

    

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup sgp = new Signup();
            this.Hide();
            sgp.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            admin ad = new admin();
            this.Hide();
            ad.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            current_login crt = new current_login();
            this.Hide();
            crt.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
