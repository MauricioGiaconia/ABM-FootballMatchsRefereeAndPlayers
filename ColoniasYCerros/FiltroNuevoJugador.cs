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
using System.Windows.Documents;
using System.Windows.Forms;

namespace ColoniasYCerros
{
    public partial class FiltroNuevoJugador : UserControl
    {

        Funciones fun = new Funciones();

        public FiltroNuevoJugador()
        {
            InitializeComponent();
            cargarComboBoxVs();
            cargarComboBoxArbitro();
        }

        public void cargarComboBoxVs()
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

                comboBoxEquipo1.Items.Add(cbItem);
                comboBoxEquipo2.Items.Add(cbItem);

            }

            comboBoxEquipo1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEquipo2.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        public void cargarComboBoxArbitro()
        {
            List<Arbitro> aList = ArbitroLogico.Instancia.listarDatos();
            Item cbItem;

            foreach (Arbitro arb in aList)
            {
                cbItem = new Item()
                {
                    Text = arb.Nombre + " " + arb.Apellido,
                    Value = arb.Id
                };

                comboBoxArbitro.Items.Add(cbItem);
            }
           
            comboBoxArbitro.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void buttonCargarPartido_Click(object sender, EventArgs e)
        {
            Item eqpUno, eqpDos, arb;

            if (!fun.IsNullOrEmpty(textBoxPartido.Text))
            {

                if (comboBoxEquipo1.SelectedItem == null || comboBoxEquipo2.SelectedItem == null)
                {
                    System.Windows.MessageBox.Show("Debes seleccionar los equipos que se enfrentarán en el partido!");
                }
                else if (comboBoxArbitro.SelectedItem == null)
                {
                    System.Windows.MessageBox.Show("Debes seleccionar el arbitro que va a dirigir el partido!");
                }
                else
                {
                    eqpUno = (Item)comboBoxEquipo1.SelectedItem;
                    eqpDos = (Item)comboBoxEquipo2.SelectedItem;
                    arb = (Item)comboBoxArbitro.SelectedItem;

                    if (eqpUno.Value != eqpDos.Value)
                    {
                        Partido match = new Partido
                        {
                            NombrePartido = textBoxPartido.Text,
                            EquipoUno = (int)eqpUno.Value,
                            EquipoDos = (int)eqpDos.Value,
                            Arbitro = (int)arb.Value,
                            Fecha_partido = dateTimePicker1.Value

                        };

                        PartidoLogico.Instancia.cargarPartido(match);
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("Los equipos seleccionados no pueden ser iguales!");
                    }
                }
            }
            else
            {
                System.Windows.MessageBox.Show("El campo 'nombre de partido' está vacío!");
            }
        }
    }
}
