using System;
using System.Windows.Forms;

namespace gestion_pantallas
{
    public partial class Form_pantallas : Form_Base.Form1
    {
        public Form_pantallas()
        {
            InitializeComponent();
        }

        private void Form_pantallas_Load(object sender, EventArgs e)
        {
            tabla = "MenuOptions";
            Form1_Load(sender, e);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
