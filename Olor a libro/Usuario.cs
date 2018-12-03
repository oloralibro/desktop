using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olor_a_libro
{
    public class Usuario
    {
        public int id { get; set; }
        public bool superUsuario { get; set; }
        public string nombre { get; set; }
        public string correoElectronico { get; set; }
        public string contraseña { get; set; }
        public int puntuacionTotal { get; set; }
        public List<Actividad> listaActividades { get; set; }

        public Usuario() { }

        public Usuario(BindingList<Usuario> lista, String nombre_usuario, String correo_electronico, String contraseña)
        {
            this.id = Utilidades.generarId(new BindingList<object>(lista.Cast<object>().ToList()));
            this.superUsuario = false;
            this.nombre = nombre_usuario;
            this.correoElectronico = correo_electronico;
            this.contraseña = contraseña;
            this.puntuacionTotal = 0;
            this.listaActividades = new List<Actividad>();
        }

    }
}
