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
    public partial class Admin_trans : UserControl
    {
        public Admin_trans()
        {
            InitializeComponent();
            AdCurrent_trans_view atc = new AdCurrent_trans_view();
            TransControl(atc);
        }
        private void TransControl(UserControl usercontrol)
        {
            TransPanel.Controls.Clear();
            TransPanel.Controls.Add(usercontrol);
            usercontrol.BringToFront();
        }
        private void Currenttab_Click(object sender, EventArgs e)
        {
            AdCurrent_trans_view atc = new AdCurrent_trans_view();
            TransControl(atc);
           
        }

        private void Savingsbtab_Click(object sender, EventArgs e)
        {
            AdSaving_trans_view atc = new AdSaving_trans_view();
            TransControl(atc);
           

        }

        private void payeetab_Click(object sender, EventArgs e)
        {
            Adpayee_trans_view apv = new Adpayee_trans_view();
            TransControl(apv);

        }

        private void Admin_trans_Load(object sender, EventArgs e)
        {
            
        }
    }
}
