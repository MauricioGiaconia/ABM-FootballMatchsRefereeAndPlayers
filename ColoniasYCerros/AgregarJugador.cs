using ColoniasYCerros.Logica;
using ColoniasYCerros.Modelo;
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

namespace ColoniasYCerros
{
    public partial class AgregarJugador : Form
    {

        Funciones fun = new Funciones();

        public AgregarJugador()
        {
            InitializeComponent();
        }


        public void cargarComboBox()
        {
            List<Equipo> aList = EquipoLogico.Instancia.listarDatos();
            Item cbItem;

            foreach (Equipo eqp in aList)
            {
                cbItem = new Item()
                {
                    Text = eqp.Nombre,
                    Value = eqp.Id
                };

                comboBoxEquipos.Items.Add(cbItem);
            }

            comboBoxEquipos.SelectedText = "-- Seleccionar --";
            comboBoxEquipos.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void AgregarJugador_Load(object sender, EventArgs e)
        {
            cargarComboBox();

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            //Crear funcion para quitar espacios a String y comprobar si tiene numeros o no!!!!
            Console.WriteLine("messi y".Trim().All(Char.IsLetter));

            if (!fun.IsNullOrEmpty(textNombre.Text) && (comboBoxEquipos.SelectedItem != null && comboBoxEquipos.SelectedText != "-- Seleccionar --")
                && !textNombre.Text.Trim().All(Char.IsDigit) && !fun.IsNullOrEmpty(textDni.Text) && int.TryParse(textDni.Text, out int i))
            {

                Item itemEquipo = (Item)comboBoxEquipos.SelectedItem;

                Jugador player = new Jugador()
                {
                    Nombre = textNombre.Text,
                    Dni = int.Parse(textDni.Text),
                    Fecha_nacimiento = DateTime.Parse(dateTimePickerNac.Text),
                    JugEquipo = EquipoLogico.Instancia.GetEquipo((int)itemEquipo.Value),
                    Sancionado = checkBoxSancionado.Checked,
                    Fecha_sancion = DateTime.Parse(dateTimePickerSancion.Text)

                };

                Item rta = JugadorLogico.Instancia.guardarJugador(player);

                //Si no se cargar, desplegar cartel con el motivo
                if (!(bool)rta.Value)
                {
                    MessageBox.Show(rta.Text);
                }
                else
                {
                    MessageBox.Show(rta.Text);
                }





            }
            else if (textNombre.Text.Trim().All(Char.IsDigit))
            {
                MessageBox.Show("El nombre del jugador no debe contener numeros!");
            } else if (!int.TryParse(textDni.Text, out int j))
            {
                MessageBox.Show("El DNI del jugador no debe contener letras!");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
