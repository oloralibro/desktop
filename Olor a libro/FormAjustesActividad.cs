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

        BindingList<Actividad> listaActividades;
        Actividad actividad;
        string nombre, descripcion, puntos;
        bool actividadRepetida, isIntString;

        public FormAjustesActividad(BindingList<Actividad> listaActividade, Actividad actividad)
        {
            InitializeComponent();
            this.listaActividades = listaActividade;
            this.actividad = actividad;
        }

        private void FormAjustesActividad_Load(object sender, EventArgs e)
        {
            //Omplim les dades del form amb l'objecte
            textBoxNombreActividad.Text = actividad.nombre;
            textBoxDescripcion.Text = actividad.descripcion;
            textBoxPuntos.Text = actividad.puntos.ToString();
            //Quan comença el projecte guardem les entrades existents en strigs 
            //per si a cas necesitem recuperar els valors abans de patir modificacions 
            nombre = actividad.nombre;
            descripcion = actividad.descripcion;
            puntos = actividad.puntos.ToString();
        }

        private void buttonAceptarModificar_Click(object sender, EventArgs e)
        {
            //Comprovamos que esta libreria no este ya en la lista de librerias 
            actividadRepetida = listaActividades.Any(p => p.nombre.Equals(this.textBoxNombreActividad.Text) && p.id != actividad.id);
            isIntString = textBoxPuntos.Text.All(char.IsDigit);

            if (actividadRepetida == true)
            {
                MessageBox.Show("Esta actividad ya existe, introduce una nueva.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNombreActividad.Text = nombre;
                textBoxNombreActividad.Focus();
            }
            else if (isIntString == false)
            {
                MessageBox.Show("Introduce los puntos correctamente.",
                   "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                actividad.nombre = this.textBoxNombreActividad.Text;
                actividad.descripcion = this.textBoxDescripcion.Text;
                actividad.puntos = int.Parse(this.textBoxPuntos.Text);
                this.Close();
            }
        }

        private void buttonCancelarLibreria_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
