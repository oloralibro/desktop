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
        public Usuario user;
        public FormPlantillaVentana()
        {
            InitializeComponent();
        }

        private void labelMenuActividades_Click(object sender, EventArgs e)
        {
            FormActividades form_actividades = new FormActividades();
            form_actividades.user = this.user;
            form_actividades.Show();
            this.Close();
        }

        private void labelMenuLibrerias_Click(object sender, EventArgs e)
        {
            FormLibrerias form_librerias = new FormLibrerias();
            form_librerias.user = this.user;
            form_librerias.Show();
            this.Close();
        }

        private void labelMenuPerfil_Click(object sender, EventArgs e)
        {
            FormPerfil form_perfil = new FormPerfil();
            form_perfil.user = this.user;
            form_perfil.Show();
            this.Close();
        }

        private void labelMenuInicio_Click(object sender, EventArgs e)
        {
            FormInicio form_inicio = new FormInicio();
            form_inicio.user = this.user;
            form_inicio.Show();
            this.Close();
        }

        private void labelMenuLibros_Click(object sender, EventArgs e)
        {
            FormLibros form_libros = new FormLibros();
            form_libros.user = this.user;
            form_libros.Show();
            this.Close();
        }

        private void labelMenuHistorial_Click(object sender, EventArgs e)
        {
            FormHistorial form_historial = new FormHistorial();
            form_historial.user = this.user;
            form_historial.Show();
            this.Close();
        }

        private void labelMenuAjustes_Click(object sender, EventArgs e)
        {
            FormAjustes form_ajustes = new FormAjustes();
            form_ajustes.ShowDialog();
        }

        private void labelMenuJugar_Click(object sender, EventArgs e)
        {
            FormJugar form_jugar = new FormJugar();
            form_jugar.user = this.user;
            form_jugar.Show();
            this.Close();
        }

        private void pictureMenuIconoSuperUser_Click(object sender, EventArgs e)
        {

            try
            {
                if (user.super_usuario == true)
                {
                    FormSuperuser form_super = new FormSuperuser();
                    form_super.user = this.user;
                    form_super.Show();
                    this.Close();
                }
            }
            catch
            {

            }


        }
    }
}