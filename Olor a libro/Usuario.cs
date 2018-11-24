using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olor_a_libro
{
    public class Usuario
    {
        public bool superUsuario { get; set; }
        public string nombre { get; set; }
        public string correoElectronico { get; set; }
        public string contraseña { get; set; }
        public int puntuacionTotal { get; set; }
        public List<Actividad> listaActividades { get; set; }

        public Usuario(String nombre_usuario, String correo_electronico, String contraseña)
        {
            this.superUsuario = false;
            this.nombre = nombre_usuario;
            this.correoElectronico = correo_electronico;
            this.contraseña = contraseña;
            this.puntuacionTotal = 0;
            this.listaActividades = new List<Actividad>();
        }

    }
}
