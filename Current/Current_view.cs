﻿using System;
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
    public partial class Current_view : UserControl
    {
        public Current_view()
        {
            InitializeComponent();
        }
        MySqlConnection connect = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=retailbankdb;convert Zero Datetime=True");

        private void Current_view_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter My = new MySqlDataAdapter("SELECT * FROM history_current WHERE Username = '" + current_login.uName + "'", connect);
            DataTable dTable = new DataTable();
            My.Fill(dTable);
            dataGridView1.DataSource = dTable;
        }

        private void Deletbtn_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand();
            try
            {
                connect.Open();
                command.Connection = connect;
                command.CommandText = "DELETE FROM history_current WHERE ID = '" + Idboxhis.Text + "'";
                command.ExecuteNonQuery();
                Idboxhis.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect.Close();
            }
            MySqlDataAdapter My = new MySqlDataAdapter("SELECT * FROM history_current WHERE Username = '" + current_login.uName + "'", connect);
            DataTable dTable = new DataTable();
            My.Fill(dTable);
            dataGridView1.DataSource = dTable;
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand();
            try
            {
                MessageBox.Show("This process will clear your history");
                connect.Open();
                command.Connection = connect;
                command.CommandText = "DELETE  FROM history_current WHERE Username = '" + current_login.uName + "'";
                command.ExecuteNonQuery();
                Idboxhis.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect.Close();
            }
            MySqlDataAdapter My = new MySqlDataAdapter("SELECT * FROM history_current WHERE Username = '" + current_login.uName + "'", connect);
            DataTable dTable = new DataTable();
            My.Fill(dTable);
            dataGridView1.DataSource = dTable;
        }
    }
}
