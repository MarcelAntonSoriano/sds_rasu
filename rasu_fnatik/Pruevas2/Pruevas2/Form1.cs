using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Clase_bbdd_fnatik;
using Control_FNATIK;


namespace Form_Base
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet();
        Clase_BBDD bd = new Clase_BBDD();
        bool IsNew = false;
        public string tabla { get; set; }
        DataRow dr;
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 0, 0, 0);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(1, 255, 255, 255);

            dataGridView1.EnableHeadersVisualStyles = false;
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
            }
        }
        
        //Actualizar
        private void button2_Click(object sender, EventArgs e)
        {
            if (IsNew)
            {
                //try { 
                foreach (Control ctr in this.Controls)
                {
                    if (ctr.GetType() == typeof(ControlTextBox))
                    {
                        ControlTextBox ctr1 = (ControlTextBox)ctr;

                        if (ctr1.Campo.Contains("id")) ctr1.Text = "1";
                    }
                }
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
                //}
                //catch (System.NullReferenceException re)
                //{
                //    PortarDades();
                //}               
            }
            bd.Actualitzar(ds, "select * from " + tabla);
            IsNew = false;
        }

        //Nuevo
        private void button1_Click(object sender, EventArgs e)
        {
            dr = ds.Tables[0].NewRow();
            IsNew = true;

            foreach (Control ctr in Controls)
            {
                if (ctr.GetType() == typeof(ControlTextBox))
                {
                   ((ControlTextBox)ctr).DataBindings.Clear();
                    ctr.Text = "";                 
                }
            } 
            foreach(Control ctr in Controls)
            {
                if (ctr.GetType() == typeof(ControlTextBox)) ctr.Focus();
            }
        }

        public bool ComprobarTextBoxs()
        {
            bool permitir = true;
            foreach (Control ctr in Controls)
            {
                if (ctr.GetType() == typeof(ControlTextBox))
                {
                    if (((ControlTextBox)ctr).Text == "") permitir = false;
                }
            }
            return permitir;
        }
    }
}