using System.Configuration;
using System.Data.OleDb;
using System.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string usuario;
        public MainWindow()
        {
            InitializeComponent();
            txt_usuario.Focus();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnIniciar_Click(object sender, RoutedEventArgs e)
        {
            //valida los datos de usuario con la base de datos

            usuario = txt_usuario.Text;
            string contrasena = txt_contrasena.Password;
            

            if (txt_usuario.Text == "" && txt_contrasena.Password == "")
            {
                MessageBox.Show("Los campos no deben quedar vacios.");
                this.txt_usuario.Focus();
                return;
                
            }

            else
            {
                //busca en la base de datos el id_empleado
                OleDbConnection conexion = new OleDbConnection();
                conexion.ConnectionString = ConfigurationManager.ConnectionStrings["Conectar"].ToString();
                conexion.Open();

                OleDbCommand comando = new OleDbCommand("SELECT * FROM Empleados WHERE Nombre= '" + txt_usuario.Text + "' AND Password1= '" + txt_contrasena.Password + "'", conexion);
                OleDbDataReader Lector = comando.ExecuteReader();

                if (Lector.Read() == true)
                {
                    Solicitud despLogin = new Solicitud();
                    this.Close();
                    despLogin.Show();
                }
                else
                {
                    MessageBox.Show("Verifique su nombre y contraseña");
                    conexion.Close();
                }

                
            }


        }
    }
}
