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
        string nombre, contraseña, correo, puntos;
        bool superUser, usuarioRepetido, correoRepetido;

       

        public FormAjustesUsuario()
        {
            InitializeComponent();
        }

        private void FormAjustesUsuario_Load(object sender, EventArgs e)
        {
            //Omplim les entrades del new form amb les dades del usuari que podem modificar
            textBoxNombreUser.Text = user.nombre;
            textBoxContraseña.Text = user.contraseña;
            textBoxCorreo.Text = user.correoElectronico;
            textBoxPuntosTotales.Text = user.puntuacionTotal.ToString();
            if (user.superUsuario == true)
            {
                checkBoxSuperUser.Checked = true;
                superUser = true;
            }
            else {
                checkBoxSuperUser.Checked = false;
                superUser = false;
            }
            //Quan comença el projecte guardem les entrades existents en strigs per si a cas necesitem recuperar els valors abans de patir modificacions 
            contraseña = textBoxContraseña.Text;
            correo = textBoxCorreo.Text;
            puntos = textBoxPuntosTotales.Text;
            nombre = textBoxNombreUser.Text;
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que quieres guardar los cambios?", "GUARDAR CAMBIOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Si s'esta segur de que guardarem els canvis comprovem que el nom i correus no estiguin ja a la base de dades de usuaris 
                //ja que tan el nom com el correu nomes poden ser d'una persona
                usuarioRepetido = listaUsuariosAjustes.Any(p => p.nombre.Equals(this.textBoxNombreUser.Text) && p.id != user.id);
                correoRepetido = listaUsuariosAjustes.Any(p => p.correoElectronico.Equals(this.textBoxCorreo.Text) && p.id != user.id);
                if (usuarioRepetido == true)
                {
                    MessageBox.Show("Este nombre de usuario ya existe en otro usuario, introduce uno nuevo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxNombreUser.Text = nombre;
                }
                else if (correoRepetido == true)
                {
                    MessageBox.Show("Este correo pertenece a otro usuario, introduce uno nuevo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxCorreo.Text = correo;
                }
                else if ((usuarioRepetido==false)&&(correoRepetido==false))
                {
                    user.nombre = textBoxNombreUser.Text;
                    user.contraseña = textBoxContraseña.Text;
                    user.correoElectronico = textBoxCorreo.Text;
                    user.puntuacionTotal = int.Parse(textBoxPuntosTotales.Text);
                    if (checkBoxSuperUser.Checked == true)
                    {
                        user.superUsuario = true;
                    }
                    else
                    {
                        user.superUsuario = false;
                    }
                    MessageBox.Show("Cambios guardados correctamente.", "CAMBIOS GUARDADOS", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Close();
                }
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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
