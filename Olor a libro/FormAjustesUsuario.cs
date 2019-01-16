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
        BindingList<Usuario> listaUsuariosAjustes;
        Usuario user;
        string nombre, contraseña, correo, puntos;
        bool superUser, usuarioRepetido, correoRepetido;

        public FormAjustesUsuario(BindingList<Usuario> listaUsuariosAjustes, Usuario user)
        {
            InitializeComponent();
            this.listaUsuariosAjustes = listaUsuariosAjustes;
            this.user = user;
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

            //Carrega la listbox amb les activitats que cada usuari ha fet
            listBoxActividades.DataSource = null;
            listBoxActividades.DataSource = user.listaActividades;
            listBoxActividades.DisplayMember = "nombre";
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            bool isIntString = textBoxPuntosTotales.Text.All(char.IsDigit);
            DialogResult result = MessageBox.Show("Seguro que quieres guardar los cambios?", "GUARDAR CAMBIOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
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
                else if (isIntString == false)
                {
                    MessageBox.Show("Introduce los puntos correctamente.",
                   "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Si s'esta segur de que guardarem els canvis comprovem que el nom i correus no estiguin ja a la base de dades de usuaris 
                    //ja que tan el nom com el correu nomes poden ser d'una persona
                    usuarioRepetido = listaUsuariosAjustes.Any(p => p.nombre.Equals(this.textBoxNombreUser.Text) && p.id != user.id);
                    correoRepetido = listaUsuariosAjustes.Any(p => p.correoElectronico.Equals(this.textBoxCorreo.Text) && p.id != user.id);
                    if (usuarioRepetido == true)
                    {
                        MessageBox.Show("Este nombre de usuario ya existe en otro usuario, introduce uno nuevo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxNombreUser.Text = nombre;
                        textBoxNombreUser.Focus();
                    }
                    else if (correoRepetido == true)
                    {
                        MessageBox.Show("Este correo pertenece a otro usuario, introduce uno nuevo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxCorreo.Text = correo;
                        textBoxCorreo.Focus();
                    }
                    else if ((usuarioRepetido == false) && (correoRepetido == false))
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
