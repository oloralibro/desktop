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
    public partial class FormAnyadirActividad : Form
    {
        Libreria libreria = new Libreria();

        public FormAnyadirActividad(Libreria l)
        {
            InitializeComponent();
            libreria = l;
        }

        private void buttonAceptarActividad_Click(object sender, EventArgs e)
        {
            Actividad act = new Actividad(textBoxNombreActividad.Text, textBoxDescripcion.Text, int.Parse(textBoxPuntos.Text));
            libreria.listaActividades.Add(act);
        }
    }
}
