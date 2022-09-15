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
    public partial class Savings_trans : UserControl
    {
        public Savings_trans()
        {
            InitializeComponent();
        }
        string Intst;
        string withdraw;
        string deposit;
        string refresher;
        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=retailbankdb");
        private void Savings_trans_Load(object sender, EventArgs e)
        {


            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM savings_handles WHERE Username = '" + Savings_login.uName + "'";
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

        private void Withdrawbtn_Click(object sender, EventArgs e)
        {
            MySqlCommand command = connection.CreateCommand();
            withdraw = "Withdraw";
            try
            {
                if (Balance.Text == "0.00")
                {
                    MessageBox.Show(Balance, "You don't have enough funds Please make a deposite");
                }
               else if (double.Parse(Withdrawtxt.Text) >= 500)
                {
                    connection.Open();
                    command.CommandText = "update savings_handles set balance = balance - '" + double.Parse(Withdrawtxt.Text) + "' WHERE Username = '" + Savings_login.uName + "'";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert into history_savings (Username ,type, amount) values('" + Savings_login.uName + "','" + withdraw+ "' ,'" + Withdrawtxt.Text + "')";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Transaction was Succesfully....");
                    Withdrawtxt.Clear();
                   

                }
                else
                {
                    MessageBox.Show(Withdrawtxt, "minimum cash 500");
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

        private void Depositbtn_Click(object sender, EventArgs e)
        {
            MySqlCommand command = connection.CreateCommand();
            deposit = "deposit";
            Intst = "1.2";
            Balance.Refresh();
            Balance.Update();
            try
            {
                if (double.Parse(Deposittxt.Text) >= 500)
                {
                    connection.Open();
                    command.CommandText = "update  savings_handles set balance = balance + '" + double.Parse(Deposittxt.Text) + "'* '" + Intst + "' WHERE Username = '" + Savings_login.uName + "'";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert into  history_savings (Username ,type, amount) values('" + Savings_login.uName + "','" + deposit  + "' ,'" + Deposittxt.Text + "')";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Transaction Added Succesfully....");
                    Deposittxt.Clear();
                    Balance.Refresh();
                    Balance.Update();

                }
                else
                {
                    MessageBox.Show(Deposittxt, "minimum cash 500");
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

        private void Withdrawbtn_MouseClick(object sender, MouseEventArgs e)
        {
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM savings_handles WHERE Username = '" + Savings_login.uName + "'";
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

        private void Depositbtn_MouseClick(object sender, MouseEventArgs e)
        {
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM savings_handles WHERE Username = '" + Savings_login.uName + "'";
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
