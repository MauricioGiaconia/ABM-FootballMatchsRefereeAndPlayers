using ColoniasYCerros.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColoniasYCerros
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void buttonMostrarJug_Click(object sender, EventArgs e)
        {
            using (MostrarDatos ventanaMostrar = new MostrarDatos())
            {
                ventanaMostrar.ShowDialog();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddJug_Click(object sender, EventArgs e)
        {
            using (AgregarJugador ventanaAgregar = new AgregarJugador())
            {
                ventanaAgregar.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            JugadorLogico.Instancia.cargarMuchos(500);
        }

        private void buttonCargarArbitro_Click(object sender, EventArgs e)
        {
            using (AgregarArbitro ventanaAgregarArb = new AgregarArbitro())
            {
                ventanaAgregarArb.ShowDialog();
            }
        }

        private void buttonCargarEquipo_Click(object sender, EventArgs e)
        {
            using (AgregarEquipo ventanaAgregarEqp = new AgregarEquipo())
            {
                ventanaAgregarEqp.ShowDialog();
            }
        }

        private void buttonCargarPartido_Click(object sender, EventArgs e)
        {
            using (VentanaPartidos ventanaAgregarPartido = new VentanaPartidos())
            {
                ventanaAgregarPartido.ShowDialog();
            }
        }
    }
}
