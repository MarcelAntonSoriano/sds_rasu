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
using System.Configuration;

namespace rasu_fnatik
{
    public partial class Menu : Form
    {

        DataSet ds2 = new DataSet();
        Clase_BBDD bbdd = new Clase_BBDD();

        public Menu()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            LabelName.Text = ConfigurationManager.AppSettings["idUsuari"].ToString();
            LabelRank.Text = ConfigurationManager.AppSettings["rango"].ToString();
        }
    }
}
