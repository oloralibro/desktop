namespace Olor_a_libro
{
    partial class FormAjustes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjustes));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonEditarIcono = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxLibrosFav = new System.Windows.Forms.ListBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxEditarCorreo = new System.Windows.Forms.TextBox();
            this.buttonEditarUsuario = new System.Windows.Forms.Button();
            this.buttonEditarCorreo = new System.Windows.Forms.Button();
            this.buttonCambiarContrasenya = new System.Windows.Forms.Button();
            this.buttonEditarLista = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonEditarIcono
            // 
            this.buttonEditarIcono.Location = new System.Drawing.Point(25, 171);
            this.buttonEditarIcono.Name = "buttonEditarIcono";
            this.buttonEditarIcono.Size = new System.Drawing.Size(128, 23);
            this.buttonEditarIcono.TabIndex = 1;
            this.buttonEditarIcono.Text = "Editar icono";
            this.buttonEditarIcono.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de usuario ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Correo electrónico ";
            // 
            // listBoxLibrosFav
            // 
            this.listBoxLibrosFav.FormattingEnabled = true;
            this.listBoxLibrosFav.Location = new System.Drawing.Point(25, 240);
            this.listBoxLibrosFav.Name = "listBoxLibrosFav";
            this.listBoxLibrosFav.Size = new System.Drawing.Size(544, 95);
            this.listBoxLibrosFav.TabIndex = 4;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(310, 22);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(259, 20);
            this.textBoxUsuario.TabIndex = 5;
            // 
            // textBoxEditarCorreo
            // 
            this.textBoxEditarCorreo.Location = new System.Drawing.Point(310, 90);
            this.textBoxEditarCorreo.Name = "textBoxEditarCorreo";
            this.textBoxEditarCorreo.Size = new System.Drawing.Size(259, 20);
            this.textBoxEditarCorreo.TabIndex = 6;
            // 
            // buttonEditarUsuario
            // 
            this.buttonEditarUsuario.Location = new System.Drawing.Point(441, 48);
            this.buttonEditarUsuario.Name = "buttonEditarUsuario";
            this.buttonEditarUsuario.Size = new System.Drawing.Size(128, 23);
            this.buttonEditarUsuario.TabIndex = 7;
            this.buttonEditarUsuario.Text = "Cambiar";
            this.buttonEditarUsuario.UseVisualStyleBackColor = true;
            // 
            // buttonEditarCorreo
            // 
            this.buttonEditarCorreo.Location = new System.Drawing.Point(441, 116);
            this.buttonEditarCorreo.Name = "buttonEditarCorreo";
            this.buttonEditarCorreo.Size = new System.Drawing.Size(128, 23);
            this.buttonEditarCorreo.TabIndex = 8;
            this.buttonEditarCorreo.Text = "Cambiar";
            this.buttonEditarCorreo.UseVisualStyleBackColor = true;
            // 
            // buttonCambiarContrasenya
            // 
            this.buttonCambiarContrasenya.Location = new System.Drawing.Point(25, 200);
            this.buttonCambiarContrasenya.Name = "buttonCambiarContrasenya";
            this.buttonCambiarContrasenya.Size = new System.Drawing.Size(128, 23);
            this.buttonCambiarContrasenya.TabIndex = 9;
            this.buttonCambiarContrasenya.Text = "Cambiar contraseña";
            this.buttonCambiarContrasenya.UseVisualStyleBackColor = true;
            // 
            // buttonEditarLista
            // 
            this.buttonEditarLista.Location = new System.Drawing.Point(188, 200);
            this.buttonEditarLista.Name = "buttonEditarLista";
            this.buttonEditarLista.Size = new System.Drawing.Size(128, 23);
            this.buttonEditarLista.TabIndex = 10;
            this.buttonEditarLista.Text = "Editar lista";
            this.buttonEditarLista.UseVisualStyleBackColor = true;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(441, 341);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(128, 37);
            this.buttonAceptar.TabIndex = 11;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // FormAjustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(197)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(590, 390);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.buttonEditarLista);
            this.Controls.Add(this.buttonCambiarContrasenya);
            this.Controls.Add(this.buttonEditarCorreo);
            this.Controls.Add(this.buttonEditarUsuario);
            this.Controls.Add(this.textBoxEditarCorreo);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.listBoxLibrosFav);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEditarIcono);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAjustes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Olor A Libro - Ajustes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonEditarIcono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxLibrosFav;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxEditarCorreo;
        private System.Windows.Forms.Button buttonEditarUsuario;
        private System.Windows.Forms.Button buttonEditarCorreo;
        private System.Windows.Forms.Button buttonCambiarContrasenya;
        private System.Windows.Forms.Button buttonEditarLista;
        private System.Windows.Forms.Button buttonAceptar;
    }
}