namespace Olor_a_libro
{
    partial class FormSuperUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSuperUser));
            this.tabControlSuperuser = new System.Windows.Forms.TabControl();
            this.tabPageRedLibrerias = new System.Windows.Forms.TabPage();
            this.dataGridViewLibrerias = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaApertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEliminarLibrerias = new System.Windows.Forms.Button();
            this.buttonModificarLibrerias = new System.Windows.Forms.Button();
            this.buttonAnyadirLibrerias = new System.Windows.Forms.Button();
            this.textBoxBuscadorLibrerias = new System.Windows.Forms.TextBox();
            this.pictureBoxIconoBuscadorLibrerias = new System.Windows.Forms.PictureBox();
            this.tabPageUsuarios = new System.Windows.Forms.TabPage();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.buttonEliminarUsuarios = new System.Windows.Forms.Button();
            this.buttonModificarUsuarios = new System.Windows.Forms.Button();
            this.buttonAñadirUsuarios = new System.Windows.Forms.Button();
            this.textBoxBuscadorUsuarios = new System.Windows.Forms.TextBox();
            this.pictureBoxIconoBuscadorUsuarios = new System.Windows.Forms.PictureBox();
            this.tabPageActividades = new System.Windows.Forms.TabPage();
            this.dataGridViewActividades = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEliminarActividad = new System.Windows.Forms.Button();
            this.buttonModificarActividad = new System.Windows.Forms.Button();
            this.buttonAñadirActividad = new System.Windows.Forms.Button();
            this.textBoxBuscadorActividades = new System.Windows.Forms.TextBox();
            this.pictureBoxIconoBuscadorActividades = new System.Windows.Forms.PictureBox();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoElectronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.superUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntuacionTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlSuperuser.SuspendLayout();
            this.tabPageRedLibrerias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibrerias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconoBuscadorLibrerias)).BeginInit();
            this.tabPageUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconoBuscadorUsuarios)).BeginInit();
            this.tabPageActividades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconoBuscadorActividades)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSuperuser
            // 
            this.tabControlSuperuser.Controls.Add(this.tabPageRedLibrerias);
            this.tabControlSuperuser.Controls.Add(this.tabPageUsuarios);
            this.tabControlSuperuser.Controls.Add(this.tabPageActividades);
            this.tabControlSuperuser.Location = new System.Drawing.Point(0, 77);
            this.tabControlSuperuser.Name = "tabControlSuperuser";
            this.tabControlSuperuser.SelectedIndex = 0;
            this.tabControlSuperuser.Size = new System.Drawing.Size(1264, 603);
            this.tabControlSuperuser.TabIndex = 4;
            // 
            // tabPageRedLibrerias
            // 
            this.tabPageRedLibrerias.Controls.Add(this.dataGridViewLibrerias);
            this.tabPageRedLibrerias.Controls.Add(this.buttonEliminarLibrerias);
            this.tabPageRedLibrerias.Controls.Add(this.buttonModificarLibrerias);
            this.tabPageRedLibrerias.Controls.Add(this.buttonAnyadirLibrerias);
            this.tabPageRedLibrerias.Controls.Add(this.textBoxBuscadorLibrerias);
            this.tabPageRedLibrerias.Controls.Add(this.pictureBoxIconoBuscadorLibrerias);
            this.tabPageRedLibrerias.Location = new System.Drawing.Point(4, 22);
            this.tabPageRedLibrerias.Name = "tabPageRedLibrerias";
            this.tabPageRedLibrerias.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRedLibrerias.Size = new System.Drawing.Size(1256, 577);
            this.tabPageRedLibrerias.TabIndex = 0;
            this.tabPageRedLibrerias.Text = "Red de Librerías";
            this.tabPageRedLibrerias.UseVisualStyleBackColor = true;
            // 
            // dataGridViewLibrerias
            // 
            this.dataGridViewLibrerias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(197)))), ((int)(((byte)(220)))));
            this.dataGridViewLibrerias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLibrerias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.direccion,
            this.horaApertura,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridViewLibrerias.Location = new System.Drawing.Point(41, 80);
            this.dataGridViewLibrerias.Name = "dataGridViewLibrerias";
            this.dataGridViewLibrerias.Size = new System.Drawing.Size(1178, 407);
            this.dataGridViewLibrerias.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre libreria";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 235;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "Dirección";
            this.direccion.Name = "direccion";
            this.direccion.Width = 235;
            // 
            // horaApertura
            // 
            this.horaApertura.DataPropertyName = "horaApertura";
            this.horaApertura.HeaderText = "Hora apertura";
            this.horaApertura.Name = "horaApertura";
            this.horaApertura.Width = 235;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "horaCierre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Hora cierre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 235;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "numeroTelefono";
            this.dataGridViewTextBoxColumn3.HeaderText = "Teléfono";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 235;
            // 
            // buttonEliminarLibrerias
            // 
            this.buttonEliminarLibrerias.Location = new System.Drawing.Point(620, 514);
            this.buttonEliminarLibrerias.Name = "buttonEliminarLibrerias";
            this.buttonEliminarLibrerias.Size = new System.Drawing.Size(84, 32);
            this.buttonEliminarLibrerias.TabIndex = 5;
            this.buttonEliminarLibrerias.Text = "Eliminar";
            this.buttonEliminarLibrerias.UseVisualStyleBackColor = true;
            this.buttonEliminarLibrerias.Click += new System.EventHandler(this.buttonEliminarLibrerias_Click);
            // 
            // buttonModificarLibrerias
            // 
            this.buttonModificarLibrerias.Location = new System.Drawing.Point(502, 514);
            this.buttonModificarLibrerias.Name = "buttonModificarLibrerias";
            this.buttonModificarLibrerias.Size = new System.Drawing.Size(82, 32);
            this.buttonModificarLibrerias.TabIndex = 4;
            this.buttonModificarLibrerias.Text = "Modificar";
            this.buttonModificarLibrerias.UseVisualStyleBackColor = true;
            this.buttonModificarLibrerias.Click += new System.EventHandler(this.buttonModificarLibrerias_Click);
            // 
            // buttonAnyadirLibrerias
            // 
            this.buttonAnyadirLibrerias.Location = new System.Drawing.Point(739, 514);
            this.buttonAnyadirLibrerias.Name = "buttonAnyadirLibrerias";
            this.buttonAnyadirLibrerias.Size = new System.Drawing.Size(82, 32);
            this.buttonAnyadirLibrerias.TabIndex = 3;
            this.buttonAnyadirLibrerias.Text = "Añadir";
            this.buttonAnyadirLibrerias.UseVisualStyleBackColor = true;
            this.buttonAnyadirLibrerias.Click += new System.EventHandler(this.buttonAnyadirLibrerias_Click);
            // 
            // textBoxBuscadorLibrerias
            // 
            this.textBoxBuscadorLibrerias.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxBuscadorLibrerias.Location = new System.Drawing.Point(79, 33);
            this.textBoxBuscadorLibrerias.Multiline = true;
            this.textBoxBuscadorLibrerias.Name = "textBoxBuscadorLibrerias";
            this.textBoxBuscadorLibrerias.Size = new System.Drawing.Size(675, 32);
            this.textBoxBuscadorLibrerias.TabIndex = 1;
            // 
            // pictureBoxIconoBuscadorLibrerias
            // 
            this.pictureBoxIconoBuscadorLibrerias.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIconoBuscadorLibrerias.Image")));
            this.pictureBoxIconoBuscadorLibrerias.Location = new System.Drawing.Point(41, 33);
            this.pictureBoxIconoBuscadorLibrerias.Name = "pictureBoxIconoBuscadorLibrerias";
            this.pictureBoxIconoBuscadorLibrerias.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxIconoBuscadorLibrerias.TabIndex = 0;
            this.pictureBoxIconoBuscadorLibrerias.TabStop = false;
            // 
            // tabPageUsuarios
            // 
            this.tabPageUsuarios.Controls.Add(this.dataGridViewUsuarios);
            this.tabPageUsuarios.Controls.Add(this.buttonEliminarUsuarios);
            this.tabPageUsuarios.Controls.Add(this.buttonModificarUsuarios);
            this.tabPageUsuarios.Controls.Add(this.buttonAñadirUsuarios);
            this.tabPageUsuarios.Controls.Add(this.textBoxBuscadorUsuarios);
            this.tabPageUsuarios.Controls.Add(this.pictureBoxIconoBuscadorUsuarios);
            this.tabPageUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tabPageUsuarios.Name = "tabPageUsuarios";
            this.tabPageUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsuarios.Size = new System.Drawing.Size(1256, 577);
            this.tabPageUsuarios.TabIndex = 1;
            this.tabPageUsuarios.Text = "Usuarios";
            this.tabPageUsuarios.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(197)))), ((int)(((byte)(220)))));
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.contraseña,
            this.correoElectronico,
            this.superUsuario,
            this.puntuacionTotal});
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(41, 80);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(1178, 407);
            this.dataGridViewUsuarios.TabIndex = 18;
            // 
            // buttonEliminarUsuarios
            // 
            this.buttonEliminarUsuarios.Location = new System.Drawing.Point(620, 514);
            this.buttonEliminarUsuarios.Name = "buttonEliminarUsuarios";
            this.buttonEliminarUsuarios.Size = new System.Drawing.Size(84, 32);
            this.buttonEliminarUsuarios.TabIndex = 17;
            this.buttonEliminarUsuarios.Text = "Eliminar";
            this.buttonEliminarUsuarios.UseVisualStyleBackColor = true;
            this.buttonEliminarUsuarios.Click += new System.EventHandler(this.buttonEliminarUsuarios_Click);
            // 
            // buttonModificarUsuarios
            // 
            this.buttonModificarUsuarios.Location = new System.Drawing.Point(502, 514);
            this.buttonModificarUsuarios.Name = "buttonModificarUsuarios";
            this.buttonModificarUsuarios.Size = new System.Drawing.Size(82, 32);
            this.buttonModificarUsuarios.TabIndex = 16;
            this.buttonModificarUsuarios.Text = "Modificar";
            this.buttonModificarUsuarios.UseVisualStyleBackColor = true;
            this.buttonModificarUsuarios.Click += new System.EventHandler(this.buttonModificarUsuarios_Click);
            // 
            // buttonAñadirUsuarios
            // 
            this.buttonAñadirUsuarios.Location = new System.Drawing.Point(739, 514);
            this.buttonAñadirUsuarios.Name = "buttonAñadirUsuarios";
            this.buttonAñadirUsuarios.Size = new System.Drawing.Size(82, 32);
            this.buttonAñadirUsuarios.TabIndex = 15;
            this.buttonAñadirUsuarios.Text = "Añadir";
            this.buttonAñadirUsuarios.UseVisualStyleBackColor = true;
            this.buttonAñadirUsuarios.Click += new System.EventHandler(this.buttonAñadirUsuarios_Click);
            // 
            // textBoxBuscadorUsuarios
            // 
            this.textBoxBuscadorUsuarios.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxBuscadorUsuarios.Location = new System.Drawing.Point(79, 33);
            this.textBoxBuscadorUsuarios.Multiline = true;
            this.textBoxBuscadorUsuarios.Name = "textBoxBuscadorUsuarios";
            this.textBoxBuscadorUsuarios.Size = new System.Drawing.Size(675, 32);
            this.textBoxBuscadorUsuarios.TabIndex = 13;
            // 
            // pictureBoxIconoBuscadorUsuarios
            // 
            this.pictureBoxIconoBuscadorUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIconoBuscadorUsuarios.Image")));
            this.pictureBoxIconoBuscadorUsuarios.Location = new System.Drawing.Point(41, 33);
            this.pictureBoxIconoBuscadorUsuarios.Name = "pictureBoxIconoBuscadorUsuarios";
            this.pictureBoxIconoBuscadorUsuarios.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxIconoBuscadorUsuarios.TabIndex = 12;
            this.pictureBoxIconoBuscadorUsuarios.TabStop = false;
            // 
            // tabPageActividades
            // 
            this.tabPageActividades.Controls.Add(this.dataGridViewActividades);
            this.tabPageActividades.Controls.Add(this.buttonEliminarActividad);
            this.tabPageActividades.Controls.Add(this.buttonModificarActividad);
            this.tabPageActividades.Controls.Add(this.buttonAñadirActividad);
            this.tabPageActividades.Controls.Add(this.textBoxBuscadorActividades);
            this.tabPageActividades.Controls.Add(this.pictureBoxIconoBuscadorActividades);
            this.tabPageActividades.Location = new System.Drawing.Point(4, 22);
            this.tabPageActividades.Name = "tabPageActividades";
            this.tabPageActividades.Size = new System.Drawing.Size(1256, 577);
            this.tabPageActividades.TabIndex = 2;
            this.tabPageActividades.Text = "Actividades";
            this.tabPageActividades.UseVisualStyleBackColor = true;
            // 
            // dataGridViewActividades
            // 
            this.dataGridViewActividades.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(197)))), ((int)(((byte)(220)))));
            this.dataGridViewActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridViewActividades.Location = new System.Drawing.Point(41, 80);
            this.dataGridViewActividades.Name = "dataGridViewActividades";
            this.dataGridViewActividades.Size = new System.Drawing.Size(1178, 407);
            this.dataGridViewActividades.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nombre actividad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 292;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn5.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 684;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "puntos";
            this.dataGridViewTextBoxColumn6.HeaderText = "Puntos";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // buttonEliminarActividad
            // 
            this.buttonEliminarActividad.Location = new System.Drawing.Point(620, 514);
            this.buttonEliminarActividad.Name = "buttonEliminarActividad";
            this.buttonEliminarActividad.Size = new System.Drawing.Size(84, 32);
            this.buttonEliminarActividad.TabIndex = 11;
            this.buttonEliminarActividad.Text = "Eliminar";
            this.buttonEliminarActividad.UseVisualStyleBackColor = true;
            this.buttonEliminarActividad.Click += new System.EventHandler(this.buttonEliminarActividad_Click);
            // 
            // buttonModificarActividad
            // 
            this.buttonModificarActividad.Location = new System.Drawing.Point(502, 514);
            this.buttonModificarActividad.Name = "buttonModificarActividad";
            this.buttonModificarActividad.Size = new System.Drawing.Size(82, 32);
            this.buttonModificarActividad.TabIndex = 10;
            this.buttonModificarActividad.Text = "Modificar";
            this.buttonModificarActividad.UseVisualStyleBackColor = true;
            // 
            // buttonAñadirActividad
            // 
            this.buttonAñadirActividad.Location = new System.Drawing.Point(739, 514);
            this.buttonAñadirActividad.Name = "buttonAñadirActividad";
            this.buttonAñadirActividad.Size = new System.Drawing.Size(82, 32);
            this.buttonAñadirActividad.TabIndex = 9;
            this.buttonAñadirActividad.Text = "Añadir";
            this.buttonAñadirActividad.UseVisualStyleBackColor = true;
            this.buttonAñadirActividad.Click += new System.EventHandler(this.buttonAñadirActividad_Click);
            // 
            // textBoxBuscadorActividades
            // 
            this.textBoxBuscadorActividades.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxBuscadorActividades.Location = new System.Drawing.Point(79, 33);
            this.textBoxBuscadorActividades.Multiline = true;
            this.textBoxBuscadorActividades.Name = "textBoxBuscadorActividades";
            this.textBoxBuscadorActividades.Size = new System.Drawing.Size(675, 32);
            this.textBoxBuscadorActividades.TabIndex = 7;
            // 
            // pictureBoxIconoBuscadorActividades
            // 
            this.pictureBoxIconoBuscadorActividades.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIconoBuscadorActividades.Image")));
            this.pictureBoxIconoBuscadorActividades.Location = new System.Drawing.Point(41, 33);
            this.pictureBoxIconoBuscadorActividades.Name = "pictureBoxIconoBuscadorActividades";
            this.pictureBoxIconoBuscadorActividades.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxIconoBuscadorActividades.TabIndex = 6;
            this.pictureBoxIconoBuscadorActividades.TabStop = false;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre usuario";
            this.nombre.Name = "nombre";
            this.nombre.Width = 250;
            // 
            // contraseña
            // 
            this.contraseña.DataPropertyName = "contraseña";
            this.contraseña.HeaderText = "Contraseña";
            this.contraseña.Name = "contraseña";
            this.contraseña.Width = 250;
            // 
            // correoElectronico
            // 
            this.correoElectronico.DataPropertyName = "correoElectronico";
            this.correoElectronico.HeaderText = "E-mail";
            this.correoElectronico.Name = "correoElectronico";
            this.correoElectronico.Width = 350;
            // 
            // superUsuario
            // 
            this.superUsuario.DataPropertyName = "superUsuario";
            this.superUsuario.HeaderText = "Super user";
            this.superUsuario.Name = "superUsuario";
            this.superUsuario.Width = 150;
            // 
            // puntuacionTotal
            // 
            this.puntuacionTotal.DataPropertyName = "puntuacionTotal";
            this.puntuacionTotal.HeaderText = "Puntos";
            this.puntuacionTotal.Name = "puntuacionTotal";
            this.puntuacionTotal.Width = 150;
            // 
            // FormSuperUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(197)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1259, 678);
            this.Controls.Add(this.tabControlSuperuser);
            this.Name = "FormSuperUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Olor A Libro - SuperUser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSuperUser_FormClosing);
            this.Load += new System.EventHandler(this.FormSuperUser_Load);
            this.Controls.SetChildIndex(this.tabControlSuperuser, 0);
            this.tabControlSuperuser.ResumeLayout(false);
            this.tabPageRedLibrerias.ResumeLayout(false);
            this.tabPageRedLibrerias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibrerias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconoBuscadorLibrerias)).EndInit();
            this.tabPageUsuarios.ResumeLayout(false);
            this.tabPageUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconoBuscadorUsuarios)).EndInit();
            this.tabPageActividades.ResumeLayout(false);
            this.tabPageActividades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconoBuscadorActividades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSuperuser;
        private System.Windows.Forms.TabPage tabPageRedLibrerias;
        private System.Windows.Forms.TabPage tabPageUsuarios;
        private System.Windows.Forms.TextBox textBoxBuscadorLibrerias;
        private System.Windows.Forms.PictureBox pictureBoxIconoBuscadorLibrerias;
        private System.Windows.Forms.Button buttonEliminarLibrerias;
        private System.Windows.Forms.Button buttonModificarLibrerias;
        private System.Windows.Forms.Button buttonAnyadirLibrerias;
        private System.Windows.Forms.Button buttonEliminarUsuarios;
        private System.Windows.Forms.Button buttonModificarUsuarios;
        private System.Windows.Forms.Button buttonAñadirUsuarios;
        private System.Windows.Forms.TextBox textBoxBuscadorUsuarios;
        private System.Windows.Forms.PictureBox pictureBoxIconoBuscadorUsuarios;
        private System.Windows.Forms.TabPage tabPageActividades;
        private System.Windows.Forms.Button buttonEliminarActividad;
        private System.Windows.Forms.Button buttonModificarActividad;
        private System.Windows.Forms.Button buttonAñadirActividad;
        private System.Windows.Forms.TextBox textBoxBuscadorActividades;
        private System.Windows.Forms.PictureBox pictureBoxIconoBuscadorActividades;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.DataGridView dataGridViewLibrerias;
        private System.Windows.Forms.DataGridView dataGridViewActividades;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaApertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoElectronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn superUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn puntuacionTotal;
    }
}
