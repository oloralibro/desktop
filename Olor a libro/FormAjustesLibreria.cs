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
        BindingList<Libreria> listaLibreriasAjustes;
        public Libreria libreria;
        bool libreriaRepetida;

        public FormAjustesLibreria(BindingList<Libreria> listaLibreriasAjustes)
        {
            InitializeComponent();
            this.listaLibreriasAjustes = listaLibreriasAjustes;
        }

        private void FormAñadirLibreria_Load(object sender, EventArgs e)
        {
            textBoxNombreLibreria.Text = libreria.nombre;
            textBoxTelefono.Text = libreria.numeroTelefono;
            textBoxDireccion.Text = libreria.direccion;
            textBoxHorario.Text = libreria.horario;

            listBoxActividades.DataSource = null;
            listBoxActividades.DataSource = libreria.listaActividades;
            listBoxActividades.DisplayMember = "nombre";

        }

        private void buttonAnyadirActividad_Click(object sender, EventArgs e)
        {
            FormAñadirActividadALibreria f = new FormAñadirActividadALibreria(libreria.listaActividades);
            f.ShowDialog();
            listBoxActividades.DataSource = null;
            listBoxActividades.DataSource = libreria.listaActividades;
            listBoxActividades.DisplayMember = "nombre";
        }

        private void buttonAceptarLibreria_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonModificarLibreria_Click(object sender, EventArgs e)
        {
            //Comprovamos que esta libreria no este ya en la lista de librerias 
            libreriaRepetida = listaLibreriasAjustes.Any(p => p.nombre.Equals(this.textBoxNombreLibreria.Text) && p.id != libreria.id);
            if (libreriaRepetida == true)
            {
                MessageBox.Show("El nombre de esta libreria ya existe, introduce uno nuevo.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.textBoxDireccion.Text.Equals("") || this.textBoxHorario.Text.Equals("") ||
                this.textBoxTelefono.Text.Equals(""))
            {
                MessageBox.Show("Introduce todos los datos.", "ATENCIÓN",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Editamos la libreria con la info insertada
                libreria.nombre = textBoxNombreLibreria.Text;
                libreria.direccion = textBoxDireccion.Text;
                libreria.numeroTelefono = textBoxTelefono.Text;
                libreria.horario = textBoxHorario.Text;
                
                this.Close();
            }
        }
    }
}
