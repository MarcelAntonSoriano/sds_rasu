using System;
using System.Windows.Forms;

namespace gestion_usuarios 
{
    public partial class Form_usuarios : Form_Base_FK.Form_FK
    {
        public Form_usuarios()
        {
            InitializeComponent();
        }

        private void Form_usuarios_Load(object sender, EventArgs e)
        {
            tabla = "Users";
            Form_FK_Load(sender, e);
        }

        private void controlTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void controlTextBox2_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void controlTextBox3_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void controlTextBox4_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void controlTextBox5_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
    }
}