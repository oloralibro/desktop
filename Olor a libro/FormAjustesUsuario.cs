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

    public partial class FormAjustesUsuario : Form
    {
        public Usuario user;

        public FormAjustesUsuario()
        {
            InitializeComponent();
        }

        private void FormAjustesUsuario_Load(object sender, EventArgs e)
        {
            textBoxNombreUser.Text = user.nombre;
            textBoxContraseña.Text = user.contraseña;
            textBoxCorreo.Text = user.correoElectronico;
            if (user.superUsuario == true)
            {
                checkBoxSuperUser.Checked = true;
            }
            else {
                checkBoxSuperUser.Checked = false;
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            user.nombre = textBoxNombreUser.Text;
            user.contraseña = textBoxContraseña.Text;
            user.correoElectronico = textBoxCorreo.Text;
            if (checkBoxSuperUser.Checked == true)
            {
                user.superUsuario = true;
            }
            else
            {
                user.superUsuario = false;
            }

            this.Close();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            textBoxNombreUser.ReadOnly = false;
            textBoxCorreo.ReadOnly = false;
            textBoxContraseña.ReadOnly = false;
            checkBoxSuperUser.AutoCheck = true;
        }
    }
}
