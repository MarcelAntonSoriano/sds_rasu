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
using Sds; 

namespace Form_Base_FK
{
    public partial class Form_FK : Form
    {
        DataSet ds = new DataSet();
        Clase_BBDD bd = new Clase_BBDD();
        bool IsNew = false;
        public string tabla { get; set; }
        DataRow dr;
        public Form_FK()
        {
            InitializeComponent();
        }

        private void Form_FK_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            if (tabla != null)
            {
                ds = bd.PortarTaula(tabla);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Visible = false;
                PortarDades();
            }
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
                else if(ctr.GetType() == typeof(sdsCodi))
                {
                    ((sdsCodi)ctr).DataBindings.Clear();
                    ctr.Text = "";
                    ((sdsCodi)ctr).DataBindings.Add("NombreCodi", ds.Tables[0], ((sdsCodi)ctr).NombreTaula);
                }
            }
            //dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dr = ds.Tables[0].NewRow();
            IsNew = true;
            int count = 0;
            foreach (Control ctr in this.Controls)
            {
                if (ctr.GetType() == typeof(ControlTextBox))
                {
                    ((ControlTextBox)ctr).DataBindings.Clear();
                    ctr.Text = "";
                    //if(count==0) controlTextBox1.Focus();                   
                    count++;
                }
                else if (ctr.GetType() == typeof(sdsCodi))
                {
                    ((sdsCodi)ctr).DataBindings.Clear();
                    ctr.Text = "";
                    //if(count==0) controlTextBox1.Focus();                   
                    count++;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IsNew)
            {
                foreach (Control ctr in this.Controls)
                {
                    if (ctr.GetType() == typeof(ControlTextBox))
                    {
                        ControlTextBox ctr1 = (ControlTextBox)ctr;

                        dr[ctr1.Campo] = ctr.Text;
                    }
                    else if (ctr.GetType() == typeof(sdsCodi))
                    {
                        sdsCodi ctr1 = (sdsCodi)ctr;
                        dr[ctr1.NombreTaula] = ctr.Text;
                    }
                }
                ds.Tables[0].Rows.Add(dr);
            }
            bd.Actualitzar(ds, "select * from " + tabla);
            IsNew = false;
        }
    }
}
