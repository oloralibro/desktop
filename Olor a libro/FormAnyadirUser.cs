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
    public partial class FormAnyadirUser : Form
    {
        public BindingList<Usuario> listaUsuariosAñadir;

        public FormAnyadirUser()
        {
            InitializeComponent();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (Utilidades.usuarioRepetido(listaUsuariosAñadir, textBoxNombreUser.Text, textBoxCorreo.Text) == false)
            {
                if (textBoxNombreUser.Text.Equals(""))
                {
                    MessageBox.Show("Es obligatorio rellanar el campo Nombre.",
                        "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (textBoxCorreo.Text.Equals(""))
                {
                    MessageBox.Show("Es obligatorio rellanar el campo Correo.",
                        "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (textBoxContraseña.Text.Equals(""))
                {
                    MessageBox.Show("Es obligatorio rellanar el campo Contraseña.",
                        "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    Usuario user = new Usuario(listaUsuariosAñadir, textBoxNombreUser.Text,
                        textBoxCorreo.Text, textBoxContraseña.Text);
                    if (checkBoxSuperUser.Checked == true)
                    {
                        user.superUsuario = true;
                    }
                    listaUsuariosAñadir.Add(user);
                    this.Close();

                }
            }
        }
    }
}
