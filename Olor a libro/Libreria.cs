using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olor_a_libro
{
    public class Libreria
    {
        public String nombre;
        public String direccion;
        public String horaApertura;
        public String horaCierre;
        public String numeroTelefono;
        public List<Actividad> listaActividades;

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
