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

        DataSet ds = new DataSet();

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

            Clase_BBDD cb = new Clase_BBDD();
            LabelName.Text = ConfigurationManager.AppSettings["idUsuari"].ToString();
            LabelRank.Text = ConfigurationManager.AppSettings["rango"].ToString();

            string query = "SELECT UserCategories.AccessLevel, Users.idUser, Users.CodeUser FROM UserCategories, Users where UserCategories.idUserCategory = Users.idUserCategory AND idUser = " + int.Parse(ConfigurationManager.AppSettings["idUsuari"].ToString()) ;
            DataSet dts;
            dts = cb.PortarPerConsulta(query);

            query = "select * from MenuOptions where AccessLevel=" + dts.Tables[0].Rows[0]["AccessLevel"];
            ds = cb.PortarPerConsulta(query);
            MessageBox.Show("HOLA");
        }
    }
}
