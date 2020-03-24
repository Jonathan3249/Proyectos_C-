using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comunicacion_entre_formas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrirforma_Click(object sender, EventArgs e)
        {
            Form2 forma2 = new Form2();
            DialogResult resultado = forma2.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                lblMensaje.Text = forma2.mensaje;
                lblContenido.Text = forma2.contenido;
            }
             else if (resultado == DialogResult.Cancel)
            {
                MessageBox.Show("No seleccionaste una operacion valida");
            }
            
        }
    }
}
