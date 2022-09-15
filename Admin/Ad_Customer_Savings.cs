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
    public partial class Ad_Customer_Savings : UserControl
    {
        public Ad_Customer_Savings()
        {
            InitializeComponent();
        }
        MySqlConnection connect = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=retailbankdb;convert Zero Datetime=True");

        private void Ad_Customer_Savings_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter My = new MySqlDataAdapter("SELECT * FROM savings_handles", connect);
            DataTable dTable = new DataTable();
            My.Fill(dTable);
            SavingsGridad.DataSource = dTable;
        }

        private void Removebtn_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand();
            try
            {

                connect.Open();
                command.Connection = connect;
                command.CommandText = "DELETE FROM Savings_handles WHERE ID = '" + Sid.Text + "'";
                command.ExecuteNonQuery();
                Sid.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect.Close();
            }
            MySqlDataAdapter My = new MySqlDataAdapter("SELECT * FROM savings_handles", connect);
            DataTable dTable = new DataTable();
            My.Fill(dTable);
            SavingsGridad.DataSource = dTable;
        }
    }
}
