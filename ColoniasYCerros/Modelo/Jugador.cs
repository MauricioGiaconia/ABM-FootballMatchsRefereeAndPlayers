using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Windows.Forms;

namespace ColoniasYCerros.Modelo
{
    public class Jugador
    {
        private int id = 0;
        private String nombre = "";
        private int dni = 0;
        private DateTime fecha_nacimiento = DateTime.Now;
        private Equipo jugEquipo;
        private bool sancionado = false;
        private DateTime fecha_sancion = DateTime.Now;

        public Jugador()
        {

        }

        public int Id { get => id; set => id = value; }

     
        public string Nombre { get => nombre; set => nombre = value; }
        public int Dni { get => dni; set => dni = value; }
        public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public Equipo JugEquipo { get => jugEquipo; set => jugEquipo = value; }
        public string Equipo { get => jugEquipo.Nombre; }
        
        public bool Sancionado { get => sancionado; set => sancionado = value; }
        public DateTime Fecha_sancion { get => fecha_sancion; set => fecha_sancion = value; }

        public override string ToString()
        {
            return "Jugador: " + Nombre;
        }
    }
}
