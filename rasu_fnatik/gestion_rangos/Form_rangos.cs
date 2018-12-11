using System;
using System.Windows.Forms;

namespace gestion_rangos
{
    public partial class Form_rangos : Form_Base.Form1
    {
        public Form_rangos()
        {
            InitializeComponent();
        }

        private void Form_rangos_Load(object sender, EventArgs e)
        {
            tabla = "UserRanks";
            Form1_Load(sender, e);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
