﻿using Newtonsoft.Json.Linq;
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
    public partial class FormAñadirActividadALibreria : Form
    {
        List<Actividad> listaActividades = new List<Actividad>();
        List<Actividad> listaActividadesLibreria;

        public FormAñadirActividadALibreria(List<Actividad> listaActividadesLibreria)
        {
            InitializeComponent();
            this.listaActividadesLibreria = listaActividadesLibreria;
        }

        private void FormAñadirActividadALibreria_Load(object sender, EventArgs e)
        {
            JArray jArrayActividades = JArray.Parse(File.ReadAllText(@"../../Ficheros\ActividadesRegistradas.json"));
            listaActividades = jArrayActividades.ToObject<List<Actividad>>();
            dataGridViewActividades.DataSource = listaActividades;
            dataGridViewActividades.Columns["direccion"].Visible = false;
            dataGridViewActividades.Columns["id"].Width=35;
            dataGridViewActividades.Columns["puntos"].Width = 50;
            dataGridViewActividades.Columns["descripcion"].Width = 150;
        }

        private void buttonAñadirActividadALibreria_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridViewActividades.SelectedRows)
            {
                listaActividadesLibreria.Add(r.DataBoundItem);
            }
            listaActividadesLibreria.Add(dataGridViewActividades.SelectedRows.)
        }
    }
}
