using Newtonsoft.Json;
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
        List<Usuario> lista_usuarios;
        JArray jArrayUsuarios;
        Usuario usuario;
        bool usuario_repetido,super_user;

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
                lista_usuarios = jArrayUsuarios.ToObject<List<Usuario>>();
            }
            else
            {
                //si no, creamos una lista vacia
                lista_usuarios = new List<Usuario>();
            }
        }

        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
            //Creamos el usuario con la info insertada
            usuario = new Usuario(this.textBoxUsuario.Text, this.textBoxEmail.Text, this.textBoxContraseña.Text);
            if (super_user==true)
            {
                usuario.super_usuario = true;
            }
            //Comprovamos que este usuario no este ya en la lista de usuarios 
            usuario_repetido = lista_usuarios.Any(p => p.nombre_usuario.Equals(usuario.nombre_usuario));
            if (usuario_repetido == true)
            {
                MessageBox.Show("Este nombre de usuario ya existe, introduce uno nuevo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!usuario.correo_electronico.Equals(this.textBoxCormirmarEmail.Text))
                {
                    //Comprovamos con confirmar correo que haya introducido bien el correo 
                    MessageBox.Show("El correo electronico no coincide, introducelo de nuevo.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!usuario.contraseña.Equals(this.textBoxConfirmarContraseña.Text))
                {
                    //Comprovamos con confirmar contraseña que este bien introducida 
                    MessageBox.Show("La contraseña no coincide, introducela de nuevo.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //Añadimos el usuario a la lista de usuarios y al json de usuarios registrados
                    lista_usuarios.Add(usuario);
                    sobreescribir_json(jArrayUsuarios);
                    this.Close();
                }
                
            }
            
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void sobreescribir_json(JArray o)
        {
            o = (JArray)JToken.FromObject(lista_usuarios);
            StreamWriter fichero = File.CreateText(@"../../Ficheros\UsuariosRegistrados.json");
            JsonTextWriter writer = new JsonTextWriter(fichero);
            o.WriteTo(writer);
            writer.Close();
        }

        private void buttonSuperUser_Click(object sender, EventArgs e)
        {
            FormRegistroSuper f = new FormRegistroSuper();
            f.ShowDialog();
            super_user=f.super_user;
        }
    }
}
