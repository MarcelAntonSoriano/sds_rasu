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
        public string connectionString = "Server=W10B304PC21\\SQLEXPRESS;Database=SecureCode;Trusted_Connection=True";
        public SqlConnection conexion = new SqlConnection();
        DataSet ds;
        SqlDataAdapter da;
        SqlDataReader dr;

        public login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != null)
            {
                btn_login.Enabled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != null)
            {
                btn_login.Enabled = true;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Abrir();

            string query = "select Password from Users where Login = " + textBox1.Text;
            da = new SqlDataAdapter(query, conexion);
            da.Fill(ds);

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
    }
}
