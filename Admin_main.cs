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
    public partial class Admin_main : Form
    {
        public Admin_main()
        {
            InitializeComponent();
            Admin_register Ar = new Admin_register();
            UserControl(Ar);
        }
        MySqlConnection connect = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=retailbankdb");
        private void Admin_main_Load(object sender, EventArgs e)
        {
            string Tag = "SELECT * FROM admin_handles WHERE Username = '" + admin.u3Name + "'";
            MySqlDataAdapter data = new MySqlDataAdapter(Tag, connect);
            DataTable table = new DataTable();
            data.Fill(table);
            if (table.Rows.Count == 1)
            {
                Actuserad.Text = admin.u3Name;
            }
        }
        private void UserControl(UserControl usercontrol)
        {
            Control_panel.Controls.Clear();
            Control_panel.Controls.Add(usercontrol);
            usercontrol.BringToFront();
        }

        private void Log_out_Click(object sender, EventArgs e)
        {
            admin ad = new admin();
            this.Hide();
            ad.Show();
        }

        private void Customerbtn_Click(object sender, EventArgs e)
        {
            Admin_customer hm = new Admin_customer();
            UserControl(hm);
        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            Admin_register Ar = new Admin_register();
            UserControl(Ar);
        }

        private void Trans_Click(object sender, EventArgs e)
        {
            Admin_trans At = new Admin_trans();
            UserControl(At);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
