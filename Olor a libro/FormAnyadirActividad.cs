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
        public BindingList<Actividad> listaActividadesAñadir;
        Actividad actividad; 

        public FormAñadirActividad()
        {
            InitializeComponent();
        }

        private void buttonAceptarActividad_Click(object sender, EventArgs e)
        {
            if (textBoxNombreActividad.Text.Equals("")||textBoxDescripcion.Text.Equals("")||textBoxPuntos.Text.Equals(""))
            {
                MessageBox.Show("Hay campos sin rellenar.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
