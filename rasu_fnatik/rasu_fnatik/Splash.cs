using System;
using System.Windows.Forms;

namespace rasu_fnatik
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }             

        private void timer1_Tick(object sender, EventArgs e)
        {            
            login login = new login();
            login.Show();
            this.Close();
        }
    }
}
