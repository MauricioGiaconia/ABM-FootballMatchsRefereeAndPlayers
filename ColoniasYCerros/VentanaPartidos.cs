using ColoniasYCerros.Logica;
using ColoniasYCerros.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

using ColoniasYCerros.Scripts;

namespace ColoniasYCerros
{
    public partial class VentanaPartidos : Form
    {
       // private IconButton selectedButton;
        private Panel bordeInferior;
        private Funciones fun = new Funciones();

        private Button botonSeleccionado;

        public Button BotonSeleccionado { get => botonSeleccionado; set => botonSeleccionado = value; }

        public VentanaPartidos()
        {
            InitializeComponent();
            activarBoton(button1);
            aplicarUserControl(new FiltroNuevoJugador());

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VentanaPartidos_Load(object sender, EventArgs e)
        {
            
        }

        private void desactivarBoton()
        {
            this.BotonSeleccionado.BackColor = Color.Gold;
            this.BotonSeleccionado.Font = new Font(this.BotonSeleccionado.Font.Name, this.BotonSeleccionado.Font.Size, System.Drawing.FontStyle.Regular);
        }

        private void activarBoton(Button btn)
        {
            if (btn != null)
            {
                this.BotonSeleccionado = btn;
                btn.BackColor = Color.LightBlue;
                btn.Font = new Font(btn.Font.Name, btn.Font.Size, System.Drawing.FontStyle.Bold);
            }
        }

        private void aplicarUserControl(UserControl filtro)
        {
            filtro.Dock = DockStyle.Fill;
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(filtro);
            filtro.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.BotonSeleccionado != null)
            {
                desactivarBoton();
            }
            
            activarBoton((Button)sender);
            aplicarUserControl(new FiltroNuevoJugador());
        }

        private void buttonListaPartidos_Click(object sender, EventArgs e)
        {
            if (this.BotonSeleccionado != null)
            {
                desactivarBoton();
            }

            activarBoton((Button)sender);
            aplicarUserControl(new FiltroProximosPartidos());
        }
    }
}
