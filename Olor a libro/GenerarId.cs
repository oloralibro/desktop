using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olor_a_libro
{
    public static class GenerarId
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
    }
}
