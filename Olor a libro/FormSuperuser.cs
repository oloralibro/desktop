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

        public FormSuperUser()
        {
            InitializeComponent();
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
            //Cargamos la lista de librerias
            cargarLibrerias();
            //Cargamos la lista de actividades
            cargarActividades();
        }

        private void FormSuperUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Json.sobreescribirUsuarios(listaUsuarios);
            Json.sobreescribirActividades(listaActividades);
            Json.sobreescribirLibrerias(listaLibrerias);
        }
        


        #region Usuarios
        private void reloadDataGridViewUsuarios()
        {
            dataGridViewUsuarios.DataSource = null;
            dataGridViewUsuarios.DataSource = listaUsuarios;
        }

        private void cargarUsuarios()
        {
            //Cargamos gridview de usuarios
            jArrayUsuarios = JArray.Parse(File.ReadAllText(@"../../Ficheros\UsuariosRegistrados.json"));
            listaUsuarios = jArrayUsuarios.ToObject<BindingList<Usuario>>();
            reloadDataGridViewUsuarios();
        }

        private void buttonModificarUsuarios_Click(object sender, EventArgs e)
        {
            FormAjustesUsuario f = new FormAjustesUsuario();
            f.listaUsuariosAjustes = listaUsuarios;
            f.user = (Usuario)dataGridViewUsuarios.CurrentRow.DataBoundItem;
            indexUsuarios = listaUsuarios.IndexOf(f.user);
            f.ShowDialog();
            listaUsuarios[indexUsuarios] = f.user;
        }

        private void buttonEliminarUsuarios_Click(object sender, EventArgs e)
        {
            listaUsuarios.Remove((Usuario)dataGridViewUsuarios.CurrentRow.DataBoundItem);
        
            Json.sobreescribirUsuarios(listaUsuarios);
        
            reloadDataGridViewUsuarios();
        }

        private void buttonAñadirUsuarios_Click(object sender, EventArgs e)
        {
            FormAnyadirUser f = new FormAnyadirUser();
            f.listaUsuariosAñadir = listaUsuarios;
            f.ShowDialog();
        }
        #endregion





        #region Librerias
        private void reloadDataGridViewLibrerias()
        {
            dataGridViewLibrerias.DataSource = null;
            dataGridViewLibrerias.DataSource = listaLibrerias;
        }

        private void cargarLibrerias()
        {
            //Cargamos la lista de librerias
            jArrayLibrerias = JArray.Parse(File.ReadAllText(@"../../Ficheros\LibreriasRegistradas.json"));
            listaLibrerias = jArrayLibrerias.ToObject<BindingList<Libreria>>();
            reloadDataGridViewLibrerias();
        }

        private void buttonAnyadirLibrerias_Click(object sender, EventArgs e)
        {
            FormAnyadirLibreria f = new FormAnyadirLibreria(listaLibrerias);
            f.ShowDialog();
        }

        private void buttonEliminarLibrerias_Click(object sender, EventArgs e)
        {
            listaLibrerias.Remove((Libreria)dataGridViewLibrerias.CurrentRow.DataBoundItem);

            Json.sobreescribirLibrerias(listaLibrerias);

            reloadDataGridViewLibrerias();
        }

        private void buttonModificarLibrerias_Click(object sender, EventArgs e)
        {
            FormAjustesLibreria f = new FormAjustesLibreria();
            f.listaLibreriasAjustes = listaLibrerias;
            f.ShowDialog();
        }
        #endregion





        #region Actividades
        private void reloadDataGridViewActividades()
        {
            dataGridViewActividades.DataSource = null;
            dataGridViewActividades.DataSource = listaActividades;
        }

        private void cargarActividades()
        {   //Cargamos la lista de actividades
            jArrayActividades = JArray.Parse(File.ReadAllText(@"../../Ficheros\ActividadesRegistradas.json"));
            listaActividades = jArrayActividades.ToObject<BindingList<Actividad>>();
            reloadDataGridViewActividades();
        }

        private void buttonModificarActividad_Click(object sender, EventArgs e)
        {
            FormAjustesActividad f = new FormAjustesActividad();
            f.listaActividades = listaActividades;
            f.actividad = (Actividad)dataGridViewActividades.CurrentRow.DataBoundItem;
            indexActividades = listaActividades.IndexOf(f.actividad);
            f.ShowDialog();
            listaActividades[indexActividades] = f.actividad;
        }

        private void buttonAñadirActividad_Click(object sender, EventArgs e)
        {
            FormAñadirActividad f = new FormAñadirActividad();
            f.listaActividadesAñadir = listaActividades;
            f.ShowDialog();
        }

        private void buttonEliminarActividad_Click(object sender, EventArgs e)
        {
            listaActividades.Remove((Actividad)dataGridViewActividades.CurrentRow.DataBoundItem);
            Json.sobreescribirActividades(listaActividades);
            reloadDataGridViewActividades();
        }
        #endregion
    }
}