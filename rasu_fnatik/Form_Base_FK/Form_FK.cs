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
using sdsCodi; 

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

        public void Form_FK_Load(object sender, EventArgs e)
        {
            if (tabla != null)
            {
                ds = bd.PortarTaula(tabla);
                if (DesignMode) return;
                dataGridView1.DataSource = ds.Tables[0];
                foreach (DataGridViewColumn dc in dataGridView1.Columns)
                {
                    dataGridView1.Columns[dc.Name].Visible = !dc.Name.Contains("id");
                }
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
            }
            //dataGridView1.DataSource = ds.Tables[0];
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
                    else if (ctr.GetType() == typeof(sdsCodi.sdsCodi))
                    {
                        sdsCodi.sdsCodi ctr1 = (sdsCodi.sdsCodi)ctr;
                        dr[ctr1.NombreTaula] = ctr.Text;
                    }
                }
                ds.Tables[0].Rows.Add(dr);
            }
            bd.Actualitzar(ds, "select * from " + tabla);
            PortarDades();
            IsNew = false;
        }
    }
}
