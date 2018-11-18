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

namespace Olor_a_libro
{
    public partial class FormSuperUser : Olor_a_libro.FormPlantillaVentana
    {

        //String[] lista_actividades =
        JArray jArrayUsuarios;
        List<Usuario> listaUsuarios;

        public FormSuperUser()
        {
            InitializeComponent();
        }

        private void FormSuperUser_Load(object sender, EventArgs e)
        {
            //listBoxActividades.Items.AddRange();
        }

        private void buttonAnyadirLibrerias_Click(object sender, EventArgs e)
        {
            FormAjustesLibreria f = new FormAjustesLibreria();
            f.ShowDialog();
        }

        private void buttonAñadirActividad_Click(object sender, EventArgs e)
        {
            FormAjustesActividad f = new FormAjustesActividad();
            f.ShowDialog();
        }

        private void tabPageUsuarios_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"../../Ficheros\UsuariosRegistrados.json"))
            {
                jArrayUsuarios = JArray.Parse(File.ReadAllText(@"../../Ficheros\UsuariosRegistrados.json"));
                listaUsuarios = jArrayUsuarios.ToObject<List<Usuario>>();

                dataGridViewUsuarios.DataSource = listaUsuarios;
            }
            else
            {
                MessageBox.Show("No hay ningun usuario registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}