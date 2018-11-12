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
    public partial class FormPlantillaVentana : Form
    {
        public FormPlantillaVentana()
        {
            InitializeComponent();
        }

        private void labelMenuActividades_Click(object sender, EventArgs e)
        {
            FormActividades form_actividades = new FormActividades();
            form_actividades.Show();
            this.Close();
        }

        private void labelMenuLibrerias_Click(object sender, EventArgs e)
        {
            FormLibrerias form_librerias = new FormLibrerias();
            form_librerias.Show();
            this.Close();
        }

        private void labelMenuPerfil_Click(object sender, EventArgs e)
        {
            FormPerfil form_perfil = new FormPerfil();
            form_perfil.Show();
            this.Close();
        }

        private void labelMenuInicio_Click(object sender, EventArgs e)
        {
            FormInicio form_inicio = new FormInicio();
            form_inicio.Show();
            this.Close();
        }

        private void labelMenuLibros_Click(object sender, EventArgs e)
        {
            FormLibros form_libros = new FormLibros();
            form_libros.Show();
            this.Close();
        }

        private void labelMenuHistorial_Click(object sender, EventArgs e)
        {
            FormHistorial form_historial = new FormHistorial();
            form_historial.Show();
            this.Close();
        }

        private void labelMenuAjustes_Click(object sender, EventArgs e)
        {
            FormAjustes form_ajustes = new FormAjustes();
            form_ajustes.ShowDialog();
            this.Close();
        }

        private void labelMenuJugar_Click(object sender, EventArgs e)
        {

        }
    }
}
