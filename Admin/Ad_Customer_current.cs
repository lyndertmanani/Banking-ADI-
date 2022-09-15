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
    public partial class Ad_Customer_current : UserControl
    {
        public Ad_Customer_current()
        {
            InitializeComponent();
        }
        MySqlConnection connect = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=retailbankdb;convert Zero Datetime=True");

        private void Ad_Customer_current_Load(object sender, EventArgs e)
        {

            MySqlDataAdapter My = new MySqlDataAdapter("SELECT * FROM Current_handles", connect);
            DataTable dTable = new DataTable();
            My.Fill(dTable);
            dataGridView1.DataSource = dTable;
        }

        private void Removebtn_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand();
            try
            {

                connect.Open();
                command.Connection = connect;
                command.CommandText = "DELETE FROM Current_handles WHERE ID = '" + Cid.Text + "'";
                command.ExecuteNonQuery();
                Cid .Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect.Close();
            }
            MySqlDataAdapter My = new MySqlDataAdapter("SELECT * FROM Current_handles", connect);
            DataTable dTable = new DataTable();
            My.Fill(dTable);
            dataGridView1.DataSource = dTable;
        }
    }
}
