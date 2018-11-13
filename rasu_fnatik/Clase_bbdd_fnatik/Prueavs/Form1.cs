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

namespace Prueavs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet taula = new DataSet();
            Clase_BBDD cd = new Clase_BBDD();
            taula = cd.PortarPerId(1, "Users");
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = taula;
        }
    }
}
