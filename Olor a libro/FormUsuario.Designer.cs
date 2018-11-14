namespace Olor_a_libro
{
    partial class FormUsuario
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxActividades = new System.Windows.Forms.ListBox();
            this.labelActividades = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxNombreUser = new System.Windows.Forms.TextBox();
            this.labelNombreUser = new System.Windows.Forms.Label();
            this.labelSuperuser = new System.Windows.Forms.Label();
            this.checkBoxSuperUser = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBoxActividades
            // 
            this.listBoxActividades.FormattingEnabled = true;
            this.listBoxActividades.Location = new System.Drawing.Point(15, 162);
            this.listBoxActividades.Name = "listBoxActividades";
            this.listBoxActividades.Size = new System.Drawing.Size(315, 147);
            this.listBoxActividades.TabIndex = 17;
            // 
            // labelActividades
            // 
            this.labelActividades.AutoSize = true;
            this.labelActividades.Location = new System.Drawing.Point(12, 139);
            this.labelActividades.Name = "labelActividades";
            this.labelActividades.Size = new System.Drawing.Size(118, 13);
            this.labelActividades.TabIndex = 16;
            this.labelActividades.Text = "Actividades realizadas :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(78, 89);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(252, 20);
            this.textBox3.TabIndex = 15;
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
            this.labelCorreo.Size = new System.Drawing.Size(47, 13);
            this.labelCorreo.TabIndex = 13;
            this.labelCorreo.Text = "Correo  :";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(12, 57);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(67, 13);
            this.labelPassword.TabIndex = 12;
            this.labelPassword.Text = "Contraseña :";
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
            this.labelNombreUser.Size = new System.Drawing.Size(50, 13);
            this.labelNombreUser.TabIndex = 10;
            this.labelNombreUser.Text = "Nombre :";
            // 
            // labelSuperuser
            // 
            this.labelSuperuser.AutoSize = true;
            this.labelSuperuser.Location = new System.Drawing.Point(230, 121);
            this.labelSuperuser.Name = "labelSuperuser";
            this.labelSuperuser.Size = new System.Drawing.Size(63, 13);
            this.labelSuperuser.TabIndex = 20;
            this.labelSuperuser.Text = "SuperUser :";
            // 
            // checkBoxSuperUser
            // 
            this.checkBoxSuperUser.AutoSize = true;
            this.checkBoxSuperUser.Location = new System.Drawing.Point(315, 120);
            this.checkBoxSuperUser.Name = "checkBoxSuperUser";
            this.checkBoxSuperUser.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSuperUser.TabIndex = 21;
            this.checkBoxSuperUser.UseVisualStyleBackColor = true;
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(197)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(342, 350);
            this.Controls.Add(this.checkBoxSuperUser);
            this.Controls.Add(this.labelSuperuser);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxActividades);
            this.Controls.Add(this.labelActividades);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.labelCorreo);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxNombreUser);
            this.Controls.Add(this.labelNombreUser);
            this.Name = "FormUsuario";
            this.Text = "FormUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxActividades;
        private System.Windows.Forms.Label labelActividades;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxNombreUser;
        private System.Windows.Forms.Label labelNombreUser;
        private System.Windows.Forms.Label labelSuperuser;
        private System.Windows.Forms.CheckBox checkBoxSuperUser;
    }
}