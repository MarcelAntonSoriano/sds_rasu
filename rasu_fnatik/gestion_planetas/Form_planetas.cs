using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
