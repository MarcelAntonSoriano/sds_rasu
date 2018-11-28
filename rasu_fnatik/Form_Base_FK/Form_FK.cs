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
            ds = bd.PortarTaula(tabla);
            if (DesignMode) return;
            dataGridView1.DataSource = ds.Tables[0];
            foreach (DataGridViewColumn  dc in dataGridView1.Columns)
            {
                dataGridView1.Columns[dc.Name].Visible = dc.Name.Contains("id");
            }
        }

        public void PortarDades()
        {
            int count = 0;
            
            foreach (Control ctr in this.Controls)
            {
                if (ctr.GetType() == typeof(ControlTextBox))
                {
                    ((ControlTextBox)ctr).DataBindings.Clear();
                    ctr.Text = "";
                    if (!((ControlTextBox)ctr).EsForanea)
                    {                       
                        ((ControlTextBox)ctr).DataBindings.Add("Text", ds.Tables[0], ((ControlTextBox)ctr).Campo);
                    }
                    else
                    {
                        ((ControlTextBox)ctr).DataBindings.Add("Text", ds.Tables[0], ((ControlTextBox)ctr).Campo);
                        count++;
                    }
                    
                }
                else if(ctr.GetType() == typeof(sdsCodi.sdsCodi))
                {
                    ((sdsCodi.sdsCodi)ctr).DataBindings.Clear();
                    ctr.Text = "";
                    ((sdsCodi.sdsCodi)ctr).DataBindings.Add("NombreCodi", ds.Tables[0], ((sdsCodi.sdsCodi)ctr).NombreCodi);
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
                else if (ctr.GetType() == typeof(sdsCodi.sdsCodi))
                {
                    ((sdsCodi.sdsCodi)ctr).DataBindings.Clear();
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
                    else if (ctr.GetType() == typeof(sdsCodi.sdsCodi))
                    {
                        sdsCodi.sdsCodi ctr1 = (sdsCodi.sdsCodi)ctr;
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
