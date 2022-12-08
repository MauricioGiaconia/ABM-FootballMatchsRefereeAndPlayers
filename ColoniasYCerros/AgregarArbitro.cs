using ColoniasYCerros.Logica;
using ColoniasYCerros.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ColoniasYCerros.Modelo;


namespace ColoniasYCerros
{
    public partial class AgregarArbitro : Form
    {

        Funciones fun = new Funciones();
        public AgregarArbitro()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCargarArbitro_Click(object sender, EventArgs e)
        {
            if (!fun.IsNullOrEmpty(textNombre.Text) && !fun.IsNullOrEmpty(textApellido.Text))
            {
                Item itemArb;

                itemArb = ArbitroLogico.Instancia.cargarArbitro(textNombre.Text, textApellido.Text);

                MessageBox.Show(itemArb.Text);
                
            }
            else
            {
                MessageBox.Show("Alguno de los campos estan vacios, por favor ingrese un nombre y apellido!");
            }
        }
    }
}
