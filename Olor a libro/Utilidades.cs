using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olor_a_libro
{
    public static class Utilidades
    {
        
        public static int generarId(BindingList<object> lista)
        {
            int id=0;
            int longitud = lista.Count();

            if (longitud == 0)
            {
                id = 1;
            }
            else
            {
                id = (int)lista.First().GetType().GetProperty("id").GetValue(lista[longitud-1]);
                id += 1; 
            }
            return id; 
        }

        public static bool usuarioRepetido(BindingList<Usuario> listaUsuarios, String checkNombre, String checkCorreo)
        {
            bool result;
            bool usuarioRepetido = listaUsuarios.Any(p => p.nombre.Equals(checkNombre));
            bool correoRepetido = listaUsuarios.Any(p => p.correoElectronico.Equals(checkCorreo));

            if (usuarioRepetido == true)
            {
                MessageBox.Show("Este nombre de usuario ya existe en otro usuario, introduce uno nuevo.", 
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = true;
            }
            else if (correoRepetido == true)
            {
                MessageBox.Show("Este correo pertenece a otro usuario, introduce uno nuevo.", 
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
