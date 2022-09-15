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
    public partial class Adpayee_trans_view : UserControl
    {
        public Adpayee_trans_view()
        {
            InitializeComponent();
        }
        MySqlConnection connect = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=retailbankdb;convert Zero Datetime=True");

        private void Adpayee_trans_view_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter My = new MySqlDataAdapter("SELECT * FROM payee", connect);
            DataTable dTable = new DataTable();
            My.Fill(dTable);
            PayeeGrid.DataSource = dTable;
        }

        private void Deletbtn_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand();
            try
            {

                connect.Open();
                command.Connection = connect;
                command.CommandText = "DELETE FROM payee WHERE ID = '" + Pid.Text + "'";
                command.ExecuteNonQuery();
                Pid.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect.Close();
            }

            MySqlDataAdapter My = new MySqlDataAdapter("SELECT * FROM payee", connect);
            DataTable dTable = new DataTable();
            My.Fill(dTable);
            PayeeGrid.DataSource = dTable;
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand();
            try
            {

                connect.Open();
                command.Connection = connect;
                command.CommandText = "DELETE FROM payee ";
                command.ExecuteNonQuery();
                Pid.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect.Close();
            }

            MySqlDataAdapter My = new MySqlDataAdapter("SELECT * FROM payee", connect);
            DataTable dTable = new DataTable();
            My.Fill(dTable);
            PayeeGrid.DataSource = dTable;
        }
    }
}
