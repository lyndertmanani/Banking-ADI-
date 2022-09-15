using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADIbanking
{
    public partial class Admin_customer : UserControl
    {
        public Admin_customer()
        {
            InitializeComponent();
        }
        private void AdControl(UserControl usercontrol)
        {
            AdCus.Controls.Clear();
            AdCus.Controls.Add(usercontrol);
            usercontrol.BringToFront();
        }
        private void Savingsbtn_Click(object sender, EventArgs e)
        {
            Ad_Customer_Savings ahm = new Ad_Customer_Savings();
            AdControl(ahm);

        }

        private void Admin_customer_Load(object sender, EventArgs e)
        {
           //empty..... 
        }

        private void Currentbtn_Click(object sender, EventArgs e)
        {
            Ad_Customer_current hm = new Ad_Customer_current();
            AdControl(hm);
        }
    }
}
