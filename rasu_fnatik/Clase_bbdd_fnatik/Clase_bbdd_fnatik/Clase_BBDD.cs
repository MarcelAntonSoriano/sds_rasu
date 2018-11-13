using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Clase_bbdd_fnatik
{
    public class Clase_BBDD
    {
        private string connectionString = "Server=den1.mssql8.gear.host;Database=securecorefnatik;User Id=securecorefnatik;Password=Gj95_E~Qgmm5";
        private SqlConnection conexion = new SqlConnection();
        DataSet taula;
        SqlDataAdapter da;
        public DataSet PortarTaula(string nom_taula)
        {
            taula = new DataSet();       
            Abrir();
            string query = "select * from " + nom_taula;
            da = new SqlDataAdapter(query, conexion);
            da.Fill(taula);
            Cerrar();
            return taula;
        }

        public DataSet PortarPerConsulta(string consulta)
        {
            taula = new DataSet();
            Abrir();
            da = new SqlDataAdapter(consulta, conexion);
            da.Fill(taula);
            Cerrar();
            return taula;
        }

        public DataSet PortarPerConsulta(string consulta, string nom_taula)
        {
            taula = new DataSet();

            Abrir();
            taula.Tables[0].TableName = nom_taula;
            da = new SqlDataAdapter(consulta, conexion);
            da.Fill(taula);
            Cerrar();

            return taula;
        }

        public DataTable PortarPerConsultaTable(string consulta)
        {
            DataTable taula = new DataTable();
            Abrir();
            da = new SqlDataAdapter(consulta, conexion);
            da.Fill(taula);
            Cerrar();
            return taula;
        }
       
        public void Executa(string query)
        {
            SqlCommand sqlCommand = new SqlCommand(query);            
            sqlCommand.ExecuteNonQuery();
         
        }        
        public DataSet Actualitzar(DataSet t_entrada,string consulta)
        {
            
            Abrir();
            da = new SqlDataAdapter(consulta, conexion);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);

            da.Update(t_entrada.Tables[0]);
            Cerrar();            
            return t_entrada;
        }

        public DataSet PortarPerId(string id, int valor,string nom_taula)
        {
            taula = new DataSet();

            Abrir();

            string query = "select * from " + nom_taula + " where " + id + " = " + valor;
            da = new SqlDataAdapter(query, conexion);
            da.Fill(taula);

            Cerrar();

            return taula;
        }
        public DataSet PortarPerId(int valor, string nom_taula)
        {
            DataTable taula2 = new DataTable();
            DataColumn[] id;
            taula = new DataSet();
            Abrir();

            string query = "select * from " + nom_taula;

            da = new SqlDataAdapter(query, conexion);
            da.Fill(taula2);

            id = taula2.PrimaryKey;
            
            query = "select * from " + nom_taula + " where " + id[0].ToString() + " = " + valor;
            da = new SqlDataAdapter(query, conexion);
            da.Fill(taula);

            Cerrar();

            return taula;
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
