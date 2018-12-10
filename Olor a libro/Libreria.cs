using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olor_a_libro
{
    public class Libreria
    {
        public int id { get; set; }
        public String nombre { get; set; }
        public String direccion { get; set; }
        public String horario { get; set; }
        public String numeroTelefono { get; set; }
        public List<Actividad> listaActividades { get; set; }

        public Libreria() { }

        public Libreria(BindingList<Libreria> lista, String nombre, String direccion, String horario, String numeroTelefono)
        {
            this.id = Utilidades.generarId(new BindingList<object>(lista.Cast<object>().ToList()));
            this.nombre = nombre;
            this.direccion = direccion;
            this.horario = horario;
            this.numeroTelefono = numeroTelefono;
            this.listaActividades = new List<Actividad>();
        }
    }
}
