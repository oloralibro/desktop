using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Olor_a_libro
{
    public partial class FormPerfil : Olor_a_libro.FormPlantillaVentana
    {
        public FormPerfil(Usuario user)
        {
            InitializeComponent();
            this.user = user;
        }
    }
}
