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
    public partial class FormLogin : Form
    {

        JArray jArrayUsuarios;
        BindingList<Usuario> listaUsuarios;
        bool existeUsuario;
        Usuario usuarioCopia;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"../../Ficheros\UsuariosRegistrados.json"))
            {
                //Si existeixen usuaris creats carreguem aquests usuaris a una nova llista i busquem si hi ha algun amb usuari i contrasenya iguals als introduits 

                jArrayUsuarios = JArray.Parse(File.ReadAllText(@"../../Ficheros\UsuariosRegistrados.json"));
                listaUsuarios = jArrayUsuarios.ToObject<BindingList<Usuario>>();

                existeUsuario = listaUsuarios.Any(p => p.nombre.Equals(this.textBoxNombreUsuario.Text) && p.contraseña.Equals(this.textBoxContraseña.Text));
                if (this.textBoxNombreUsuario.Text.Equals("") && this.textBoxContraseña.Text.Equals(""))
                {
                    MessageBox.Show("Introduce tu contraseña y usuario.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (this.textBoxNombreUsuario.Text.Equals(""))
                {
                    MessageBox.Show("Introduce tu usuario.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (this.textBoxContraseña.Text.Equals(""))
                {
                    MessageBox.Show("Introduce tu contraseña.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (existeUsuario == true)
                {
                    usuarioCopia = listaUsuarios.FirstOrDefault(a => a.nombre.Equals(this.textBoxNombreUsuario.Text));
                    //en la linia anterior busquem dins de la llista l'usuari que vol entrar i copiem aquest usuari
                    //per tal de passar-lo al form inicio
                    FormInicio f = new FormInicio();
                    f.Show();
                    f.user = usuarioCopia;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("No hay ningun usuario registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonCrearCuenta_Click(object sender, EventArgs e)
        {
            FormRegistro f = new FormRegistro();
            f.ShowDialog();
        }
    }
}
