using System;
using System.Data;
using System.Windows.Forms;
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
            btn_login.Enabled = tb.Text != null;
        }

        public void btn_login_Click(object sender, EventArgs e)
        {

            string UserId = null;

            if (textBox1.Text.Length <= 0 && textBox2.Text.Length <= 0)
            {
                label3.Visible = true;
                return;
            }

            string query = "SELECT UserCategories.DescCategory, UserCategories.AccessLevel, Users.idUser, Users.UserName FROM UserCategories INNER JOIN Users ON UserCategories.idUserCategory = Users.idUserCategory WHERE(Users.Login = '" + textBox1.Text + "') AND (Users.Password = '" + textBox2.Text + "')";
            ds = bbdd.PortarPerConsulta(query);

            if (ds.Tables[0].Rows.Count != 1)
            {
                label3.Visible = true;
                return;
            }

            UserId = (ds.Tables[0].Rows[0][2]).ToString();
            ConfigurationManager.AppSettings.Set("idUsuari", UserId);

            Menu menu_metro = new Menu();
            menu_metro.Show();

            this.Close();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}