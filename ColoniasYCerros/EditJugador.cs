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
    public partial class EditData : Form
    {
        private int idJugador;

        public EditData(int xid = 0)
        {
            InitializeComponent();

            if (xid != 0)
            {
                this.IdJugador = xid;
            }
            else
            {
                MessageBox.Show("El jugador ingresado no es correcto");
                this.Close();
            }

            
        }

        public int IdJugador { get => idJugador; set => idJugador = value; }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
