namespace Olor_a_libro
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.labelSeparacion = new System.Windows.Forms.Label();
            this.buttonCrearCuenta = new System.Windows.Forms.Button();
            this.labelRegistrar = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.PictureBoxIcono = new System.Windows.Forms.PictureBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.textBoxNombreUsuario = new System.Windows.Forms.TextBox();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSeparacion
            // 
            this.labelSeparacion.AutoSize = true;
            this.labelSeparacion.ForeColor = System.Drawing.Color.Black;
            this.labelSeparacion.Location = new System.Drawing.Point(1, 197);
            this.labelSeparacion.Name = "labelSeparacion";
            this.labelSeparacion.Size = new System.Drawing.Size(439, 13);
            this.labelSeparacion.TabIndex = 21;
            this.labelSeparacion.Text = "________________________________________________________________________";
            // 
            // buttonCrearCuenta
            // 
            this.buttonCrearCuenta.Location = new System.Drawing.Point(185, 231);
            this.buttonCrearCuenta.Name = "buttonCrearCuenta";
            this.buttonCrearCuenta.Size = new System.Drawing.Size(241, 23);
            this.buttonCrearCuenta.TabIndex = 20;
            this.buttonCrearCuenta.Text = "Registrarse";
            this.buttonCrearCuenta.UseVisualStyleBackColor = true;
            this.buttonCrearCuenta.Click += new System.EventHandler(this.buttonCrearCuenta_Click);
            // 
            // labelRegistrar
            // 
            this.labelRegistrar.AutoSize = true;
            this.labelRegistrar.Location = new System.Drawing.Point(19, 236);
            this.labelRegistrar.Name = "labelRegistrar";
            this.labelRegistrar.Size = new System.Drawing.Size(160, 13);
            this.labelRegistrar.TabIndex = 19;
            this.labelRegistrar.Text = "No tienes cuenta de olor a libro?";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(284, 160);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(142, 23);
            this.buttonCancel.TabIndex = 18;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // PictureBoxIcono
            // 
            this.PictureBoxIcono.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxIcono.Image")));
            this.PictureBoxIcono.Location = new System.Drawing.Point(12, 12);
            this.PictureBoxIcono.Name = "PictureBoxIcono";
            this.PictureBoxIcono.Size = new System.Drawing.Size(228, 52);
            this.PictureBoxIcono.TabIndex = 17;
            this.PictureBoxIcono.TabStop = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(137, 160);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(141, 23);
            this.buttonLogin.TabIndex = 16;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(106, 120);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.PasswordChar = '*';
            this.textBoxContraseña.Size = new System.Drawing.Size(320, 20);
            this.textBoxContraseña.TabIndex = 14;
            // 
            // textBoxNombreUsuario
            // 
            this.textBoxNombreUsuario.Location = new System.Drawing.Point(106, 83);
            this.textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            this.textBoxNombreUsuario.Size = new System.Drawing.Size(320, 20);
            this.textBoxNombreUsuario.TabIndex = 13;
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseña.Location = new System.Drawing.Point(39, 120);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(61, 13);
            this.labelContraseña.TabIndex = 12;
            this.labelContraseña.Text = "Contraseña";
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.AutoSize = true;
            this.labelNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreUsuario.Location = new System.Drawing.Point(19, 83);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(81, 13);
            this.labelNombreUsuario.TabIndex = 11;
            this.labelNombreUsuario.Text = "Nombre usuario";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(197)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(444, 277);
            this.Controls.Add(this.labelSeparacion);
            this.Controls.Add(this.buttonCrearCuenta);
            this.Controls.Add(this.labelRegistrar);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.PictureBoxIcono);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.textBoxNombreUsuario);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.labelNombreUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Olor A Libro - Login";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSeparacion;
        private System.Windows.Forms.Button buttonCrearCuenta;
        private System.Windows.Forms.Label labelRegistrar;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.PictureBox PictureBoxIcono;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.TextBox textBoxNombreUsuario;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.Label labelNombreUsuario;
    }
}

