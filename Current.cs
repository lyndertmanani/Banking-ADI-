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
    public partial class Current : Form
    {
        public Current()
        {
            InitializeComponent();
            Current_home hme = new Current_home();
            UserControl(hme);
        }
        MySqlConnection connect = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=retailbankdb");
        private void UserControl(UserControl usercontrol)
        {
            Controlpanel.Controls.Clear();
            Controlpanel.Controls.Add(usercontrol);
            usercontrol.BringToFront();
        }
        private void Current_Load(object sender, EventArgs e)
        {
            string Tag = "SELECT * FROM current_handles WHERE Username = '" + current_login.uName + "'";
            MySqlDataAdapter data = new MySqlDataAdapter(Tag, connect);
            DataTable table = new DataTable();
            data.Fill(table);
            if (table.Rows.Count == 1)
            {
                Username.Text = current_login.uName;
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Current_home hme = new Current_home();
            UserControl(hme);
        }

        private void View_Click(object sender, EventArgs e)
        {
            Current_view cv = new Current_view();
            UserControl(cv);
        }

        private void Payee_Click(object sender, EventArgs e)
        {
            Current_payee cp = new Current_payee();
            UserControl(cp);
        }

        private void Trans_Click(object sender, EventArgs e)
        {
            Current_Trans ct = new Current_Trans();
            UserControl(ct);
        }

        private void Log_out_Click(object sender, EventArgs e)
        {
            current_login cl = new current_login();
            this.Hide();
            cl.Show();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
