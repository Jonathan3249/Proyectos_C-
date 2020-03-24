using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace Sistema_de_Facturacion
{
    /// <summary>
    /// Lógica de interacción para ClientesEmpresa.xaml
    /// </summary>
    public partial class ClientesEmpresa : Window
    {
        public ClientesEmpresa()
        {
            InitializeComponent();
            llamada();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //cierra la ventana
            this.Close();
        }

        private void llamada()
        {
            //muestra los datos de los clientes 
            OleDbConnection conexion = new OleDbConnection();
            conexion.ConnectionString = ConfigurationManager.ConnectionStrings["Conectar"].ToString();
            conexion.Open();
            OleDbCommand comando = new OleDbCommand();
            comando.CommandText = "Select * From [Clientes]";
            comando.Connection = conexion;
            OleDbDataReader leer = comando.ExecuteReader();
            ClientesActivos.ItemsSource = leer;
        }
    }
}
