using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Olor_a_libro
{
    public partial class FormInicio : Olor_a_libro.FormPlantillaVentana
    {
        public FormInicio(Usuario user)
        {
            InitializeComponent();
            /* aqui es donde pasamos el usuario que ha entrado a la plantilla, 
             * con lo que conseguimos que ya que la plantilla se informa se informen todos los demas forms
             */
            this.user = user;
        }
    }
}
