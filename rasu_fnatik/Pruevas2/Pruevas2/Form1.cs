using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control_FNATIK;
using Clase_bbdd_fnatik;

namespace Form_Base

{
    public partial class Form1 : Form
    {
        DataSet ds;
        Clase_BBDD bd = new Clase_BBDD();
        bool IsNew = false;
        DataRow dr;
        public string tabla = "UserRanks";
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            ds = new DataSet();

            ds = bd.PortarTaula(tabla);
            dataGridView1.DataSource = ds.Tables[0];
            PortarDades();
        }

        public void PortarDades()
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr.GetType() == typeof(ControlTextBox))
                {
                    ((ControlTextBox)ctr).DataBindings.Clear();
                    ctr.Text = "";
                    ((ControlTextBox)ctr).DataBindings.Add("Text", ds.Tables[0], ((ControlTextBox)ctr).Campo);
                }
            }
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IsNew) {

                foreach (Control ctr in this.Controls)
                {
                    if (ctr.GetType() == typeof(ControlTextBox))
                    {
                        ControlTextBox ctr1 = (ControlTextBox)ctr;

                        dr[ctr1.Campo] = ctr.Text;
                    }
                }


                ds.Tables[0].Rows.Add(dr);
          
            }
            bd.Actualitzar(ds, "select * from " + tabla);
            IsNew = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dr = ds.Tables[0].NewRow();
            IsNew = true;

            foreach (Control ctr in this.Controls)
            {
                if (ctr.GetType() == typeof(ControlTextBox))
                {
                   ((ControlTextBox)ctr).DataBindings.Clear();
                    ctr.Text = "";
                   
                }
            }

            controlTextBox1.Focus();       
        }

        private void controlTextBox3_Leave(object sender, EventArgs e)
        {
            PortarDades();
        }
    }
}