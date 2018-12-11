using System;
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
    }
}
