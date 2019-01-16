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

        //Quan s'obre un form se li passa l'usuari que ha entrat al programa per si intenta fer alguna opcio restringida a root saber si te permis o no 

        private void labelMenuActividades_Click(object sender, EventArgs e)
        {
            FormActividades formActividades = new FormActividades(this.user);
            formActividades.Show();
            this.Close();
        }

        private void labelMenuLibrerias_Click(object sender, EventArgs e)
        {
            FormLibrerias formLibrerias = new FormLibrerias(this.user);
            formLibrerias.Show();
            this.Close();
        }

        private void labelMenuPerfil_Click(object sender, EventArgs e)
        {
            FormPerfil formPerfil = new FormPerfil(this.user);
            formPerfil.Show();
            this.Close();
        }

        private void labelMenuInicio_Click(object sender, EventArgs e)
        {
            FormInicio formInicio = new FormInicio(this.user);
            formInicio.Show();
            this.Close();
        }

        private void labelMenuLibros_Click(object sender, EventArgs e)
        {
            FormLibros formLibros = new FormLibros(this.user);
            formLibros.Show();
            this.Close();
        }

        private void labelMenuHistorial_Click(object sender, EventArgs e)
        {
            FormHistorial formHistorial = new FormHistorial(this.user);
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
            FormJugar formJugar = new FormJugar(this.user);
            formJugar.Show();
            this.Close();
        }

        private void pictureMenuIconoSuperUser_Click(object sender, EventArgs e)
        {
            if (user.superUsuario == true)
            {
                FormSuperUser formSuper = new FormSuperUser(this.user);
                formSuper.Show();
                this.Close();
            }
        }

        private void FormPlantillaVentana_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            if (fc.Count <= 2)
            {
                System.Windows.Forms.Application.Exit();
                System.Environment.Exit(1);
            }
        }
    }
}