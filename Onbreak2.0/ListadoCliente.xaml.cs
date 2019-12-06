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
    /// Lógica de interacción para ListadoCliente.xaml
    /// </summary>
    public partial class ListadoCliente : Window
    {
        Collection c = new Collection();
        public ListadoCliente()
        {
            InitializeComponent();

            c.mostarLista(dgListadoCliente);

            c.cargarCboActividad(cboActividad);
            c.cargarCboEmpresa(cboTipo);
            cboTipo.SelectedIndex = 0;
            cboActividad.SelectedIndex = 0;
        }

        private void BtnFiltro_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                
                
                
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error al filtrar busqueda.");
            }
        }

        
    }
}
