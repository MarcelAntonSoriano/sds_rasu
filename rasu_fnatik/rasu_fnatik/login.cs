using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Clase_bbdd_fnatik;
using System.Configuration;

namespace rasu_fnatik
{
    
    public partial class login : Form
    {
        public DataSet ds = new DataSet();
        public Clase_BBDD bbdd = new Clase_BBDD();

        public login()
        {            
            InitializeComponent();
        }
        
        private void textBox(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.Text != null)
            {
                btn_login.Enabled = true;
            }
        }

        //public DataSet ObtenerDatosUsuario(String query)
        //{

        //}

        public void btn_login_Click(object sender, EventArgs e)
        {
            string UserId = null;
            string rangoId = null;

            if (textBox1.Text.Length > 0)
            {
                string query = "SELECT UserCategories.DescCategory, UserCategories.AccessLevel, Users.idUser, Users.UserName FROM UserCategories INNER JOIN Users ON UserCategories.idUserCategory = Users.idUserCategory WHERE(Users.Login = '" + textBox1.Text + "') AND (Users.Password = '" + textBox2.Text + "')";
                ds = bbdd.PortarPerConsulta(query);

                rangoId = (ds.Tables[0].Rows[0][0]).ToString();
                UserId = (ds.Tables[0].Rows[0][2]).ToString();
            }
            else
            {
                label3.Visible = true;
            }

            if (ds.Tables[0].Rows.Count==1)
            {
                ConfigurationManager.AppSettings.Set("idUsuari", UserId);
                ConfigurationManager.AppSettings.Set("rango", rangoId);
                Menu menu_metro = new Menu();
                menu_metro.Show();

                this.Close();
            }
            else
            {
                label3.Visible = true;
            }                        
        }
        private void btn_about_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
    }
}