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
        public String hora_apertura;
        public String hora_cierre;
        public String numero_telefono;
        public List<Actividad> lista_actividades;

        public Libreria(String nombre, String direccion, String hora_apertura, String hora_cierre, String numero_telefono)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.hora_apertura = hora_apertura;
            this.hora_cierre = hora_cierre;
            this.numero_telefono = numero_telefono;
            this.lista_actividades = new List<Actividad>();
        }
    }
}
