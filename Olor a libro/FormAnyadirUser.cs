﻿using System;
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
        BindingList<Usuario> listaUsuariosAñadir;
        Usuario user;

        public FormAnyadirUser(BindingList<Usuario> listaUsuariosAñadir)
        {
            InitializeComponent();
            this.listaUsuariosAñadir = listaUsuariosAñadir;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (Utilidades.usuarioRepetido(listaUsuariosAñadir, textBoxNombreUser.Text, textBoxCorreo.Text) == false)
            {
                if (textBoxNombreUser.Text.Equals(""))
                {
                    MessageBox.Show("Es obligatorio rellanar el campo Nombre.",
                        "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxNombreUser.Focus();
                }
                else if (textBoxCorreo.Text.Equals(""))
                {
                    MessageBox.Show("Es obligatorio rellanar el campo Correo.",
                        "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxCorreo.Focus();
                }
                else if (textBoxContraseña.Text.Equals(""))
                {
                    MessageBox.Show("Es obligatorio rellanar el campo Contraseña.",
                        "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxContraseña.Focus();
                }
                else
                {

                    user = new Usuario(listaUsuariosAñadir, textBoxNombreUser.Text,
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
