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
    public partial class FormSuperuser : Olor_a_libro.FormPlantillaVentana
    {
        public FormSuperuser()
        {
            InitializeComponent();
        }

        private void buttonAnyadirLibrerias_Click(object sender, EventArgs e)
        {
            FormAñadirLibreria f = new FormAñadirLibreria();
            f.ShowDialog();
        }
    }
}
