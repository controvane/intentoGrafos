using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace intentoGrafos
{
    class Conectador
    {
        SqlConnectionStringBuilder constr;
        SqlConnection conexion;
        SqlDataAdapter adaptador;
        DataSet datos;

        //data source es el nombre del servidor, catalog es la base de datos
        public Conectador(string dataSource,string catalog)
        {
            this.constr = new SqlConnectionStringBuilder();
            this.constr.DataSource = dataSource;//"RWBY\\SQLEXPRESS";
            this.constr.InitialCatalog = catalog;//"proyectoFinal";
            this.constr.IntegratedSecurity = true;
            this.datos = new DataSet();
            this.adaptador = new SqlDataAdapter();
        }

        //convierte el query a un dataset para enviar al datagrid view, usa consultas cerradas, este es para leer datos
        public DataTable conversor(string query, Dictionary<string, object> parametros, string tabla)
        {
            this.conexion = new SqlConnection(this.constr.ConnectionString);
            SqlCommand comando = new SqlCommand(query, this.conexion);
            foreach (var pair in parametros)
            {
                comando.Parameters.AddWithValue(pair.Key, pair.Value);
            }
            this.adaptador.SelectCommand = comando;
            this.conexion.Open();
            this.adaptador.Fill(this.datos, tabla);
            this.conexion.Close();
            return this.datos.Tables[tabla];
        }

        //realiza las operaciones que solo se pueden realizar con una conexion abierta y verifica si tuvieron exito, este para escribir datos
        public bool openConversor(string query, Dictionary<string, object> parametros)
        {
            this.conexion = new SqlConnection(this.constr.ConnectionString);
            SqlCommand comando = new SqlCommand(query, this.conexion);
            foreach (var pair in parametros)
            {
                comando.Parameters.AddWithValue(pair.Key, pair.Value);
            }
            bool final;
            this.conexion.Open();
            using (this.conexion)
            {
                try
                {
                    SqlDataReader reader = comando.ExecuteReader();
                    reader.Close();
                    final = true;
                }
                catch (Exception ex)
                {
                    final = false;
                }
            }
            this.conexion.Close();
            return final;
        }

        //Ejecuta un procedimiento almacenado en la base usando una conexion cerrada
        public DataTable closedProcedure(String nomProcedure, Dictionary<string, object> parametros)
        {
            this.conexion = new SqlConnection(this.constr.ConnectionString);
            SqlCommand comando = new SqlCommand(nomProcedure, this.conexion);
            comando.CommandType = CommandType.StoredProcedure;
            foreach (var pair in parametros)
            {
                comando.Parameters.AddWithValue(pair.Key, pair.Value);
            }
            this.adaptador.SelectCommand = comando;
            this.conexion.Open();
            this.adaptador.Fill(this.datos, nomProcedure);
            this.conexion.Close();
            return this.datos.Tables[nomProcedure];
        }

        //Ejecuta un procedimiento determinado de la base de datos con una conexion abierta
        public bool openProcedure(String nomProcedure, Dictionary<string, object> parametros)
        {
            this.conexion = new SqlConnection(this.constr.ConnectionString);
            SqlCommand comando = new SqlCommand(nomProcedure, this.conexion);
            comando.CommandType = CommandType.StoredProcedure;
            foreach (var pair in parametros)
            {
                Console.WriteLine(pair.Key + ": " + pair.Value);
                comando.Parameters.AddWithValue(pair.Key, pair.Value);
            }
            bool final;
            this.conexion.Open();
            using (this.conexion)
            {
                try
                {
                    SqlDataReader reader = comando.ExecuteReader();
                    reader.Close();
                    final = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + ": " + ex.InnerException);
                    final = false;
                }
            }
            this.conexion.Close();
            return final;
        }
    }
}
