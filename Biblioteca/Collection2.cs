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
    public class Collection2 : Conexion
    {
        public void mostarLista(DataGrid dg)
        {
            try
            {
                da = new SqlDataAdapter("select * from Contrato", conectar);
                tabla = new DataTable();
                da.Fill(tabla);
                dg.ItemsSource = tabla.DefaultView;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error: " + ex.Message);
            }
        }
    }
}
