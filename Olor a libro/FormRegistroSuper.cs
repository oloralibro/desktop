using System;
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
    public partial class FormRegistroSuper : Form
    {
        public bool super_user=false;

        public FormRegistroSuper()
        {
            InitializeComponent();
        }

        private void buttonAceptarSuper_Click(object sender, EventArgs e)
        {
            if (this.textBoxContraseñaSuper.Text.Equals("superuser"))
            {
                MessageBox.Show("Privilegios actualizados","",MessageBoxButtons.OK);
                super_user = true;
                this.Close();
            }
            else {
                MessageBox.Show("Contraseña incorrecta.", "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
