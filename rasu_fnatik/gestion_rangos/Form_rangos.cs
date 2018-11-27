using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
