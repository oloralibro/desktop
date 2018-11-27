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
        Json json = new Json();
        JArray jArrayUsuarios, jArrayLibrerias, jArrayActividades;
        BindingList<Usuario> listaUsuarios;
        BindingList<Actividad> listaActividades;
        BindingList<Libreria> listaLibrerias;

        public FormSuperUser()
        {
            InitializeComponent();
        }

        private void FormSuperUser_Activated(object sender, EventArgs e) {
            json.sobreescribirUsuarios(listaUsuarios);
            json.sobreescribirActividades(listaActividades);
            json.sobreescribirLibrerias(listaLibrerias);
        }

        private void FormSuperUser_Load(object sender, EventArgs e)
        {
            dataGridViewActividades.AutoGenerateColumns = false;
            dataGridViewLibrerias.AutoGenerateColumns = false;
            dataGridViewUsuarios.AutoGenerateColumns = false;
            //Cargamos gridview de usuarios
            cargarUsuarios();
            //Cargamos la lista de librerias
            cargarLibrerias();
            //Cargamos la lista de actividades
            cargarActividades();
        }

        private void FormSuperUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            json.sobreescribirUsuarios(listaUsuarios);
            json.sobreescribirActividades(listaActividades);
            json.sobreescribirLibrerias(listaLibrerias);
        }

        #region Usuarios
        private void cargarUsuarios()
        {
            //Cargamos gridview de usuarios
            jArrayUsuarios = JArray.Parse(File.ReadAllText(@"../../Ficheros\UsuariosRegistrados.json"));
            listaUsuarios = jArrayUsuarios.ToObject<BindingList<Usuario>>();
            dataGridViewUsuarios.DataSource = null;
            dataGridViewUsuarios.DataSource = listaUsuarios;
        }

        private void buttonModificarUsuarios_Click(object sender, EventArgs e)
        {
            FormAjustesUsuario f = new FormAjustesUsuario();
            f.listaUsuariosAjustes = listaUsuarios;
            f.user = (Usuario)dataGridViewUsuarios.CurrentRow.DataBoundItem;
            int index = listaUsuarios.IndexOf(f.user);
            f.ShowDialog();
            listaUsuarios[index] = f.user;
        }

        private void buttonEliminarUsuarios_Click(object sender, EventArgs e)
        {
            listaUsuarios.Remove((Usuario)dataGridViewUsuarios.SelectedRows[0].DataBoundItem);
        
            json.sobreescribirUsuarios(listaUsuarios);
        
            dataGridViewUsuarios.DataSource = null;
            dataGridViewUsuarios.DataSource = listaUsuarios;
        }

        private void buttonAñadirUsuarios_Click(object sender, EventArgs e)
        {
            FormAnyadirUser f = new FormAnyadirUser(listaUsuarios);
            f.ShowDialog();
        }
        #endregion

        #region Librerias

        private void cargarLibrerias()
        {
            //Cargamos la lista de librerias
            jArrayLibrerias = JArray.Parse(File.ReadAllText(@"../../Ficheros\LibreriasRegistradas.json"));
            listaLibrerias = jArrayLibrerias.ToObject<BindingList<Libreria>>();
            dataGridViewLibrerias.DataSource = null;
            dataGridViewLibrerias.DataSource = listaLibrerias;
        }

        private void buttonAnyadirLibrerias_Click(object sender, EventArgs e)
        {
            FormAnyadirLibreria f = new FormAnyadirLibreria(listaLibrerias);
            f.ShowDialog();
        }

        private void buttonEliminarLibrerias_Click(object sender, EventArgs e)
        {
            listaLibrerias.Remove((Libreria)dataGridViewLibrerias.SelectedRows[0].DataBoundItem);

            json.sobreescribirLibrerias(listaLibrerias);

            dataGridViewLibrerias.DataSource = null;
            dataGridViewLibrerias.DataSource = listaLibrerias;
        }

        private void buttonModificarLibrerias_Click(object sender, EventArgs e)
        {
            FormAjustesLibreria f = new FormAjustesLibreria();
        }
        #endregion

        #region Actividades
        private void cargarActividades()
        {   //Cargamos la lista de actividades
            jArrayActividades = JArray.Parse(File.ReadAllText(@"../../Ficheros\ActividadesRegistradas.json"));
            listaActividades = jArrayActividades.ToObject<BindingList<Actividad>>();
            dataGridViewActividades.DataSource = null;
            dataGridViewActividades.DataSource = listaActividades;
        }

        private void buttonAñadirActividad_Click(object sender, EventArgs e)
        {
            FormAjustesActividad f = new FormAjustesActividad();
            f.ShowDialog();
        }

        private void buttonEliminarActividad_Click(object sender, EventArgs e)
        {
            listaActividades.Remove((Actividad)dataGridViewActividades.SelectedRows[0].DataBoundItem);

            json.sobreescribirActividades(listaActividades);

            dataGridViewActividades.DataSource = null;
            dataGridViewActividades.DataSource = listaActividades;
        }

        private void RefrescarActividades()
        {
            dataGridViewActividades.DataSource = null;
            dataGridViewActividades.DataSource = listaActividades;
        }

        #endregion
    }
}