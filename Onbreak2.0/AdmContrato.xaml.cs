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
    /// Lógica de interacción para AdmContrato.xaml
    /// </summary>
    public partial class AdmContrato : Window
    {
        public AdmContrato()
        {
            InitializeComponent();
            dpCreacion.SelectedDate = DateTime.Today;
        }

        private void BtnLista_Click(object sender, RoutedEventArgs e)
        {
            ListadoContrato lc = new ListadoContrato();
            lc.Show();
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                MessageBox.Show("Contrato ingresado Correctamente.");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al ingresar contrato.");
            }
        }
        public void limpiar()
        {
            txtNroContrato.Clear();
            txtDireccion.Clear();
            txtObsv.Clear();
            dpCreacion.SelectedDate = DateTime.Today;
            dpTermino.SelectedDate = null;
            cbVigencia.IsChecked = false;
        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               
                MessageBox.Show("Contrato eliminado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar.");
            }
        }

        private void BtnBuscar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                MessageBox.Show("Contrato encontrado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al encontrar contrato");
            }
            
        }

        private void BtnModificar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                MessageBox.Show("Modificacion exitosa.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al modificar.");
            }
        }
    }
}
