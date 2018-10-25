using Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rasu_fnatik
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != null && textBox2.Text != null)
            {
                btn_login.Enabled = true;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //logar y chapar
            frmMenu menu_metro = new frmMenu();
            menu_metro.Show();
            this.Close();
        }
    }
}
