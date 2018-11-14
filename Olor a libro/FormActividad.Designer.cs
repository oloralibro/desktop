namespace Olor_a_libro
{
    partial class FormActividad
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
            this.textBoxDescripcionActividad = new System.Windows.Forms.TextBox();
            this.buttonAceptarActividad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.35F);
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "labelNombreActividad";
            // 
            // textBoxDescripcionActividad
            // 
            this.textBoxDescripcionActividad.Location = new System.Drawing.Point(12, 53);
            this.textBoxDescripcionActividad.Multiline = true;
            this.textBoxDescripcionActividad.Name = "textBoxDescripcionActividad";
            this.textBoxDescripcionActividad.Size = new System.Drawing.Size(295, 135);
            this.textBoxDescripcionActividad.TabIndex = 1;
            // 
            // buttonAceptarActividad
            // 
            this.buttonAceptarActividad.Location = new System.Drawing.Point(232, 198);
            this.buttonAceptarActividad.Name = "buttonAceptarActividad";
            this.buttonAceptarActividad.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptarActividad.TabIndex = 2;
            this.buttonAceptarActividad.Text = "Aceptar";
            this.buttonAceptarActividad.UseVisualStyleBackColor = true;
            // 
            // FormActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(197)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(319, 229);
            this.Controls.Add(this.buttonAceptarActividad);
            this.Controls.Add(this.textBoxDescripcionActividad);
            this.Controls.Add(this.label1);
            this.Name = "FormActividad";
            this.Text = "FormActividad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDescripcionActividad;
        private System.Windows.Forms.Button buttonAceptarActividad;
    }
}