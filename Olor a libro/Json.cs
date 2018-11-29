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
    public static class Json
    {
        #region sobreEscribir
//------no funciona en forms heredados no se pk------------------------------------------
        public static void sobreescribirJson(BindingList<Object> lista, String path)
        {
            JArray jArray = (JArray)JToken.FromObject(lista);
            StreamWriter fichero = File.CreateText(path);
            JsonTextWriter writer = new JsonTextWriter(fichero);

            jArray.WriteTo(writer);
            writer.Close();
        }
//----------------------------------------------------------------------------------------

        public static void sobreescribirUsuarios(BindingList<Usuario> listaUsuarios)
        {
            JArray jArrayUsuarios = (JArray)JToken.FromObject(listaUsuarios);
            StreamWriter fichero = File.CreateText(@"../../Ficheros\UsuariosRegistrados.json");
            JsonTextWriter writer = new JsonTextWriter(fichero);

            jArrayUsuarios.WriteTo(writer);
            writer.Close();
        }

        public static void sobreescribirLibrerias(BindingList<Libreria> listaLibrerias)
        {
            JArray jArrayLibrerias = (JArray)JToken.FromObject(listaLibrerias);
            StreamWriter fichero = File.CreateText(@"../../Ficheros\LibreriasRegistradas.json");
            JsonTextWriter writer = new JsonTextWriter(fichero);

            jArrayLibrerias.WriteTo(writer);
            writer.Close();
        }

        public static void sobreescribirActividades(BindingList<Actividad> listaActividades)
        {
            JArray jArrayActividades = (JArray)JToken.FromObject(listaActividades);
            StreamWriter fichero = File.CreateText(@"../../Ficheros\ActividadesRegistradas.json");
            JsonTextWriter writer = new JsonTextWriter(fichero);

            jArrayActividades.WriteTo(writer);
            writer.Close();
        }
        #endregion
    }
}
