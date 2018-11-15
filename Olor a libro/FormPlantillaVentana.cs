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
            FormActividades formActividades = new FormActividades();
            formActividades.user = this.user;
            formActividades.Show();
            this.Close();
        }

        private void labelMenuLibrerias_Click(object sender, EventArgs e)
        {
            FormLibrerias formLibrerias = new FormLibrerias();
            formLibrerias.user = this.user;
            formLibrerias.Show();
            this.Close();
        }

        private void labelMenuPerfil_Click(object sender, EventArgs e)
        {
            FormPerfil formPerfil = new FormPerfil();
            formPerfil.user = this.user;
            formPerfil.Show();
            this.Close();
        }

        private void labelMenuInicio_Click(object sender, EventArgs e)
        {
            FormInicio formInicio = new FormInicio();
            formInicio.user = this.user;
            formInicio.Show();
            this.Close();
        }

        private void labelMenuLibros_Click(object sender, EventArgs e)
        {
            FormLibros formLibros = new FormLibros();
            formLibros.user = this.user;
            formLibros.Show();
            this.Close();
        }

        private void labelMenuHistorial_Click(object sender, EventArgs e)
        {
            FormHistorial formHistorial = new FormHistorial();
            formHistorial.user = this.user;
            formHistorial.Show();
            this.Close();
        }

        private void labelMenuAjustes_Click(object sender, EventArgs e)
        {
            FormAjustes formAjustes = new FormAjustes();
            formAjustes.ShowDialog();
        }

        private void labelMenuJugar_Click(object sender, EventArgs e)
        {
            FormJugar formJugar = new FormJugar();
            formJugar.user = this.user;
            formJugar.Show();
            this.Close();
        }

        private void pictureMenuIconoSuperUser_Click(object sender, EventArgs e)
        {
            if (user.superUsuario == true)
            {
                FormSuperUser formSuper = new FormSuperUser();
                formSuper.user = this.user;
                formSuper.Show();
                this.Close();
            }
        }
    }
}