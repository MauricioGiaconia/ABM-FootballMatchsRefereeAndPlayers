using ColoniasYCerros.Logica;
using ColoniasYCerros.Modelo;
using ColoniasYCerros.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColoniasYCerros
{
    public partial class AgregarEquipo : Form
    {

        Funciones fun = new Funciones();
        public AgregarEquipo()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCargarEquipo_Click(object sender, EventArgs e)
        {
            if (!fun.IsNullOrEmpty(textEquipo.Text.Trim()))
            {
                Item rta = EquipoLogico.Instancia.addDato(textEquipo.Text.Trim());
                MessageBox.Show(rta.Text);
            }
        }
    }
}
