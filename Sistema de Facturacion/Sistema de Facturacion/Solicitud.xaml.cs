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

namespace Sistema_de_Facturacion
{
    /// <summary>
    /// Lógica de interacción para Solicitud.xaml
    /// </summary>
    public partial class Solicitud : Window
    {
        public Solicitud()
        {
            InitializeComponent();

            guardarUsuario.Content = "Jonathan";
            
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void facturas_Click(object sender, RoutedEventArgs e)
        {
            Factura llamar = new Factura();
            llamar.ShowDialog();

        }

        private void agregarClientes_Click(object sender, RoutedEventArgs e)
        {
            RegistrarCliente llamarCliente = new RegistrarCliente();
            llamarCliente.ShowDialog();

            
            
            
            

        }

        private void ActivosClientes_Click(object sender, RoutedEventArgs e)
        {
            ClientesEmpresa llamarActivosClientes = new ClientesEmpresa();
            llamarActivosClientes.ShowDialog();
        }
    }
}
