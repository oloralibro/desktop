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
    public partial class FormAñadirActividadALibreria : Form
    {
        List<Actividad> listaActividadesCompleta = new List<Actividad>();
        List<Actividad> listaActividadesLibreria;

        public FormAñadirActividadALibreria(List<Actividad> listaActividadesLibreria)
        {
            InitializeComponent();
            this.listaActividadesLibreria = listaActividadesLibreria;
        }

        private void FormAñadirActividadALibreria_Load(object sender, EventArgs e)
        {
            JArray jArrayActividades = JArray.Parse(File.ReadAllText(@"../../Ficheros\ActividadesRegistradas.json"));
            listaActividadesCompleta = jArrayActividades.ToObject<List<Actividad>>();
            foreach (Actividad actividad in listaActividadesLibreria)
            {
                listaActividadesCompleta.RemoveAll(p => p.id==actividad.id);
            }
            dataGridViewActividades.DataSource = listaActividadesCompleta;
            dataGridViewActividades.Columns["direccion"].Visible = false;
            dataGridViewActividades.Columns["id"].Width=35;
            dataGridViewActividades.Columns["puntos"].Width = 50;
            dataGridViewActividades.Columns["descripcion"].Width = 150;
        }

        private void buttonAñadirActividadALibreria_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridViewActividades.SelectedRows)
            { 
                listaActividadesLibreria.Add((Actividad)r.DataBoundItem);
            }
            this.Close();
        }
    }
}
