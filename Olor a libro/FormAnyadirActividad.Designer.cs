namespace Olor_a_libro
{
    partial class FormAnyadirActividad
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAceptarActividad = new System.Windows.Forms.Button();
            this.textBoxPuntos = new System.Windows.Forms.TextBox();
            this.labelPuntos = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textBoxNombreActividad = new System.Windows.Forms.TextBox();
            this.labelNombreActividad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "______________________________________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(331, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "______________________________________________________";
            // 
            // buttonAceptarActividad
            // 
            this.buttonAceptarActividad.Location = new System.Drawing.Point(266, 250);
            this.buttonAceptarActividad.Name = "buttonAceptarActividad";
            this.buttonAceptarActividad.Size = new System.Drawing.Size(58, 23);
            this.buttonAceptarActividad.TabIndex = 33;
            this.buttonAceptarActividad.Text = "Aceptar";
            this.buttonAceptarActividad.UseVisualStyleBackColor = true;
            this.buttonAceptarActividad.Click += new System.EventHandler(this.buttonAceptarActividad_Click);
            // 
            // textBoxPuntos
            // 
            this.textBoxPuntos.Location = new System.Drawing.Point(91, 193);
            this.textBoxPuntos.Name = "textBoxPuntos";
            this.textBoxPuntos.Size = new System.Drawing.Size(40, 20);
            this.textBoxPuntos.TabIndex = 31;
            // 
            // labelPuntos
            // 
            this.labelPuntos.AutoSize = true;
            this.labelPuntos.Location = new System.Drawing.Point(22, 196);
            this.labelPuntos.Name = "labelPuntos";
            this.labelPuntos.Size = new System.Drawing.Size(40, 13);
            this.labelPuntos.TabIndex = 30;
            this.labelPuntos.Text = "Puntos";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(91, 53);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(233, 109);
            this.textBoxDescripcion.TabIndex = 29;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(22, 56);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(63, 13);
            this.labelDescripcion.TabIndex = 28;
            this.labelDescripcion.Text = "Descripción";
            // 
            // textBoxNombreActividad
            // 
            this.textBoxNombreActividad.Location = new System.Drawing.Point(91, 17);
            this.textBoxNombreActividad.Name = "textBoxNombreActividad";
            this.textBoxNombreActividad.Size = new System.Drawing.Size(233, 20);
            this.textBoxNombreActividad.TabIndex = 27;
            // 
            // labelNombreActividad
            // 
            this.labelNombreActividad.AutoSize = true;
            this.labelNombreActividad.Location = new System.Drawing.Point(22, 20);
            this.labelNombreActividad.Name = "labelNombreActividad";
            this.labelNombreActividad.Size = new System.Drawing.Size(47, 13);
            this.labelNombreActividad.TabIndex = 26;
            this.labelNombreActividad.Text = "Nombre ";
            // 
            // FormAnyadirActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(197)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(342, 285);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAceptarActividad);
            this.Controls.Add(this.textBoxPuntos);
            this.Controls.Add(this.labelPuntos);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.textBoxNombreActividad);
            this.Controls.Add(this.labelNombreActividad);
            this.Name = "FormAnyadirActividad";
            this.Text = "FormAnyadirActividad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAceptarActividad;
        private System.Windows.Forms.TextBox textBoxPuntos;
        private System.Windows.Forms.Label labelPuntos;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox textBoxNombreActividad;
        private System.Windows.Forms.Label labelNombreActividad;
    }
}