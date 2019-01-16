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
    public partial class FormAnyadirLibreria : Form
    {
        BindingList<Libreria> listaLibreriasAñadir;
        Libreria libreria;

        public FormAnyadirLibreria(BindingList<Libreria> listaLibreriasAñadir)
        {
            InitializeComponent();
            this.listaLibreriasAñadir = listaLibreriasAñadir;
        }

        private void buttonAceptarLibreria_Click(object sender, EventArgs e)
        {
            bool libreriaRepetida = listaLibreriasAñadir.Any(p => p.nombre.Equals(textBoxNombreLibreria.Text));
            bool direccionRepetida = listaLibreriasAñadir.Any(p => p.direccion.Equals(textBoxDireccion.Text));
            if (libreriaRepetida == true)
            {
                MessageBox.Show("Este nombre de libreria ya existe en otra libreria, introduce uno nuevo.",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (direccionRepetida == true)
            {
                MessageBox.Show("Esta dirección de libreria ya existe en otra libreria, introduce una nueva.",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxNombreLibreria.Text.Equals(""))
            {
                MessageBox.Show("Es obligatorio rellanar el campo Nombre.",
                    "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNombreLibreria.Focus();
            }
            else if (textBoxDireccion.Text.Equals(""))
            {
                MessageBox.Show("Es obligatorio rellanar el campo Dirección.",
                    "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxDireccion.Focus();
            }
            else if (textBoxTelefono.Text.Equals(""))
            {
                MessageBox.Show("Es obligatorio rellanar el campo Telefono.",
                    "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxTelefono.Focus();
            }
            else if (textBoxHorario.Text.Equals(""))
            {
                MessageBox.Show("Es obligatorio rellanar el campo Horario.",
                    "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxTelefono.Focus();
            }
            else
            {
                libreria = new Libreria(listaLibreriasAñadir, textBoxNombreLibreria.Text, textBoxDireccion.Text, textBoxHorario.Text, textBoxTelefono.Text);

                listaLibreriasAñadir.Add(libreria);

                this.Close();
            }
               
        }
       
    }
}
