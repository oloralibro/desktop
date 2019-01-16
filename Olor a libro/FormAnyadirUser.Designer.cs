namespace Olor_a_libro
{
    partial class FormAnyadirUser
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
            this.checkBoxSuperUser = new System.Windows.Forms.CheckBox();
            this.labelSuperuser = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxNombreUser = new System.Windows.Forms.TextBox();
            this.labelNombreUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxSuperUser
            // 
            this.checkBoxSuperUser.AutoSize = true;
            this.checkBoxSuperUser.Location = new System.Drawing.Point(78, 150);
            this.checkBoxSuperUser.Name = "checkBoxSuperUser";
            this.checkBoxSuperUser.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSuperUser.TabIndex = 33;
            this.checkBoxSuperUser.UseVisualStyleBackColor = true;
            // 
            // labelSuperuser
            // 
            this.labelSuperuser.AutoSize = true;
            this.labelSuperuser.Location = new System.Drawing.Point(12, 151);
            this.labelSuperuser.Name = "labelSuperuser";
            this.labelSuperuser.Size = new System.Drawing.Size(60, 13);
            this.labelSuperuser.TabIndex = 32;
            this.labelSuperuser.Text = "SuperUser ";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(262, 179);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(68, 26);
            this.buttonAceptar.TabIndex = 30;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(78, 105);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(252, 20);
            this.textBoxCorreo.TabIndex = 27;
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(78, 61);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(252, 20);
            this.textBoxContraseña.TabIndex = 26;
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Location = new System.Drawing.Point(12, 108);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(44, 13);
            this.labelCorreo.TabIndex = 25;
            this.labelCorreo.Text = "Correo  ";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(12, 64);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(64, 13);
            this.labelPassword.TabIndex = 24;
            this.labelPassword.Text = "Contraseña ";
            // 
            // textBoxNombreUser
            // 
            this.textBoxNombreUser.Location = new System.Drawing.Point(78, 14);
            this.textBoxNombreUser.Name = "textBoxNombreUser";
            this.textBoxNombreUser.Size = new System.Drawing.Size(252, 20);
            this.textBoxNombreUser.TabIndex = 23;
            // 
            // labelNombreUser
            // 
            this.labelNombreUser.AutoSize = true;
            this.labelNombreUser.Location = new System.Drawing.Point(12, 17);
            this.labelNombreUser.Name = "labelNombreUser";
            this.labelNombreUser.Size = new System.Drawing.Size(47, 13);
            this.labelNombreUser.TabIndex = 22;
            this.labelNombreUser.Text = "Nombre ";
            // 
            // FormAnyadirUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(197)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(342, 217);
            this.Controls.Add(this.checkBoxSuperUser);
            this.Controls.Add(this.labelSuperuser);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.labelCorreo);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxNombreUser);
            this.Controls.Add(this.labelNombreUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAnyadirUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Olor A Libro - Añadir usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxSuperUser;
        private System.Windows.Forms.Label labelSuperuser;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxNombreUser;
        private System.Windows.Forms.Label labelNombreUser;
    }
}