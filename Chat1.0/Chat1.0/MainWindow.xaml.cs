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
using System.Threading;
using System.Net.Sockets;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;



namespace Chat1._0
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        //mover formulario
        public static int X = 0;
        public static int Y = 0;


        //socket
        static public string nick = "";
        static private NetworkStream stream;
        static private StreamWriter streamw;
        static private StreamReader streamr;
        static private TcpClient client = new TcpClient();
        

        private delegate void DAddItem(String s);

        public MainWindow()
        {
            InitializeComponent();
            this.Hide();
            Login nombre = new Login();
            nombre.Show();
        }
        private void AddItem(String s)
        {
            LstChat.Items.Add(s);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            streamw.WriteLine(txtChat.Text);
            streamw.Flush();
            txtChat.Clear();
        }

        void Listen()
        {
            while (client.Connected)
            {
                try
                {
                  this.Dispatcher.Invoke(new DAddItem(AddItem), streamr.ReadLine());

                }
                catch
                {
                    System.Windows.MessageBox.Show("No se ha podido conectar al servidor");
                    this.Close();
                }
            }
        }

        public void Conectar()
        {
            try
            {
                client.Connect("127.0.0.1", 8000);
                if (client.Connected)
                {
                    Thread t = new Thread(Listen);

                    stream = client.GetStream();
                    streamw = new StreamWriter(stream);
                    streamr = new StreamReader(stream);

                    streamw.WriteLine(nick);
                    streamw.Flush();

                    t.Start();
                }
                else
                {
                    System.Windows.MessageBox.Show("Servidor no Disponible");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Servidor no Disponible");
                this.Close();
            }
        }

        
    }
}
