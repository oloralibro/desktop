namespace Olor_a_libro
{
    partial class FormAjustesUsuario
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
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.listBoxActividades = new System.Windows.Forms.ListBox();
            this.labelActividades = new System.Windows.Forms.Label();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxNombreUser = new System.Windows.Forms.TextBox();
            this.labelNombreUser = new System.Windows.Forms.Label();
            this.labelSuperuser = new System.Windows.Forms.Label();
            this.checkBoxSuperUser = new System.Windows.Forms.CheckBox();
            this.textBoxPuntosTotales = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(197, 395);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(58, 23);
            this.buttonModificar.TabIndex = 19;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(272, 395);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(58, 23);
            this.buttonCancelar.TabIndex = 18;
            this.buttonCancelar.Text = "Aceptar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // listBoxActividades
            // 
            this.listBoxActividades.FormattingEnabled = true;
            this.listBoxActividades.Location = new System.Drawing.Point(15, 225);
            this.listBoxActividades.Name = "listBoxActividades";
            this.listBoxActividades.Size = new System.Drawing.Size(315, 147);
            this.listBoxActividades.TabIndex = 17;
            // 
            // labelActividades
            // 
            this.labelActividades.AutoSize = true;
            this.labelActividades.Location = new System.Drawing.Point(12, 202);
            this.labelActividades.Name = "labelActividades";
            this.labelActividades.Size = new System.Drawing.Size(115, 13);
            this.labelActividades.TabIndex = 16;
            this.labelActividades.Text = "Actividades realizadas ";
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(78, 89);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(252, 20);
            this.textBoxCorreo.TabIndex = 15;
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(78, 54);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(252, 20);
            this.textBoxContraseña.TabIndex = 14;
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Location = new System.Drawing.Point(12, 92);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(44, 13);
            this.labelCorreo.TabIndex = 13;
            this.labelCorreo.Text = "Correo  ";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(12, 57);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(64, 13);
            this.labelPassword.TabIndex = 12;
            this.labelPassword.Text = "Contraseña ";
            // 
            // textBoxNombreUser
            // 
            this.textBoxNombreUser.Location = new System.Drawing.Point(78, 19);
            this.textBoxNombreUser.Name = "textBoxNombreUser";
            this.textBoxNombreUser.Size = new System.Drawing.Size(252, 20);
            this.textBoxNombreUser.TabIndex = 11;
            // 
            // labelNombreUser
            // 
            this.labelNombreUser.AutoSize = true;
            this.labelNombreUser.Location = new System.Drawing.Point(12, 22);
            this.labelNombreUser.Name = "labelNombreUser";
            this.labelNombreUser.Size = new System.Drawing.Size(47, 13);
            this.labelNombreUser.TabIndex = 10;
            this.labelNombreUser.Text = "Nombre ";
            // 
            // labelSuperuser
            // 
            this.labelSuperuser.AutoSize = true;
            this.labelSuperuser.Location = new System.Drawing.Point(249, 150);
            this.labelSuperuser.Name = "labelSuperuser";
            this.labelSuperuser.Size = new System.Drawing.Size(60, 13);
            this.labelSuperuser.TabIndex = 20;
            this.labelSuperuser.Text = "SuperUser ";
            // 
            // checkBoxSuperUser
            // 
            this.checkBoxSuperUser.AutoCheck = false;
            this.checkBoxSuperUser.AutoSize = true;
            this.checkBoxSuperUser.Location = new System.Drawing.Point(315, 150);
            this.checkBoxSuperUser.Name = "checkBoxSuperUser";
            this.checkBoxSuperUser.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSuperUser.TabIndex = 21;
            this.checkBoxSuperUser.UseVisualStyleBackColor = true;
            // 
            // textBoxPuntosTotales
            // 
            this.textBoxPuntosTotales.Location = new System.Drawing.Point(92, 148);
            this.textBoxPuntosTotales.Name = "textBoxPuntosTotales";
            this.textBoxPuntosTotales.Size = new System.Drawing.Size(132, 20);
            this.textBoxPuntosTotales.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Puntos totales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "_______________________________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "_______________________________________________________";
            // 
            // FormAjustesUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(197)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(342, 436);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPuntosTotales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxSuperUser);
            this.Controls.Add(this.labelSuperuser);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.listBoxActividades);
            this.Controls.Add(this.labelActividades);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.labelCorreo);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxNombreUser);
            this.Controls.Add(this.labelNombreUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAjustesUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajustes de Usuario";
            this.Load += new System.EventHandler(this.FormAjustesUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.ListBox listBoxActividades;
        private System.Windows.Forms.Label labelActividades;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxNombreUser;
        private System.Windows.Forms.Label labelNombreUser;
        private System.Windows.Forms.Label labelSuperuser;
        private System.Windows.Forms.CheckBox checkBoxSuperUser;
        private System.Windows.Forms.TextBox textBoxPuntosTotales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}