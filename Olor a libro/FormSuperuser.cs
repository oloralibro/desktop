using Newtonsoft.Json.Linq;
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Newtonsoft.Json;

namespace Olor_a_libro
{
    public partial class FormSuperUser : Olor_a_libro.FormPlantillaVentana
    {

        JArray jArrayUsuarios, jArrayLibrerias, jArrayActividades;
        BindingList<Usuario> listaUsuarios;
        BindingList<Actividad> listaActividades;
        BindingList<Libreria> listaLibrerias;
        int indexUsuarios, indexActividades, indexLibrerias;

        public FormSuperUser(Usuario user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void FormSuperUser_Activated(object sender, EventArgs e) {
            Json.sobreescribirUsuarios(listaUsuarios);
            Json.sobreescribirActividades(listaActividades);
            Json.sobreescribirLibrerias(listaLibrerias);
        }

        private void FormSuperUser_Load(object sender, EventArgs e)
        {
            dataGridViewActividades.AutoGenerateColumns = false;
            dataGridViewLibrerias.AutoGenerateColumns = false;
            dataGridViewUsuarios.AutoGenerateColumns = false;

            //Cargamos gridview de usuarios
            cargarUsuarios();

            if (File.Exists(Libreria.LIBRERIAS_PATH))
            {
                //Cargamos la lista de librerias
                cargarLibrerias();
            }
            else
            {
                listaLibrerias = new BindingList<Libreria>();
            }

            if (File.Exists(Actividad.ACTIVIDADES_PATH))
            {
                //Cargamos la lista de actividades
                cargarActividades();
            }
            else
            {
                listaActividades = new BindingList<Actividad>();
            }
        }

        private void FormSuperUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Json.sobreescribirUsuarios(listaUsuarios);
            Json.sobreescribirActividades(listaActividades);
            Json.sobreescribirLibrerias(listaLibrerias);
        }




        #region Usuarios
        private void buttonBuscarUsuario_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewUsuarios.Rows)
            {
                if (row.Cells[1].Value.ToString().Equals(textBoxBuscadorUsuarios.Text))
                {
                    dataGridViewUsuarios.ClearSelection();
                    row.Selected = true;
                    FormAjustesUsuario f = new FormAjustesUsuario(listaUsuarios, (Usuario)dataGridViewUsuarios.SelectedRows[0].DataBoundItem);
                    indexUsuarios = listaUsuarios.IndexOf((Usuario)dataGridViewUsuarios.SelectedRows[0].DataBoundItem);
                    f.ShowDialog();
                    listaUsuarios[indexUsuarios] = (Usuario)dataGridViewUsuarios.SelectedRows[0].DataBoundItem;
                }
            }
        }

        private void reloadDataGridViewUsuarios()
        {
            dataGridViewUsuarios.DataSource = null;
            dataGridViewUsuarios.DataSource = listaUsuarios;
        }

        private void cargarUsuarios()
        {
            //Cargamos gridview de usuarios
            jArrayUsuarios = JArray.Parse(File.ReadAllText(Usuario.USUARIOS_PATH));
            listaUsuarios = jArrayUsuarios.ToObject<BindingList<Usuario>>();
            reloadDataGridViewUsuarios();
        }

        private void buttonAñadirUsuarios_Click(object sender, EventArgs e)
        {
            FormAnyadirUser f = new FormAnyadirUser(listaUsuarios);
            f.ShowDialog();
            Json.sobreescribirUsuarios(listaUsuarios);
        }

        private void buttonModificarUsuarios_Click(object sender, EventArgs e)
        {
            FormAjustesUsuario f = new FormAjustesUsuario(listaUsuarios, (Usuario)dataGridViewUsuarios.CurrentRow.DataBoundItem);
            indexUsuarios = listaUsuarios.IndexOf((Usuario)dataGridViewUsuarios.CurrentRow.DataBoundItem);
            f.ShowDialog();
            listaUsuarios[indexUsuarios] = (Usuario)dataGridViewUsuarios.CurrentRow.DataBoundItem;
            Json.sobreescribirUsuarios(listaUsuarios);
        }

        private void buttonEliminarUsuarios_Click(object sender, EventArgs e)
        {
            //aqui comprovamos que el usuario no se intente borrar a si mismo, si pasase no conllevaria errores 
            //(el usuario seguiria en el programa lo que al salir ya no podria entrar con ese user) pero no es serio)
            Usuario user2 = (Usuario)dataGridViewUsuarios.CurrentRow.DataBoundItem;
            if (this.user.id == user2.id)
            {
                MessageBox.Show("No puedes eliminar el usuario actual", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Seguro que quieres eliminar el usuario?", "ELIMINAR USUARIOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    listaUsuarios.Remove((Usuario)dataGridViewUsuarios.CurrentRow.DataBoundItem);

                    Json.sobreescribirUsuarios(listaUsuarios);

                    reloadDataGridViewUsuarios();
                }
            }
            
        }
        #endregion




        #region Librerias
        private void buttonBuscarLibrerias_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewLibrerias.Rows)
            {
                if (row.Cells[1].Value.ToString().Equals(textBoxBuscadorLibrerias.Text))
                {
                    dataGridViewLibrerias.ClearSelection();
                    row.Selected = true;
                    FormAjustesLibreria f = new FormAjustesLibreria(listaLibrerias, (Libreria)dataGridViewLibrerias.SelectedRows[0].DataBoundItem);
                    indexLibrerias = listaLibrerias.IndexOf((Libreria)dataGridViewLibrerias.SelectedRows[0].DataBoundItem);
                    f.ShowDialog();
                    listaLibrerias[indexLibrerias] = (Libreria)dataGridViewLibrerias.SelectedRows[0].DataBoundItem;
                }
            }
        }

        private void reloadDataGridViewLibrerias()
        {
            dataGridViewLibrerias.DataSource = null;
            dataGridViewLibrerias.DataSource = listaLibrerias;
        }

        private void cargarLibrerias()
        {
            //Cargamos la lista de librerias
            jArrayLibrerias = JArray.Parse(File.ReadAllText(Libreria.LIBRERIAS_PATH));
            listaLibrerias = jArrayLibrerias.ToObject<BindingList<Libreria>>();
            reloadDataGridViewLibrerias();
        }

        private void buttonAnyadirLibrerias_Click(object sender, EventArgs e)
        {
            FormAnyadirLibreria f = new FormAnyadirLibreria(listaLibrerias);
            f.ShowDialog();
            Json.sobreescribirLibrerias(listaLibrerias);
            reloadDataGridViewLibrerias();
        }

        private void buttonModificarLibrerias_Click(object sender, EventArgs e)
        {
            FormAjustesLibreria f = new FormAjustesLibreria(listaLibrerias, (Libreria)dataGridViewLibrerias.CurrentRow.DataBoundItem);
            indexLibrerias = listaLibrerias.IndexOf((Libreria)dataGridViewLibrerias.CurrentRow.DataBoundItem);
            f.ShowDialog();
            listaLibrerias[indexLibrerias] = (Libreria)dataGridViewLibrerias.CurrentRow.DataBoundItem;
            Json.sobreescribirLibrerias(listaLibrerias);
        }

        private void buttonEliminarLibrerias_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que quieres eliminar la libreria?", "ELIMINAR LIBRERIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                listaLibrerias.Remove((Libreria)dataGridViewLibrerias.CurrentRow.DataBoundItem);

                Json.sobreescribirLibrerias(listaLibrerias);

                reloadDataGridViewLibrerias();
            }
        }
        #endregion




        #region Actividades
        private void buttonBuscarActividad_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewActividades.Rows)
            {
                if (row.Cells[1].Value.ToString().Equals(textBoxBuscadorActividades.Text))
                {
                    dataGridViewActividades.ClearSelection();
                    row.Selected = true;
                    FormAjustesActividad f = new FormAjustesActividad(listaActividades, (Actividad)dataGridViewActividades.SelectedRows[0].DataBoundItem);
                    indexActividades = listaActividades.IndexOf((Actividad)dataGridViewActividades.SelectedRows[0].DataBoundItem);
                    f.ShowDialog();
                    listaActividades[indexActividades] = (Actividad)dataGridViewActividades.SelectedRows[0].DataBoundItem;
                }
            }
        }

        private void reloadDataGridViewActividades()
        {
            dataGridViewActividades.DataSource = null;
            dataGridViewActividades.DataSource = listaActividades;
        }

        private void cargarActividades()
        {   //Cargamos la lista de actividades
            jArrayActividades = JArray.Parse(File.ReadAllText(Actividad.ACTIVIDADES_PATH));
            listaActividades = jArrayActividades.ToObject<BindingList<Actividad>>();
            reloadDataGridViewActividades();
        }

        private void buttonAñadirActividad_Click(object sender, EventArgs e)
        {
            FormAñadirActividad f = new FormAñadirActividad(listaActividades);
            f.ShowDialog();
            Json.sobreescribirActividades(listaActividades);
            reloadDataGridViewActividades();
        }

        private void buttonModificarActividad_Click(object sender, EventArgs e)
        {
            FormAjustesActividad f = new FormAjustesActividad(listaActividades, (Actividad)dataGridViewActividades.CurrentRow.DataBoundItem);
            indexActividades = listaActividades.IndexOf((Actividad)dataGridViewActividades.CurrentRow.DataBoundItem);
            f.ShowDialog();
            listaActividades[indexActividades] = (Actividad)dataGridViewActividades.CurrentRow.DataBoundItem;

            Actividad actividad2 = new Actividad();
            
            //Despres d'haver modificat una activitat repasem totes les llibreries que la tenen per actualitzarles
            foreach (Libreria libreria in listaLibrerias)
            {
                foreach (Actividad actividad in libreria.listaActividades)
                {
                    actividad2 = (Actividad)dataGridViewActividades.CurrentRow.DataBoundItem;
                    if (actividad.id == actividad2.id)
                    {
                        int index = libreria.listaActividades.IndexOf(actividad);
                        libreria.listaActividades[index].nombre = actividad2.nombre;
                        libreria.listaActividades[index].descripcion = actividad2.descripcion;
                        libreria.listaActividades[index].puntos = actividad2.puntos;
                    }
                }
            }

            Json.sobreescribirLibrerias(listaLibrerias);
            Json.sobreescribirActividades(listaActividades);
        }

        private void buttonEliminarActividad_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que quieres eliminar la actividad?", "ELIMINAR ACTIVIDAD", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //En les seguents linies busquem en cada llibreria l'activitat que estem eliminant en el form superuser-activitats i la borrem
                //Aixi no es creen inconsistencies a la BD
                Actividad objetoAux = (Actividad)dataGridViewActividades.CurrentRow.DataBoundItem;
                foreach (Libreria libreria in listaLibrerias)
                {
                    libreria.listaActividades.RemoveAll(x => x.id == objetoAux.id);
                }
                Json.sobreescribirLibrerias(listaLibrerias);

                listaActividades.Remove((Actividad)dataGridViewActividades.CurrentRow.DataBoundItem);
                Json.sobreescribirActividades(listaActividades);
                reloadDataGridViewActividades();
            }
            
        }
        #endregion
    }
}