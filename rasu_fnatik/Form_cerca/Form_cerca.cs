using System;
using System.Data;
using System.Windows.Forms;
using Clase_bbdd_fnatik;

namespace Form_cerca
{
    public partial class Form_cerca : Form
    {
        Clase_BBDD bd = new Clase_BBDD();
        DataSet ds = new DataSet();

        string query, nomColumna, FormulariOrigenGlobal, ControlOrigenGlobal;
        public Form_cerca(string FormulariOrigen, string ControlOrigen, string NomTaula)
        {
            InitializeComponent();
            FormulariOrigenGlobal = FormulariOrigen;
            ControlOrigenGlobal = ControlOrigen;
            ds = bd.PortarTaula(NomTaula);
            query = "select * from " + NomTaula;

            dataGridView2.DataSource = ds.Tables[0];

            for(int i = 0; i < dataGridView2.ColumnCount; i++)
            {
                nomColumna = dataGridView2.Columns[i].Name;

                if (!(nomColumna.Contains("Code") && !(nomColumna.Contains("Desc"))))
                {
                    dataGridView2.Columns[nomColumna].Visible = false;
                }
                
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            string idTaula;

            try
            {
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
                                    idTaula = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                                    c.Text = idTaula;

                                    DialogResult = DialogResult.OK;
                                    Close();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error:" + ex);
                                }
                            }
                        }
                    }
                }
            }
            catch(Exception )
            {

            }
        }
    }
}
