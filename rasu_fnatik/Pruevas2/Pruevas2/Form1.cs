using System;
using System.Data;
using System.Windows.Forms;
using Control_FNATIK;
using Clase_bbdd_fnatik;
using CustomControlButton;
using System.Text.RegularExpressions;

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
            //dataGridView1.DataSource = ds.Tables[0];
        }
        
        //Actualizar
        private void button2_Click(object sender, EventArgs e)
        {
            if (IsNew)
            {
                if (ComprobarTextBoxs())
                {
                    try { 
                        foreach (Control ctr in this.Controls)
                        {
                            if (ctr.GetType() == typeof(ControlTextBox))
                            {
                                ControlTextBox ctr1 = (ControlTextBox)ctr;                        
                       
                                if (ctr1.Campo.Contains("id"))
                                {
                                    ctr1.Text = "1";
                                }
                                else
                                {
                                    dr[ctr1.Campo] = ctr.Text;
                                }
                            }
                        }
                        ds.Tables[0].Rows.Add(dr);
                        PortarDades();
                    }
                    catch (System.NullReferenceException re)
                    {
                        PortarDades();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor rellene correctamente los campos o cree Nuevo.");
                }

            }
            bd.Actualitzar(ds, "select * from " + tabla);
            IsNew = false;
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
            foreach(Control ctr in this.Controls)
            {
                if (ctr.GetType() == typeof(ControlTextBox))
                {
                    ctr.Focus();
                }
            }
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

    }
}