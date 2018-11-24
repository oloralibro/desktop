using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olor_a_libro
{
    public class Json
    {

        public void sobreescribirUsuarios(BindingList<Usuario> listaUsuarios)
        {
            JArray jArrayUsuarios = (JArray)JToken.FromObject(listaUsuarios);
            StreamWriter fichero = File.CreateText(@"../../Ficheros\UsuariosRegistrados.json");
            JsonTextWriter writer = new JsonTextWriter(fichero);

            jArrayUsuarios.WriteTo(writer);
            writer.Close();
        }

        public void sobreescribirLibrerias(BindingList<Libreria> listaLibrerias)
        {
            JArray jArrayLibrerias = (JArray)JToken.FromObject(listaLibrerias);
            StreamWriter fichero = File.CreateText(@"../../Ficheros\LibreriasRegistradas.json");
            JsonTextWriter writer = new JsonTextWriter(fichero);

            jArrayLibrerias.WriteTo(writer);
            writer.Close();
        }

        public void sobreescribirActividades(BindingList<Actividad> listaActividades)
        {
            JArray jArrayActividades = (JArray)JToken.FromObject(listaActividades);
            StreamWriter fichero = File.CreateText(@"../../Ficheros\ActividadesRegistradas.json");
            JsonTextWriter writer = new JsonTextWriter(fichero);

            jArrayActividades.WriteTo(writer);
            writer.Close();
        }
    }
}
