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
            libreria = new Libreria(listaLibreriasAñadir, textBoxNombreLibreria.Text, textBoxDireccion.Text, textBoxHorario.Text, textBoxTelefono.Text);

            listaLibreriasAñadir.Add(libreria);

            this.Close();    
        }
       
    }
}
