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
    public partial class Current_Trans : UserControl
    {
        public Current_Trans()
        {
            InitializeComponent();
        }
        string withdraw;
        string deposit;
        string refresher;
        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=retailbankdb");
        private void Current_Trans_Load(object sender, EventArgs e)
        {
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM current_handles WHERE Username = '" + current_login.uName + "'";
            MySqlDataReader myReader;

            try
            {
                connection.Open();
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {

                    Balance.Text = myReader["balance"].ToString();
                    refresher = Balance.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        private void Withdrawbtnc_Click(object sender, EventArgs e)
        {
            MySqlCommand command = connection.CreateCommand();
            withdraw = "Withdraw";
            try
            {
                if (Balance.Text == "0.00")
                {
                    MessageBox.Show(Balance, "You don't have enough funds Please make a deposite");
                }
                else if (double.Parse(Withdrawtxtc.Text) >= 500)
                {
                    connection.Open();
                    command.CommandText = "Update current_handles set balance = balance - '" + double.Parse(Withdrawtxtc.Text) + "' WHERE Username = '" + current_login.uName + "'";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert into history_current (Username ,type, amount) values('" + current_login.uName + "','" + withdraw + "' ,'" + Withdrawtxtc.Text + "')";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Transaction was Succesfully....");
                    Withdrawtxtc.Clear();
                }
                else
                {
                    MessageBox.Show(Withdrawtxtc, "minimum cash 500");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        private void Depositbtnc_Click(object sender, EventArgs e)
        {
            MySqlCommand command = connection.CreateCommand();
            deposit = "deposit";
            Balance.Refresh();
            Balance.Update();
            try
            {
                if (double.Parse(Deposittxtc.Text) >= 1500)
                {
                    connection.Open();
                    command.CommandText = "update  current_handles set balance = balance + '" + double.Parse(Deposittxtc.Text) + "' WHERE Username = '" + current_login.uName + "'";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert into  history_current (Username ,type, amount) values('" + current_login.uName + "','" + deposit + "' ,'" + Deposittxtc.Text + "')";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Transaction Added Succesfully....");
                    Deposittxtc.Clear();
                    Balance.Refresh();
                    Balance.Update();

                }
                else
                {
                    MessageBox.Show(Deposittxtc, "minimum cash 1500");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Balance.Refresh();
                Balance.Update();
                connection.Close();
            }

        }

        private void Withdrawbtnc_MouseClick(object sender, MouseEventArgs e)
        {
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM current_handles WHERE Username = '" + current_login.uName + "'";
            MySqlDataReader myReader;

            try
            {
                connection.Open();
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {

                    Balance.Text = myReader["balance"].ToString();
                    refresher = Balance.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        private void Depositbtnc_MouseClick(object sender, MouseEventArgs e)
        {
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM current_handles WHERE Username = '" + current_login.uName + "'";
            MySqlDataReader myReader;

            try
            {
                connection.Open();
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {

                    Balance.Text = myReader["balance"].ToString();
                    refresher = Balance.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }
    }
}
