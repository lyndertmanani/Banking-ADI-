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

namespace ADIbanking.Savings
{
    public partial class Savings_Main : Form
    {
        public Savings_Main()
        {
            InitializeComponent();
            //when load home panel always on top
            Savings_home hme = new Savings_home();
            UserSControl(hme);
        }
        MySqlConnection connect = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=retailbankdb");
        private void UserSControl(UserControl usercontrol)
        {
            ControlsSpanel.Controls.Clear();
            ControlsSpanel.Controls.Add(usercontrol);
            usercontrol.BringToFront();
        }
        private void SavingsMain_Load(object sender, EventArgs e)
        {
            string Tag = "SELECT * FROM Savings_handles WHERE Username = '" + Savings_login.uName + "'";
            MySqlDataAdapter data = new MySqlDataAdapter(Tag, connect);
            DataTable table = new DataTable();
            data.Fill(table);
            if (table.Rows.Count == 1)
            {
                Username.Text = Savings_login.uName;
            }

        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            Savings_home hme = new  Savings_home();
            UserSControl(hme);
        }

        private void Viewbtn_Click(object sender, EventArgs e)
        {
            Savings_view sv = new Savings_view();
            UserSControl(sv);
        }

        private void Payee_Click(object sender, EventArgs e)
        {
            Savings_payee sp = new Savings_payee();
            UserSControl(sp);
        }

        private void Trans_Click(object sender, EventArgs e)
        {

            Savings_trans st = new Savings_trans();
            UserSControl(st);
        }

        private void Log_out_Click(object sender, EventArgs e)
        {
            Savings_login sl = new Savings_login();
            this.Hide();
            sl.Show();
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
