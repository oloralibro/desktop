using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olor_a_libro
{
    public class Libreria
    {
        public String nombre { get; set; }
        public String direccion { get; set; }
        public String horaApertura { get; set; }
        public String horaCierre { get; set; }
        public String numeroTelefono { get; set; }
        public List<Actividad> listaActividades { get; set; }

        public Libreria(String nombre, String direccion, String horaApertura, String horaCierre, String numeroTelefono)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.horaApertura = horaApertura;
            this.horaCierre = horaCierre;
            this.numeroTelefono = numeroTelefono;
            this.listaActividades = new List<Actividad>();
        }
    }
}
