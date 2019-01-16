using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olor_a_libro
{
    public class Actividad
    {
        public const string ACTIVIDADES_PATH = @"../../Ficheros\ActividadesRegistradas.json";

        public int id { get; set; }
        public String nombre { get; set; }
        public String descripcion { get; set; }
        public String direccion { get; set; }
        public int puntos { get; set; }

        public Actividad() { }

        public Actividad(BindingList<Actividad> lista, String nombre, String descripcion, int puntos)
        {
            this.id = Utilidades.generarId(new BindingList<object>(lista.Cast<object>().ToList()));
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.direccion = "";
            this.puntos = puntos;
        }
    }
}
