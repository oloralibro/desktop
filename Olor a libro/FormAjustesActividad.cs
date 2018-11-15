using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olor_a_libro
{
    public partial class FormAjustesActividad : Form
    {

        List<Actividad> listaActividades;
        Actividad actividad;
        JArray jArrayActividades;
        bool actividadRepetida;

        public FormAjustesActividad()
        {
            InitializeComponent();
        }

        private void FormAjustesActividad_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"../../Ficheros\ActividadesRegistradas.json"))
            {
                //si existe el fichero LibreriasRegistradas lo cargamos en una lista
                jArrayActividades = JArray.Parse(File.ReadAllText(@"../../Ficheros\ActividadesRegistradas.json"));
                listaActividades = jArrayActividades.ToObject<List<Actividad>>();
            }
            else
            {
                //si no, creamos una lista vacia
                listaActividades = new List<Actividad>();
            }
        }

        private void buttonAceptarLibreria_Click(object sender, EventArgs e)
        {
            //Comprovamos que esta libreria no este ya en la lista de librerias 
            actividadRepetida = listaActividades.Any(p => p.nombre.Equals(this.textBoxNombreActividad.Text));
            if (actividadRepetida == true)
            {
                MessageBox.Show("Esta actividad ya existe, introduce una nueva.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.textBoxDescripcion.Text.Equals("") || this.textBoxNombreActividad.Text.Equals("") ||
                this.textBoxPuntos.Text.Equals(""))
            {
                MessageBox.Show("Introduce todos los datos.", "ATENCIÓN",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Creamos la libreria con la info insertada
                actividad = new Actividad(this.textBoxNombreActividad.Text, this.textBoxDescripcion.Text, int.Parse(this.textBoxPuntos.Text));
                //Añadimos la libreria a la lista de librerias y al json de LibreriasRegistradas
                listaActividades.Add(actividad);
                SobreescribirJson(jArrayActividades);
                this.Close();
            }
        }

        private void buttonCancelarLibreria_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SobreescribirJson(JArray o)
        {
            o = (JArray)JToken.FromObject(listaActividades);
            StreamWriter fichero = File.CreateText(@"../../Ficheros\ActividadesRegistradas.json");
            JsonTextWriter writer = new JsonTextWriter(fichero);
            o.WriteTo(writer);
            writer.Close();
        }
    }
}
