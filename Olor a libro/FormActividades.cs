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
        public FormActividades(Usuario user)
        {
            InitializeComponent();
            this.user = user;
        }
    }
}
