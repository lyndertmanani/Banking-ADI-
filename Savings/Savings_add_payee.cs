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
using MySql.Data.MySqlClient;

namespace ADIbanking.Savings
{
    public partial class Savings_add_payee : Form
    {
        public Savings_add_payee()
        {
            InitializeComponent();
        }
        
        MySqlConnection connect = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=retailbankdb;convert Zero Datetime=True");
        private void Loginbtn_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand();
            try
            {
            MySqlCommand cmd = new MySqlCommand("select * from Payee where Firstname='" + Firstname.Text + "' AND  Lastname='" + Lastname.Text + "'", connect);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (Firstname.Text == "" || Lastname.Text == "")
            {
                
                MessageBox.Show("Unable toAdd payeep.. the text field(s) can not be left empty", "Field(s)...", MessageBoxButtons.OK);
            }
            else if (dt.Rows.Count > 0)
            {
                      
                MessageBox.Show("Payee already exist in the  server\nPlease add a different payee or transfer funds to the existing payee " );
            }
            else
            {
                connect.Open();
                command.Connection = connect;
                command.CommandText = "INSERT INTO payee VALUES ('" + "" + "', '" + Firstname.Text + "','" + Lastname.Text + "','" + "" + "' )";
                command.ExecuteNonQuery();

                MessageBox.Show("payee added successfully.\nNow you can transfer funds", "successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Firstname.Clear();
                Lastname.Clear();
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

  
    }
}
