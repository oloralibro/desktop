using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Olor_a_libro
{
    public partial class FormLibrerias : Olor_a_libro.FormPlantillaVentana
    {
        public FormLibrerias(Usuario user)
        {
            InitializeComponent();
            this.user = user;
        }
    }
}
