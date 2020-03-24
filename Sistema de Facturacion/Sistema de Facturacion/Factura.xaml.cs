using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
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
    /// Lógica de interacción para Factura.xaml
    /// </summary>
    public partial class Factura : Window
    {
        public Factura()
        {
            InitializeComponent();
            nit.Focus();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void baseDatos()
        {
            OleDbConnection conexion = new OleDbConnection();
            conexion.ConnectionString = ConfigurationManager.ConnectionStrings["Conectar"].ToString();
            conexion.Open();
            string buscar = "Select * From [Clientes] Where Nit= '" + nit.Text + "'";
            OleDbCommand comando = new OleDbCommand(buscar, conexion);
            OleDbDataReader leer = comando.ExecuteReader();
            try

            {
                if (leer.Read() == true)
                {
                    nombre.Text = leer["Nombre"].ToString();
                    direccion.Text = leer["Dirección"].ToString();
                    nit.Text = leer["Nit"].ToString();
                    String Id = leer["Id_cliente"].ToString();
                    conexion.Close();

                }
                else
                {
                    MessageBox.Show("Nit no registrado en la base de datos");
                    direccion.Text = "";
                    nit.Text = "";
                    nombre.Text = "";
                    conexion.Close();
                }
                conexion.Close();
                leer.Close();
            }
            catch (Exception ass)
            {

            }


        }

        private void consultar_Click(object sender, RoutedEventArgs e)
        {
            
            baseDatos();
            OleDbConnection conexion = new OleDbConnection();
            conexion.ConnectionString = ConfigurationManager.ConnectionStrings["Conectar"].ToString();
            conexion.Open();

            //                C.Nombre,
            //C.Nit, F.FormaPago,
            //D.Cantidad
            //FROM
            //Facturas F, Clientes C, Detalles D
            //WHERE C.Id_Cliente = F.Id_Cliente AND D.Id_Factura = F.Id_Factura AND C.Nit = ''

            //string guiar = "Select Clientes.Nit, Productos.Nombre_producto, Productos.Descripcion_Producto, Productos.Precio, Facturas.Fecha, Detalles.Cantidad From Clientes, Productos, Facturas, Detalles  WHERE Nit ='" + nit.Text + "'";
            string guiar = "Select C.Nombre AS [Cliente], C.Nit, F.Forma_pago AS [Forma de Pago], D.Cantidad, E.Nombre AS [Vendedor]" +
                " FROM Facturas F, Clientes C, Detalles D, Empleados E" +
                " WHERE C.Id_Cliente = F.Id_CLiente AND D.Id_Factura = F.Id_Factura AND E.Id_empleado = F.Id_empleado AND Nit ='" + nit.Text + "'";

            //string guiar = "Select Clientes.Nombre, Clientes.Nit, Facturas.Forma_pago, [Detalles.Cantidad]" +
            //    "FROM Clientes INNERJOIN Facturas ON Clientes.Id_cliente = Facturas.Id_cliente" +
            //    "INNERJOIN Detalles ON Detalles.Id_factura = Facturas.Id_Factura WHERE Nit ='" + nit.Text + "'";
            //
            OleDbCommand comando = new OleDbCommand(guiar, conexion);
            OleDbDataReader Identificar = comando.ExecuteReader();
            MostrarDatos.ItemsSource = Identificar;
        }

        private void mover(object sender, KeyEventArgs e)
        {
            System.Windows.Input.Key k = e.Key;
            bool controlKeyIsDown = Keyboard.IsKeyDown(Key.LeftShift);
            if (!controlKeyIsDown && Key.D0 <= k && k <= Key.D9) e.Handled = false;
          
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            Solicitud llamar = new Solicitud();
            this.Close();
            llamar.Show();
            
            
        }
    }
}
