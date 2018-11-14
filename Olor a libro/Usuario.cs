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
        public bool super_usuario;
        public string nombre_usuario;
        public string correo_electronico;
        public string contraseña;
        public int puntuacion_total;
        public int nivel;
        public ArrayList lista_actividades;

        public Usuario(String nombre_usuario, String correo_electronico, String contraseña)
        {
            this.super_usuario = false;
            this.nombre_usuario = nombre_usuario;
            this.correo_electronico = correo_electronico;
            this.contraseña = contraseña;
            this.puntuacion_total = 0;
            this.nivel = 0;
            this.lista_actividades = new ArrayList();

        }
    }
}
