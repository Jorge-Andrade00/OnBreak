using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Biblioteca;

namespace Onbreak2._0
{
    /// <summary>
    /// Lógica de interacción para AdmCliente.xaml
    /// </summary>
    public partial class AdmCliente : Window
    {
        Collection c = new Collection();
        public AdmCliente()
        {
            InitializeComponent();
            c.abrirConexion();
            c.cargarCboActividad(cboActividad);
            c.cargarCboEmpresa(cboTipo);
            cboTipo.SelectedIndex = 0;
            cboActividad.SelectedIndex = 0; 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListadoCliente lc = new ListadoCliente();
            lc.Show();
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (c.verificarRegistro(txtRut.Text) == false)
                {
                    if (txtRut.Text.Length > 1 && txtRazonSocial.Text.Length > 1 && txtNombre.Text.Length > 1 && txtMail.Text.Length > 1 && txtDireccion.Text.Length > 1 && txtTelefono.Text.Length > 1 && cboActividad.SelectedIndex != 0 && cboTipo.SelectedIndex != 0)
                    {
                        c.agregar(txtRut.Text, txtRazonSocial.Text, txtNombre.Text, txtMail.Text, txtDireccion.Text, txtTelefono.Text, Convert.ToInt32(cboActividad.SelectedValue), Convert.ToInt32(cboTipo.SelectedValue));
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Error al ingresar datos. Intente nuevamente");
                    }
                }
                else
                {
                    MessageBox.Show("Rut duplicado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar Cliente. Intente nuevamente.");
            }
        }
        public void limpiar()
        {
            txtRut.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtMail.Clear();
            txtRazonSocial.Clear();
            txtTelefono.Clear();
            cboTipo.SelectedIndex = 0;
            cboActividad.SelectedIndex = 0;
        }

        private void BtnBuscar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (c.verificarRegistro(txtRut.Text) == true)
                {
                    c.buscar(txtRut.Text, txtRazonSocial, txtNombre, txtMail, txtDireccion, txtTelefono, cboActividad, cboTipo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rut invalido.");
            }
        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void BtnModificar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               
                MessageBox.Show("Modificacion exitosa.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se realizó modificación.");
            }
        }
    }
}
