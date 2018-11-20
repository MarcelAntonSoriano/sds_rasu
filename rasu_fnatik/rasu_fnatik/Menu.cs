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
            DataSet dts;
            string rango = null;
            string id = null;
            string query = null;

            id = ConfigurationManager.AppSettings["idUsuari"].ToString();
            rango = ConfigurationManager.AppSettings["rango"].ToString();

            query = "select U.UserName, UR.DescRank from Users U, UserRanks UR where U.idUserRank = UR.idUserRank and U.idUser = " + id;
            dts = cb.PortarPerConsulta(query);

            LabelName.Text = "Name :   " + (dts.Tables[0].Rows[0][0]).ToString();
            LabelRank.Text = "Rank :   " + (dts.Tables[0].Rows[0][1]).ToString();

            query = "SELECT UserCategories.AccessLevel, Users.idUser, Users.CodeUser FROM UserCategories, Users where UserCategories.idUserCategory = Users.idUserCategory AND idUser = " + id ;
            dts = new DataSet();
            dts = cb.PortarPerConsulta(query);

            query = "select * from MenuOptions where nivel_acces <= " + dts.Tables[0].Rows[0]["AccessLevel"];
            ds = cb.PortarPerConsulta(query);
            

        }
    }
}
