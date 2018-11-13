namespace Olor_a_libro
{
    partial class FormSuperuser
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSuperuser));
            this.tabControlSuperuser = new System.Windows.Forms.TabControl();
            this.tabPageRedLibrerias = new System.Windows.Forms.TabPage();
            this.tabPageUsuarios = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxBuscador = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonAnyadir = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.tabControlSuperuser.SuspendLayout();
            this.tabPageRedLibrerias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSuperuser
            // 
            this.tabControlSuperuser.Controls.Add(this.tabPageRedLibrerias);
            this.tabControlSuperuser.Controls.Add(this.tabPageUsuarios);
            this.tabControlSuperuser.Location = new System.Drawing.Point(0, 77);
            this.tabControlSuperuser.Name = "tabControlSuperuser";
            this.tabControlSuperuser.SelectedIndex = 0;
            this.tabControlSuperuser.Size = new System.Drawing.Size(1264, 603);
            this.tabControlSuperuser.TabIndex = 4;
            // 
            // tabPageRedLibrerias
            // 
            this.tabPageRedLibrerias.Controls.Add(this.buttonEliminar);
            this.tabPageRedLibrerias.Controls.Add(this.buttonModificar);
            this.tabPageRedLibrerias.Controls.Add(this.buttonAnyadir);
            this.tabPageRedLibrerias.Controls.Add(this.listBox1);
            this.tabPageRedLibrerias.Controls.Add(this.textBoxBuscador);
            this.tabPageRedLibrerias.Controls.Add(this.pictureBox1);
            this.tabPageRedLibrerias.Location = new System.Drawing.Point(4, 22);
            this.tabPageRedLibrerias.Name = "tabPageRedLibrerias";
            this.tabPageRedLibrerias.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRedLibrerias.Size = new System.Drawing.Size(1256, 577);
            this.tabPageRedLibrerias.TabIndex = 0;
            this.tabPageRedLibrerias.Text = "Red de Librerías";
            this.tabPageRedLibrerias.UseVisualStyleBackColor = true;
            // 
            // tabPageUsuarios
            // 
            this.tabPageUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tabPageUsuarios.Name = "tabPageUsuarios";
            this.tabPageUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsuarios.Size = new System.Drawing.Size(1190, 473);
            this.tabPageUsuarios.TabIndex = 1;
            this.tabPageUsuarios.Text = "Usuarios";
            this.tabPageUsuarios.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxBuscador
            // 
            this.textBoxBuscador.Location = new System.Drawing.Point(79, 31);
            this.textBoxBuscador.Multiline = true;
            this.textBoxBuscador.Name = "textBoxBuscador";
            this.textBoxBuscador.Size = new System.Drawing.Size(1140, 32);
            this.textBoxBuscador.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(41, 87);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1178, 433);
            this.listBox1.TabIndex = 2;
            // 
            // buttonAnyadir
            // 
            this.buttonAnyadir.Location = new System.Drawing.Point(1144, 535);
            this.buttonAnyadir.Name = "buttonAnyadir";
            this.buttonAnyadir.Size = new System.Drawing.Size(75, 23);
            this.buttonAnyadir.TabIndex = 3;
            this.buttonAnyadir.Text = "Añadir";
            this.buttonAnyadir.UseVisualStyleBackColor = true;
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(1035, 535);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(75, 23);
            this.buttonModificar.TabIndex = 4;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(929, 535);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 5;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // FormSuperuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1259, 678);
            this.Controls.Add(this.tabControlSuperuser);
            this.Name = "FormSuperuser";
            this.Text = "Menú Superuser";
            this.Controls.SetChildIndex(this.tabControlSuperuser, 0);
            this.tabControlSuperuser.ResumeLayout(false);
            this.tabPageRedLibrerias.ResumeLayout(false);
            this.tabPageRedLibrerias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSuperuser;
        private System.Windows.Forms.TabPage tabPageRedLibrerias;
        private System.Windows.Forms.TabPage tabPageUsuarios;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxBuscador;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonAnyadir;
    }
}
