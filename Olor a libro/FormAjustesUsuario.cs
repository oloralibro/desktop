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
        public BindingList<Usuario> listaUsuariosAjustes;
        public Usuario user;
        //estas variables solo sirven en el caso que se descarten los cambios, para devolverles el valor inicial
        string nombre, contraseña, correo, puntos;
        bool superUser;
        int usuarioRepetido;

        public FormAjustesUsuario()
        {
            InitializeComponent();
        }

        private void FormAjustesUsuario_Load(object sender, EventArgs e)
        {
            textBoxNombreUser.Text = user.nombre;
            nombre = textBoxNombreUser.Text;
            textBoxContraseña.Text = user.contraseña;
            contraseña = textBoxContraseña.Text;
            textBoxCorreo.Text = user.correoElectronico;
            correo = textBoxCorreo.Text;
            textBoxPuntosTotales.Text = user.puntuacionTotal.ToString();
            puntos = textBoxPuntosTotales.Text;
            if (user.superUsuario == true)
            {
                checkBoxSuperUser.Checked = true;
                superUser = true;
            }
            else {
                checkBoxSuperUser.Checked = false;
                superUser = false;
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que quieres guardar los cambios?", "GUARDAR CAMBIOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result== DialogResult.Yes)
            {
                usuarioRepetido = listaUsuariosAjustes.Count(p => p.nombre.Equals(this.textBoxNombreUser.Text));
                if (usuarioRepetido > 1)
                {
                    MessageBox.Show("Este nombre de usuario ya existe en otro usuario, introduce uno nuevo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (usuarioRepetido == 1)
                {

                }
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
                MessageBox.Show("Cambios guardados correctamente.","CAMBIOS GUARDADOS",MessageBoxButtons.OK,MessageBoxIcon.None);
            }
            else
            {
                textBoxNombreUser.Text = nombre;
                textBoxContraseña.Text = contraseña;
                textBoxCorreo.Text = correo;
                textBoxPuntosTotales.Text = puntos;
                checkBoxSuperUser.Checked = superUser;
                MessageBox.Show("Cambios descartados correctamente.", "CAMBIOS DESCARTADOS", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
