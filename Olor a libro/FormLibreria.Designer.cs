namespace Olor_a_libro
{
    partial class FormLibreria
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
            this.labelNombreLibreria = new System.Windows.Forms.Label();
            this.textBoxNombreLibreria = new System.Windows.Forms.TextBox();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelHorario = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxHorario = new System.Windows.Forms.TextBox();
            this.labelActividades = new System.Windows.Forms.Label();
            this.listBoxActividades = new System.Windows.Forms.ListBox();
            this.buttonAceptarLibreria = new System.Windows.Forms.Button();
            this.buttonModificarLibreria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNombreLibreria
            // 
            this.labelNombreLibreria.AutoSize = true;
            this.labelNombreLibreria.Location = new System.Drawing.Point(12, 22);
            this.labelNombreLibreria.Name = "labelNombreLibreria";
            this.labelNombreLibreria.Size = new System.Drawing.Size(50, 13);
            this.labelNombreLibreria.TabIndex = 0;
            this.labelNombreLibreria.Text = "Nombre :";
            // 
            // textBoxNombreLibreria
            // 
            this.textBoxNombreLibreria.Location = new System.Drawing.Point(78, 19);
            this.textBoxNombreLibreria.Name = "textBoxNombreLibreria";
            this.textBoxNombreLibreria.Size = new System.Drawing.Size(252, 20);
            this.textBoxNombreLibreria.TabIndex = 1;
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(12, 57);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(58, 13);
            this.labelDireccion.TabIndex = 2;
            this.labelDireccion.Text = "Dirección :";
            // 
            // labelHorario
            // 
            this.labelHorario.AutoSize = true;
            this.labelHorario.Location = new System.Drawing.Point(12, 92);
            this.labelHorario.Name = "labelHorario";
            this.labelHorario.Size = new System.Drawing.Size(47, 13);
            this.labelHorario.TabIndex = 3;
            this.labelHorario.Text = "Horario :";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(78, 54);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(252, 20);
            this.textBoxDireccion.TabIndex = 4;
            // 
            // textBoxHorario
            // 
            this.textBoxHorario.Location = new System.Drawing.Point(78, 89);
            this.textBoxHorario.Name = "textBoxHorario";
            this.textBoxHorario.Size = new System.Drawing.Size(252, 20);
            this.textBoxHorario.TabIndex = 5;
            // 
            // labelActividades
            // 
            this.labelActividades.AutoSize = true;
            this.labelActividades.Location = new System.Drawing.Point(12, 132);
            this.labelActividades.Name = "labelActividades";
            this.labelActividades.Size = new System.Drawing.Size(68, 13);
            this.labelActividades.TabIndex = 6;
            this.labelActividades.Text = "Actividades :";
            // 
            // listBoxActividades
            // 
            this.listBoxActividades.FormattingEnabled = true;
            this.listBoxActividades.Location = new System.Drawing.Point(15, 163);
            this.listBoxActividades.Name = "listBoxActividades";
            this.listBoxActividades.Size = new System.Drawing.Size(315, 147);
            this.listBoxActividades.TabIndex = 7;
            // 
            // buttonAceptarLibreria
            // 
            this.buttonAceptarLibreria.Location = new System.Drawing.Point(272, 319);
            this.buttonAceptarLibreria.Name = "buttonAceptarLibreria";
            this.buttonAceptarLibreria.Size = new System.Drawing.Size(58, 23);
            this.buttonAceptarLibreria.TabIndex = 8;
            this.buttonAceptarLibreria.Text = "Aceptar";
            this.buttonAceptarLibreria.UseVisualStyleBackColor = true;
            // 
            // buttonModificarLibreria
            // 
            this.buttonModificarLibreria.Location = new System.Drawing.Point(197, 319);
            this.buttonModificarLibreria.Name = "buttonModificarLibreria";
            this.buttonModificarLibreria.Size = new System.Drawing.Size(58, 23);
            this.buttonModificarLibreria.TabIndex = 9;
            this.buttonModificarLibreria.Text = "Modificar";
            this.buttonModificarLibreria.UseVisualStyleBackColor = true;
            // 
            // FormLibreria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(197)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(342, 350);
            this.Controls.Add(this.buttonModificarLibreria);
            this.Controls.Add(this.buttonAceptarLibreria);
            this.Controls.Add(this.listBoxActividades);
            this.Controls.Add(this.labelActividades);
            this.Controls.Add(this.textBoxHorario);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.labelHorario);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.textBoxNombreLibreria);
            this.Controls.Add(this.labelNombreLibreria);
            this.Name = "FormLibreria";
            this.Text = "FormLibreria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombreLibreria;
        private System.Windows.Forms.TextBox textBoxNombreLibreria;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelHorario;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxHorario;
        private System.Windows.Forms.Label labelActividades;
        private System.Windows.Forms.ListBox listBoxActividades;
        private System.Windows.Forms.Button buttonAceptarLibreria;
        private System.Windows.Forms.Button buttonModificarLibreria;
    }
}