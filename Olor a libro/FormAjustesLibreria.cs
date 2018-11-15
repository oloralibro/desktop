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
    public partial class FormAjustesLibreria : Form
    {
        List<Libreria> listaLibrerias;
        Libreria libreria;
        JArray jArrayLibrerias;
        bool libreriaRepetida;

        public FormAjustesLibreria()
        {
            InitializeComponent();
        }

        private void FormAñadirLibreria_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"../../Ficheros\LibreriasRegistradas.json"))
            {
                //si existe el fichero LibreriasRegistradas lo cargamos en una lista
                jArrayLibrerias = JArray.Parse(File.ReadAllText(@"../../Ficheros\LibreriasRegistradas.json"));
                listaLibrerias = jArrayLibrerias.ToObject<List<Libreria>>();
            }
            else
            {
                //si no, creamos una lista vacia
                listaLibrerias = new List<Libreria>();
            }
        }

        private void buttonAceptarLibreria_Click(object sender, EventArgs e)
        {
            //Comprovamos que esta libreria no este ya en la lista de librerias 
            libreriaRepetida = listaLibrerias.Any(p => p.nombre.Equals(this.textBoxNombreLibreria.Text));
            if (libreriaRepetida == true)
            {
                MessageBox.Show("Esta libreria ya existe, introduce una nueva.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.textBoxDireccion.Text.Equals("") || this.textBoxHoraApertura.Text.Equals("") ||
                this.textBoxHoraCierre.Text.Equals("")||this.textBoxNombreLibreria.Text.Equals("")||
                this.textBoxTelefono.Text.Equals(""))
            {
                MessageBox.Show("Introduce todos los datos.", "ATENCIÓN",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Creamos la libreria con la info insertada
                libreria = new Libreria(this.textBoxNombreLibreria.Text, this.textBoxDireccion.Text,
                    this.textBoxHoraApertura.Text, this.textBoxHoraCierre.Text, this.textBoxTelefono.Text);
                //Añadimos la libreria a la lista de librerias y al json de LibreriasRegistradas
                listaLibrerias.Add(libreria);
                SobreescribirJson(jArrayLibrerias);
                this.Close();
            }
        }

        private void buttonCancelarLibreria_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SobreescribirJson(JArray o)
        {
            o = (JArray)JToken.FromObject(listaLibrerias);
            StreamWriter fichero = File.CreateText(@"../../Ficheros\LibreriasRegistradas.json");
            JsonTextWriter writer = new JsonTextWriter(fichero);
            o.WriteTo(writer);
            writer.Close();
        }
    }
}
