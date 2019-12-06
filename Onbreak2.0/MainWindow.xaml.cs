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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Biblioteca;

namespace Onbreak2._0
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAdmCliente_Click(object sender, RoutedEventArgs e)
        {
            AdmCliente ac = new AdmCliente();
            ac.Show();
        }

        private void BtnListadoCliente_Click(object sender, RoutedEventArgs e)
        {
            ListadoCliente lc = new ListadoCliente();
            lc.Show();
        }

        private void BtnAdmContrato_Click(object sender, RoutedEventArgs e)
        {
            AdmContrato ac = new AdmContrato();
            ac.Show();
        }

        private void BtnListadoContrato_Click(object sender, RoutedEventArgs e)
        {
            ListadoContrato lcon = new ListadoContrato();
            lcon.Show();
        }
    }
}
