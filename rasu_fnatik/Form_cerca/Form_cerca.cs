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

namespace Form_cerca
{
    public partial class Form_cerca : Form
    {
        DataSet ds;
        Clase_BBDD bd = new Clase_BBDD();
        string FormulariOrigenGlobal, ControlOrigenGlobal, query, nomColumna;
        public Form_cerca(string FormulariOrigen, string ControlOrigen, string NomTaula)
        {
            InitializeComponent();
            FormulariOrigenGlobal = FormulariOrigen;
            ControlOrigenGlobal = ControlOrigen;

            ds = bd.PortarTaula(NomTaula);

            query = "select * from " + NomTaula;

            dataGridView1.DataSource = ds.Tables[0];

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                nomColumna = dataGridView1.Columns[i].Name;

                if (nomColumna.Contains("id"))
                {
                    dataGridView1.Columns[nomColumna].Visible = false;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string idTaula;


            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == FormulariOrigenGlobal)
                {
                    foreach (Control c in frm.Controls)
                    {
                        if (c.Name == ControlOrigenGlobal)
                        {
                            try
                            {
                                idTaula = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                                c.Text = idTaula;
                                DialogResult = DialogResult.OK;
                                Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("ERROR ");
                            }
                        }
                    }
                }
            }
        }
    }
}
