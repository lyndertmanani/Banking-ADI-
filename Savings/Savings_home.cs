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
    public partial class Savings_home : UserControl
    {
        public Savings_home()
        {
            InitializeComponent();
        }
        MySqlConnection connect = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=retailbankdb");
        private void Savings_home_Load(object sender, EventArgs e)
        {
            MySqlCommand command = connect.CreateCommand();
            command.CommandText = "SELECT * FROM Savings_handles WHERE Username = '" + Savings_login.uName + "'";
            MySqlDataReader myReader;

            try
            {
                connect.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    Actuser.Text = Savings_login.uName;
                    Balance.Text = myReader["Balance"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connect.Close();

        }
    }
}
