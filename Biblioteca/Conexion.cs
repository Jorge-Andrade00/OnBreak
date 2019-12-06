using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Windows.Data;
using System.Windows.Controls;

namespace Biblioteca
{
    public class Conexion
    {
        string cadena = "Data Source= DESKTOP-7I13GRH\\SQLEXPRESS; Initial Catalog= OnBreak; Integrated Security = True";
        public SqlConnection conectar = new SqlConnection();

        public DataTable tabla;
        public SqlDataReader dr;
        public SqlCommand consulta;
        public SqlDataAdapter da;

        public Conexion()
        {
            conectar.ConnectionString = cadena;
        }

        public void abrirConexion()
        {
            try
            {
                conectar.Open();
                Console.WriteLine("Se abrió correctamente");


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir bd: " + ex.Message);
            }
        }

    }
}
