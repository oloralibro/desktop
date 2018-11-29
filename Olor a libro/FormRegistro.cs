﻿using Newtonsoft.Json;
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
    public partial class FormRegistro : Form
    {
        BindingList<Usuario> listaUsuarios;
        JArray jArrayUsuarios;
        Usuario usuario;
        bool superUser;

        public FormRegistro()
        {
            InitializeComponent();
        }

        private void FormRegistro_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"../../Ficheros\UsuariosRegistrados.json"))
            {
                //si existe el fichero UsuariosRegistrados lo cargamos en una lista
                jArrayUsuarios = JArray.Parse(File.ReadAllText(@"../../Ficheros\UsuariosRegistrados.json"));
                listaUsuarios = jArrayUsuarios.ToObject<BindingList<Usuario>>();
            }
            else
            {
                //si no, creamos una lista vacia
                listaUsuarios = new BindingList<Usuario>();
            }
        }

        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
           
            //Comprovamos que este usuario y el correo no esten ya en la lista de usuarios 
            if(Utilidades.usuarioRepetido(listaUsuarios, textBoxUsuario.Text, textBoxEmail.Text)==false)
            {
                if (!this.textBoxEmail.Text.Equals(this.textBoxCormirmarEmail.Text))
                {
                    //Comprovamos con confirmar correo que haya introducido bien el correo 
                    MessageBox.Show("El correo electronico no coincide, introducelo de nuevo.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!this.textBoxContraseña.Text.Equals(this.textBoxConfirmarContraseña.Text))
                {
                    //Comprovamos con confirmar contraseña que este bien introducida 
                    MessageBox.Show("La contraseña no coincide, introducela de nuevo.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //Creamos el usuario con la info insertada
                    usuario = new Usuario(listaUsuarios, this.textBoxUsuario.Text, this.textBoxEmail.Text, this.textBoxContraseña.Text);
                    if (superUser == true)
                    {
                        usuario.superUsuario = true;
                    }
                    //Añadimos el usuario a la lista de usuarios y al json de usuarios registrados
                    listaUsuarios.Add(usuario);
                    Json.sobreescribirJson(new BindingList<object>(listaUsuarios.Cast<object>().ToList()),
                        "../../Ficheros\\UsuariosRegistrados.json");
                    this.Close();
                }

            }

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSuperUser_Click(object sender, EventArgs e)
        {
            FormRegistroSuper f = new FormRegistroSuper();
            f.ShowDialog();
            superUser = f.superUser;
        }
    }
}
