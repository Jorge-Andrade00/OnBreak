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
    /// Lógica de interacción para ListadoContrato.xaml
    /// </summary>
    public partial class ListadoContrato : Window
    {
        Collection2 c = new Collection2();
        public ListadoContrato()
        {
            InitializeComponent();
            c.mostarLista(dgListadoContrato);
        }

        private void TxtMultiuso_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
