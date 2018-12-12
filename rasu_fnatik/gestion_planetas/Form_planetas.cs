using System;
using System.Windows.Forms;
using Form_Base_FK;

namespace gestion_planetas
{
    public partial class Form_planetas : Form_FK
    {
        public Form_planetas()
        {
            InitializeComponent();
        }

        private void Form_planetas_Load(object sender, EventArgs e)
        {
            tabla = "Planets";
            Form_FK_Load(sender, e);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void controlTextBox3_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void controlTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void controlTextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
