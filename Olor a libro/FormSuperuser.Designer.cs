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
            this.buttonEliminarLibrerias = new System.Windows.Forms.Button();
            this.buttonModificarLibrerias = new System.Windows.Forms.Button();
            this.buttonAnyadirLibrerias = new System.Windows.Forms.Button();
            this.listBoxLibrerias = new System.Windows.Forms.ListBox();
            this.textBoxBuscadorLibrerias = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPageUsuarios = new System.Windows.Forms.TabPage();
            this.buttonEliminarUser = new System.Windows.Forms.Button();
            this.buttonModificarUser = new System.Windows.Forms.Button();
            this.buttonAnyadirUser = new System.Windows.Forms.Button();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.textBoxBuscadorUsers = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControlSuperuser.SuspendLayout();
            this.tabPageRedLibrerias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.tabPageRedLibrerias.Controls.Add(this.buttonEliminarLibrerias);
            this.tabPageRedLibrerias.Controls.Add(this.buttonModificarLibrerias);
            this.tabPageRedLibrerias.Controls.Add(this.buttonAnyadirLibrerias);
            this.tabPageRedLibrerias.Controls.Add(this.listBoxLibrerias);
            this.tabPageRedLibrerias.Controls.Add(this.textBoxBuscadorLibrerias);
            this.tabPageRedLibrerias.Controls.Add(this.pictureBox1);
            this.tabPageRedLibrerias.Location = new System.Drawing.Point(4, 22);
            this.tabPageRedLibrerias.Name = "tabPageRedLibrerias";
            this.tabPageRedLibrerias.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRedLibrerias.Size = new System.Drawing.Size(1256, 577);
            this.tabPageRedLibrerias.TabIndex = 0;
            this.tabPageRedLibrerias.Text = "Red de Librerías";
            this.tabPageRedLibrerias.UseVisualStyleBackColor = true;
            // 
            // buttonEliminarLibrerias
            // 
            this.buttonEliminarLibrerias.Location = new System.Drawing.Point(874, 535);
            this.buttonEliminarLibrerias.Name = "buttonEliminarLibrerias";
            this.buttonEliminarLibrerias.Size = new System.Drawing.Size(84, 32);
            this.buttonEliminarLibrerias.TabIndex = 5;
            this.buttonEliminarLibrerias.Text = "Eliminar";
            this.buttonEliminarLibrerias.UseVisualStyleBackColor = true;
            // 
            // buttonModificarLibrerias
            // 
            this.buttonModificarLibrerias.Location = new System.Drawing.Point(1009, 535);
            this.buttonModificarLibrerias.Name = "buttonModificarLibrerias";
            this.buttonModificarLibrerias.Size = new System.Drawing.Size(82, 32);
            this.buttonModificarLibrerias.TabIndex = 4;
            this.buttonModificarLibrerias.Text = "Modificar";
            this.buttonModificarLibrerias.UseVisualStyleBackColor = true;
            // 
            // buttonAnyadirLibrerias
            // 
            this.buttonAnyadirLibrerias.Location = new System.Drawing.Point(1137, 535);
            this.buttonAnyadirLibrerias.Name = "buttonAnyadirLibrerias";
            this.buttonAnyadirLibrerias.Size = new System.Drawing.Size(82, 32);
            this.buttonAnyadirLibrerias.TabIndex = 3;
            this.buttonAnyadirLibrerias.Text = "Añadir";
            this.buttonAnyadirLibrerias.UseVisualStyleBackColor = true;
            // 
            // listBoxLibrerias
            // 
            this.listBoxLibrerias.BackColor = System.Drawing.SystemColors.Menu;
            this.listBoxLibrerias.FormattingEnabled = true;
            this.listBoxLibrerias.Location = new System.Drawing.Point(41, 87);
            this.listBoxLibrerias.Name = "listBoxLibrerias";
            this.listBoxLibrerias.Size = new System.Drawing.Size(1178, 433);
            this.listBoxLibrerias.TabIndex = 2;
            // 
            // textBoxBuscadorLibrerias
            // 
            this.textBoxBuscadorLibrerias.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxBuscadorLibrerias.Location = new System.Drawing.Point(79, 31);
            this.textBoxBuscadorLibrerias.Multiline = true;
            this.textBoxBuscadorLibrerias.Name = "textBoxBuscadorLibrerias";
            this.textBoxBuscadorLibrerias.Size = new System.Drawing.Size(1140, 32);
            this.textBoxBuscadorLibrerias.TabIndex = 1;
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
            // tabPageUsuarios
            // 
            this.tabPageUsuarios.Controls.Add(this.buttonEliminarUser);
            this.tabPageUsuarios.Controls.Add(this.buttonModificarUser);
            this.tabPageUsuarios.Controls.Add(this.buttonAnyadirUser);
            this.tabPageUsuarios.Controls.Add(this.listBoxUsers);
            this.tabPageUsuarios.Controls.Add(this.textBoxBuscadorUsers);
            this.tabPageUsuarios.Controls.Add(this.pictureBox2);
            this.tabPageUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tabPageUsuarios.Name = "tabPageUsuarios";
            this.tabPageUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsuarios.Size = new System.Drawing.Size(1256, 577);
            this.tabPageUsuarios.TabIndex = 1;
            this.tabPageUsuarios.Text = "Usuarios";
            this.tabPageUsuarios.UseVisualStyleBackColor = true;
            // 
            // buttonEliminarUser
            // 
            this.buttonEliminarUser.Location = new System.Drawing.Point(874, 535);
            this.buttonEliminarUser.Name = "buttonEliminarUser";
            this.buttonEliminarUser.Size = new System.Drawing.Size(84, 32);
            this.buttonEliminarUser.TabIndex = 11;
            this.buttonEliminarUser.Text = "Eliminar";
            this.buttonEliminarUser.UseVisualStyleBackColor = true;
            // 
            // buttonModificarUser
            // 
            this.buttonModificarUser.Location = new System.Drawing.Point(1009, 535);
            this.buttonModificarUser.Name = "buttonModificarUser";
            this.buttonModificarUser.Size = new System.Drawing.Size(82, 32);
            this.buttonModificarUser.TabIndex = 10;
            this.buttonModificarUser.Text = "Modificar";
            this.buttonModificarUser.UseVisualStyleBackColor = true;
            // 
            // buttonAnyadirUser
            // 
            this.buttonAnyadirUser.Location = new System.Drawing.Point(1137, 535);
            this.buttonAnyadirUser.Name = "buttonAnyadirUser";
            this.buttonAnyadirUser.Size = new System.Drawing.Size(82, 32);
            this.buttonAnyadirUser.TabIndex = 9;
            this.buttonAnyadirUser.Text = "Añadir";
            this.buttonAnyadirUser.UseVisualStyleBackColor = true;
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.BackColor = System.Drawing.SystemColors.Menu;
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.Location = new System.Drawing.Point(41, 87);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(1178, 433);
            this.listBoxUsers.TabIndex = 8;
            // 
            // textBoxBuscadorUsers
            // 
            this.textBoxBuscadorUsers.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxBuscadorUsers.Location = new System.Drawing.Point(79, 31);
            this.textBoxBuscadorUsers.Multiline = true;
            this.textBoxBuscadorUsers.Name = "textBoxBuscadorUsers";
            this.textBoxBuscadorUsers.Size = new System.Drawing.Size(1140, 32);
            this.textBoxBuscadorUsers.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(41, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
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
            this.tabPageUsuarios.ResumeLayout(false);
            this.tabPageUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSuperuser;
        private System.Windows.Forms.TabPage tabPageRedLibrerias;
        private System.Windows.Forms.TabPage tabPageUsuarios;
        private System.Windows.Forms.ListBox listBoxLibrerias;
        private System.Windows.Forms.TextBox textBoxBuscadorLibrerias;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonEliminarLibrerias;
        private System.Windows.Forms.Button buttonModificarLibrerias;
        private System.Windows.Forms.Button buttonAnyadirLibrerias;
        private System.Windows.Forms.Button buttonEliminarUser;
        private System.Windows.Forms.Button buttonModificarUser;
        private System.Windows.Forms.Button buttonAnyadirUser;
        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.TextBox textBoxBuscadorUsers;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
