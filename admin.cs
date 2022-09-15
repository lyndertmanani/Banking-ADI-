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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        public static string u3Name;
        private void Loginadbtn_Click(object sender, EventArgs e)
        {
            string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=retailbankdb";
            MySqlConnection connection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand command = new MySqlCommand();

            try
            {

                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM savings_handles WHERE Username = '" + Usernamead.Text + "' and Password = '" + Passwordad.Text + "'";
                MySqlDataReader rd = command.ExecuteReader();
                u3Name = Usernamead.Text;
                int count = 0;
                while (rd.Read())
                {
                    count = count + 1;

                }

                if (Usernamead.Text == "" || Passwordad.Text == "")
                {
                    MessageBox.Show("Unable to Login.. the text fields cannot be left empty", "Error on Login", MessageBoxButtons.OK);
                }
                else if (count == 1)
                {
                    Admin_main sm = new Admin_main();
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

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            current_login crt = new current_login();
            this.Hide();
            crt.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Savings_login sgl = new Savings_login();
            this.Hide();
            sgl.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

       
    }
}
