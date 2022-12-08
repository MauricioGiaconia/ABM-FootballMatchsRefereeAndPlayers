using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoniasYCerros.Modelo
{
    public class Equipo
    {
        private int id;
        private String nombre;
        private bool abandona;
        private DateTime fecha_sancion = DateTime.Now;

        public Equipo() { }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public bool Abandona { get => abandona; set => abandona = value; }
        public DateTime Fecha_sancion { get => fecha_sancion; set => fecha_sancion = value; }
    }
}
