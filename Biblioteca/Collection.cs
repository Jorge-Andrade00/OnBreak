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
    public class Collection : Conexion
    {
        public void mostarLista(DataGrid dg)
        {
            try
            {
                da = new SqlDataAdapter("select * from Cliente", conectar);
                tabla = new DataTable();
                da.Fill(tabla);
                dg.ItemsSource = tabla.DefaultView;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error: " + ex.Message);
            }
        }

        public void cargarCboActividad(ComboBox cbo)
        {
            try
            {
                da = new SqlDataAdapter("select IdActividadEmpresa, Descripcion from ActividadEmpresa;", conectar);
                tabla = new DataTable();
                da.Fill(tabla);

                DataRow fila = tabla.NewRow();
                fila["Descripcion"] = "Seleccione";
                tabla.Rows.InsertAt(fila,0);

            
                cbo.SelectedValuePath = "IdActividadEmpresa";
                cbo.DisplayMemberPath = "Descripcion";
                cbo.ItemsSource = tabla.DefaultView;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error: " + ex.Message);
            }
        }

        public void cargarCboEmpresa(ComboBox cbo)
        {
            try
            {
                da = new SqlDataAdapter("select IdTipoEmpresa, Descripcion from TipoEmpresa;", conectar);
                tabla = new DataTable();
                da.Fill(tabla);

                DataRow fila = tabla.NewRow();
                fila["Descripcion"] = "Seleccione";
                tabla.Rows.InsertAt(fila, 0);


                cbo.SelectedValuePath = "IdTipoEmpresa";
                cbo.DisplayMemberPath = "Descripcion";
                cbo.ItemsSource = tabla.DefaultView;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error: " + ex.Message);
            }
        }

        public bool verificarRegistro(string rutCliente)
        {
            bool verificador = false;
            try
            {
                consulta = new SqlCommand("Select * from Cliente where RutCliente = '" + rutCliente + "'", conectar);
                dr = consulta.ExecuteReader();
                while (dr.Read())
                {
                    verificador = true;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return verificador;
        }

        public void agregar (string rutCliente, string razonSocial, string nombreContacto, string mailContacto, string direccion, string telefono, int actividadEmpresa, int tipoEmpresa)
        {
            try
            {
                consulta = new SqlCommand
                ("Insert into Cliente (RutCliente, RazonSocial, NombreContacto, MailContacto, Direccion, Telefono, IdActividadEmpresa,IdTipoEmpresa) values('" + rutCliente + "','" + razonSocial + "','" + nombreContacto + "', '" + mailContacto + "', '" + direccion + "', '" + telefono + "', " + actividadEmpresa + ", " + tipoEmpresa + ")", conectar);
                consulta.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public void buscar(string rutCliente, TextBox razonSocial, TextBox nombre, TextBox mail, TextBox direccion, TextBox telefono, ComboBox cbo1, ComboBox cbo2)
        {
            consulta = new SqlCommand("select c.RutCliente, c.RazonSocial, c.NombreContacto, c.MailContacto," +
                "                             c.Direccion, c.Telefono, ae.IdActividadEmpresa,ae.Descripcion as actividadEmp," +
                "                             te.IdTipoEmpresa,te.Descripcion as tipoEmp" +
                "                      from Cliente c " +
                "                      inner join ActividadEmpresa ae on (c.IdActividadEmpresa = ae.IdActividadEmpresa) " +
                "                      inner join TipoEmpresa te on (c.IdTipoEmpresa = te.IdTipoEmpresa) " +
                "                      where RutCliente = '" + rutCliente + "'", conectar);
            dr = consulta.ExecuteReader();
            while (dr.Read())
            {
                razonSocial.Text = dr["RazonSocial"].ToString();
                nombre.Text = dr["NombreContacto"].ToString();
                mail.Text = dr["MailContacto"].ToString();
                direccion.Text = dr["Direccion"].ToString();
                telefono.Text = dr["Telefono"].ToString();
                cbo1.Text = dr["actividadEmp"].ToString();
                cbo2.Text = dr["tipoEmp"].ToString();
            }
            dr.Close();
        }
    }
}
