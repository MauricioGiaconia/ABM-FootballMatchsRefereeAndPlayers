using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoniasYCerros.Modelo
{
    public class Partido
    {


        private int id;
        private String nombrePartido;
        private int equipoUno;
        private int equipoDos;
        private int arbitro;
        private DateTime fecha_partido;

        public int Id { get => id; set => id = value; }
        public string NombrePartido { get => nombrePartido; set => nombrePartido = value; }
        public int EquipoUno { get => equipoUno; set => equipoUno = value; }
        public int EquipoDos { get => equipoDos; set => equipoDos = value; }
        public int Arbitro { get => arbitro; set => arbitro = value; }
        public DateTime Fecha_partido { get => fecha_partido; set => fecha_partido = value; }


    }
}
