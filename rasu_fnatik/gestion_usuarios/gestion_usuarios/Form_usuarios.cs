using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_bbdd_fnatik;
using Control_FNATIK;

namespace gestion_usuarios 
{
    public partial class Form_usuarios : Form_Base.Form1
    {
        public Form_usuarios()
        {
            InitializeComponent();
        }

        private void Form_usuarios_Load(object sender, EventArgs e)
        {

            Clase_BBDD cb = new Clase_BBDD();
            DataSet ds = new DataSet();
            DataGridView dataGridView1 = new DataGridView();

            tabla = "Users";
            Form1_Load(sender, e);
            
        }
    }
}
