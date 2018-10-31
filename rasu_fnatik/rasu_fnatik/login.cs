using Menu;
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


namespace rasu_fnatik
{
    public partial class login : Form
    {
        public string connectionString = "Server=W10B304PC21\\SQLEXPRESS;Database=SecureCore;User Id=FNATIK;Password=123";
        public SqlConnection conexion = new SqlConnection();
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        SqlDataReader dr;

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

        private void btn_login_Click(object sender, EventArgs e)
        {
            Abrir();

            if (textBox1.Text.Length > 0)
            {
                string query = "select Password from Users where Login = " + textBox1.Text;
                da = new SqlDataAdapter(query, conexion);
                da.Fill(ds);
            }
            else
            {
                label3.Visible = true;

            }
            

            Cerrar();
            //logar y chapar
            if ((textBox2.Text).Equals(ds)) {
                frmMenu menu_metro = new frmMenu();
                menu_metro.Show();
                this.Close();
            }
            else
            {
                label3.Visible = true;
            }            
        }
        private void Abrir()
        {
            try
            {
                conexion.ConnectionString = connectionString;
                conexion.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la BD");
            }
        }

        private void Cerrar()
        {
            conexion.Close();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            frmMenu menu_metro = new frmMenu();
            menu_metro.Show();
        }
    }
}
