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
        public BindingList<Libreria> listaLibreriasAjustes;
        public Libreria libreria;
        string nombre, direccion,telefono, horario;
        bool libreriaRepetida;

        public FormAjustesLibreria()
        {
            InitializeComponent();
        }

        private void FormAñadirLibreria_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonAceptarLibreria_Click(object sender, EventArgs e)
        {
            //Comprovamos que esta libreria no este ya en la lista de librerias 
            libreriaRepetida = listaLibreriasAjustes.Any(p => p.nombre.Equals(this.textBoxNombreLibreria.Text));
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
                //Añadimos la libreria a la lista de librerias y al json de LibreriasRegistradas
                libreria.nombre = textBoxNombreLibreria.Text;
                libreria.numeroTelefono = textBoxTelefono.Text;
                libreria.horario = textBoxHorario.Text;
                
                this.Close();
            }
        }

        private void buttonCancelarLibreria_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
