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
        public bool superUsuario;
        public string nombre;
        public string correoElectronico;
        public string contraseña;
        public int puntuacionTotal;
        public int nivel;
        public List<Actividad> listaActividades;

        public Usuario(String nombre_usuario, String correo_electronico, String contraseña)
        {
            this.superUsuario = false;
            this.nombre = nombre_usuario;
            this.correoElectronico = correo_electronico;
            this.contraseña = contraseña;
            this.puntuacionTotal = 0;
            this.nivel = 0;
            this.listaActividades = new List<Actividad>();
        }
    }
}
