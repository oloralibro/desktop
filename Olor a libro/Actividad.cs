using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olor_a_libro
{
    public class Actividad
    {
        public String nombre { get; set; }
        public String descripcion { get; set; }
        public String direccion { get; set; }
        public int puntos { get; set; }

        public Actividad(String nombre, String descripcion, int puntos)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.direccion = "";
            this.puntos = puntos;
        }
    }
}
