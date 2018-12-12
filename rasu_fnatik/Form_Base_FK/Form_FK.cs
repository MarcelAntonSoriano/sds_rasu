using System;
using System.Data;
using System.Drawing;
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
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0,0,0,0);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(1, 255, 255, 255);
            dataGridView1.EnableHeadersVisualStyles = false;
            ActualitzarDataset();
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
        }
        //Nuevo
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
        //Actualizar
        private void button2_Click(object sender, EventArgs e)
        {
            if (IsNew)
            {            
                /*try
                {*/
                foreach (Control ctr in this.Controls)
                {
                    if (ctr.GetType() == typeof(ControlTextBox))
                    {
                        ControlTextBox ctr1 = (ControlTextBox)ctr;

                        if (ComprobarTextBoxs()) dr[ctr1.Campo] = ctr.Text;

                    }
                }

                if (ComprobarTextBoxs())
                {
                    ds.Tables[0].Rows.Add(dr);
                }
                else
                {
                    MessageBox.Show("Por favor rellene correctamente los campos o cree Nuevo.");
                }
                PortarDades();
                   
                /*}
                catch (System.NullReferenceException)
                {
                   PortarDades();
                }*/
                //ds.Clear();
                //ActualitzarDataset();
            
            }
            bd.Actualitzar(ds, "select * from " + tabla);
            IsNew = false;
        }

        public bool ComprobarTextBoxs()
        {
            bool permitir = true;
            foreach (Control ctr in this.Controls)
            {
                if (ctr.GetType() == typeof(ControlTextBox))
                {
                    if (((ControlTextBox)ctr).Text == "") permitir = false;
                }
            }
            return permitir;
        }

        public void ActualitzarDataset ()
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
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell dcell in dr.Cells)
                    {
                        if (dcell.Value.ToString() == "") dcell.Value = "NULL";
                    }
                }
                PortarDades();
            }
        }
    }
}
