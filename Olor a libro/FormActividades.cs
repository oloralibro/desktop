using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Olor_a_libro
{
    public partial class FormActividades : Olor_a_libro.FormPlantillaVentana
    {
        public FormActividades()
        {
            InitializeComponent();
        }

        //Evento para que aparezca y desaparezca el buscador cuando clickamos la lupa
        /*private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBoxBuscar.Visible.Equals(false)) {
                textBoxBuscar.Visible = true;
            }
            else{
                textBoxBuscar.Visible = false;
            }
        }*/
    }
}
