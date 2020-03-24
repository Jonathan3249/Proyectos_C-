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

namespace Chat1._0
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnUsuario_Click(object sender, RoutedEventArgs e)
        {
            MainWindow chat = new MainWindow();
            MainWindow.nick = txtUsuario.Text;         
            chat.Show();
            this.Close();
            chat.Conectar();
            
            
        }
    }
}
