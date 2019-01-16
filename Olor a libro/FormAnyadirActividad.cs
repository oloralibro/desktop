using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olor_a_libro
{
    public partial class FormAñadirActividad : Form
    {
        BindingList<Actividad> listaActividadesAñadir;
        Actividad actividad; 

        public FormAñadirActividad(BindingList<Actividad> listaActividadesAñadir)
        {
            InitializeComponent();
            this.listaActividadesAñadir = listaActividadesAñadir;
        }

        private void buttonAceptarActividad_Click(object sender, EventArgs e)
        {
            bool actividadRepetida = listaActividadesAñadir.Any(p => p.nombre.Equals(this.textBoxNombreActividad.Text));
            bool isIntString = textBoxPuntos.Text.All(char.IsDigit);

            if (textBoxNombreActividad.Text.Equals("")||textBoxDescripcion.Text.Equals("")||textBoxPuntos.Text.Equals(""))
            {
                MessageBox.Show("Hay campos sin rellenar.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (actividadRepetida==true)
            {
                MessageBox.Show("Este nombre de actividad ya existe en otra acticvidad, introduce uno nuevo.",
                   "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (isIntString == false)
            {
                MessageBox.Show("Introduce los puntos correctamente.",
                   "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                actividad = new Actividad(listaActividadesAñadir, textBoxNombreActividad.Text,
                    textBoxDescripcion.Text, int.Parse(textBoxPuntos.Text));
                listaActividadesAñadir.Add(actividad);
                Json.sobreescribirActividades(listaActividadesAñadir);
                this.Close();
            }
        }
    }
}
