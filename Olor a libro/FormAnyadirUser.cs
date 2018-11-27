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
        BindingList<Usuario> listaUsuarios;

        public FormAnyadirUser(BindingList<Usuario> usuarios)
        {
            InitializeComponent();
            listaUsuarios = usuarios;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {

            Usuario user = new Usuario(listaUsuarios, textBoxNombreUser.Text, textBoxCorreo.Text, textBoxContraseña.Text);
            if (checkBoxSuperUser.Checked == true)
            {
                user.superUsuario = true;
            }
            else {
                user.superUsuario = false;
            }

            listaUsuarios.Add(user);
            this.Close();
        }
    }
}
