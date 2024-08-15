using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stajdenemeApp
{
    public partial class Form_menu : Form
    {
        public Form_menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_kisisorgulama frm = new Form_kisisorgulama();
            frm.ShowDialog();
        }

        private void btndogum_Click(object sender, EventArgs e)
        {
            Form_Dogum frm = new Form_Dogum();
            frm.ShowDialog();
        }

        private void btnolum_Click(object sender, EventArgs e)
        {
            FrmOlum frm = new FrmOlum();
            frm.ShowDialog();
        }
        private void btnevlenme_Click(object sender, EventArgs e)
        {
            FormEvlenme frm = new FormEvlenme();
            frm.ShowDialog();
        }
    }
}
