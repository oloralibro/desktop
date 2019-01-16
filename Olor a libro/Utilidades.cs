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

        public static float generarLatitud()
        {
            //Valor maxim i minim de la latitud: 41.3261225-41.4387139
            //Diferencia entre la latitud maxima i minima: 0.1125914

            Random rng = new Random();

            float latitud = (float)(rng.NextDouble()*0.1125915+41.3261225);

            return latitud;
        }

        public static float generarLongitud()
        {
            //Valor maxim i minim de la longitud: 2.1155867-2.2263982
            //Diferencia entre la longitud maxima i la minima: 0.1108115

            Random rng = new Random();

            float longitud = (float)(rng.NextDouble()*0.1108115+2.1155867);

            return longitud;
        }
    }
}
