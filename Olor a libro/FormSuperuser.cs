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

        public FormSuperUser()
        {
            InitializeComponent();
        }

        private void FormSuperUser_Activated(object sender, EventArgs e) {
            sobreescribirUsuarios();
        }

        private void FormSuperUser_Load(object sender, EventArgs e)
        {
            dataGridViewActividades.AutoGenerateColumns = false;
            dataGridViewLibrerias.AutoGenerateColumns = false;
            dataGridViewUsuarios.AutoGenerateColumns = false;
            //Cargamos gridview de usuarios
            cargarUsuarios();
            //Cargamos la lista de librerias
            SobreescribirLibrerias();
            //Cargamos la lista de actividades
            SobreescribirActividades();
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

        private void sobreescribirUsuarios() {
            JArray jArrayUsuarios = (JArray)JToken.FromObject(listaUsuarios);
            StreamWriter fichero = File.CreateText(@"../../Ficheros\UsuariosRegistrados.json");
            JsonTextWriter writer = new JsonTextWriter(fichero);

            jArrayUsuarios.WriteTo(writer);
            writer.Close();
        }

        private void buttonModificarUsuarios_Click(object sender, EventArgs e)
        {
            FormAjustesUsuario f = new FormAjustesUsuario();
            f.user = (Usuario)dataGridViewUsuarios.SelectedRows[0].DataBoundItem;
            f.ShowDialog();
        }

        private void buttonEliminarUsuarios_Click(object sender, EventArgs e)
        {
            listaUsuarios.Remove((Usuario)dataGridViewUsuarios.SelectedRows[0].DataBoundItem);

            sobreescribirUsuarios();

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

        private void SobreescribirLibrerias()
        {
            //Cargamos la lista de librerias
            jArrayLibrerias = JArray.Parse(File.ReadAllText(@"../../Ficheros\LibreriasRegistradas.json"));
            listaLibrerias = jArrayLibrerias.ToObject<BindingList<Libreria>>();
            dataGridViewLibrerias.DataSource = null;
            dataGridViewLibrerias.DataSource = listaLibrerias;
        }

        private void buttonAnyadirLibrerias_Click(object sender, EventArgs e)
        {
            FormAjustesLibreria f = new FormAjustesLibreria();
            f.ShowDialog();
        }

        #endregion

        #region Actividades
        private void SobreescribirActividades()
        {//Cargamos la lista de actividades
            jArrayActividades = JArray.Parse(File.ReadAllText(@"../../Ficheros\ActividadesRegistradas.json"));
            listaActividades = jArrayActividades.ToObject<BindingList<Actividad>>();
            dataGridViewActividades.DataSource = null;
            dataGridViewActividades.DataSource = listaActividades;
        }

        private void buttonEliminarActividad_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seguro que quieres eliminar la actividad?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                listaActividades.RemoveAt(dataGridViewActividades.SelectedRows[0].Index);
            }
        }

        private void RefrescarActividades()
        {
            dataGridViewActividades.DataSource = null;
            dataGridViewActividades.DataSource = listaActividades;
        }

        private void buttonAñadirActividad_Click(object sender, EventArgs e)
        {
            FormAjustesActividad f = new FormAjustesActividad();
            f.ShowDialog();
            SobreescribirActividades();
        }
        #endregion
    }
}
