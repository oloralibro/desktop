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

        public BindingList<Actividad> listaActividades;
        public Actividad actividad;
        string nombre, descripcion, puntos;
        bool actividadRepetida;

        public FormAjustesActividad()
        {
            InitializeComponent();
        }

        private void FormAjustesActividad_Load(object sender, EventArgs e)
        {
            textBoxNombreActividad.Text = actividad.nombre;
            textBoxDescripcion.Text = actividad.descripcion;
            textBoxPuntos.Text = actividad.puntos.ToString();
            nombre = actividad.nombre;
            descripcion = actividad.descripcion;
            puntos = actividad.puntos.ToString();
        }

        private void buttonAceptarModificar_Click(object sender, EventArgs e)
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
                //Modificamos la libreria con la info insertada
                //Añadimos la libreria a la lista de librerias y al json de LibreriasRegistradas
                this.Close();
            }
        }

        private void buttonCancelarLibreria_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
