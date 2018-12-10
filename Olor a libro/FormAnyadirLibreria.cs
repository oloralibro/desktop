﻿using System;
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
    public partial class FormAnyadirLibreria : Form
    {
        BindingList<Libreria> listaLibrerias;
        Libreria l = new Libreria();
        public FormAnyadirLibreria(BindingList<Libreria> librerias)
        {
            InitializeComponent();
            listaLibrerias = librerias;
        }

        private void buttonAnyadirActividad_Click(object sender, EventArgs e)
        {
            FormAñadirActividad f = new FormAñadirActividad();
            f.ShowDialog();
            dataGridViewActividades.DataSource = l.listaActividades;
        }

        private void buttonAceptarLibreria_Click(object sender, EventArgs e)
        {
            l.nombre = textBoxNombreLibreria.Text;
            l.direccion = textBoxDireccion.Text;
            l.numeroTelefono = textBoxTelefono.Text;
            l.horario = textBoxHorario.Text;

            listaLibrerias.Add(l);

            this.Close();    
        }
  
    }
}
