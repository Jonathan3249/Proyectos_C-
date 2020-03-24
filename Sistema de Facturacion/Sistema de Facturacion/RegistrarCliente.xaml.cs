
using System;
using System.Configuration;
using System.Data.OleDb;
using System.Windows;


namespace Sistema_de_Facturacion
{
    /// <summary>
    /// Lógica de interacción para RegistrarCliente.xaml
    /// </summary>
    public partial class RegistrarCliente : Window
    {
        public RegistrarCliente()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Comprueba si el Nit no es igual al de la base de datos
            OleDbConnection agregar = new OleDbConnection();
            agregar.ConnectionString = ConfigurationManager.ConnectionStrings["Conectar"].ToString();
            agregar.Open();
            string buscar = "Select * From [Clientes] Where Nit= '" + Nits.Text + "'";
            OleDbCommand cmd = new OleDbCommand(buscar,agregar);
            OleDbDataReader leer = cmd.ExecuteReader();
            //Cuando la entrada es leida.
            if (leer.Read() == true  )
            {
                if(leer["Nit"].ToString() == Nits.Text) {
                    MessageBox.Show("Este Nit esta asignado en otro cliente");
                    leer.Close();
                    agregar.Close();
                    
                }
                
            }

            else if (Nombres.Text != "" && Nits.Text != "" && Telefonos.Text != "" && Direcciones.Text != "")
            {
                agregar.Close();
                try
                {
                    //Ingresamos los Clientes
                    cmd.CommandText = "INSERT INTO Clientes(Nombre, Dirección, Nit, Teléfono) VALUES ('" + Nombres.Text + "', '" + Direcciones.Text + "','" + Nits.Text + "','" + Telefonos.Text + "');";
                    cmd.Connection = agregar;
                    agregar.Open();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "SELECT @@Identity";
                    agregar.Close();
                    MessageBox.Show("El cliente fue agregado exitosamente");
                }
                catch (Exception assq)
                {

                }

            }
            else MessageBox.Show("Los campos de la tabla no deben quedar vacios");


        }

    }
}
